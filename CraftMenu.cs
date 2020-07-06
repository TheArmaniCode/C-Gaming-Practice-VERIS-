using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInterface
{
    public partial class CraftMenu : Form
    {
        //lists to store components from database
        public List<Weapon> inventoryWeapons = new List<Weapon>();
        public List<Part> inventoryParts = new List<Part>();
        public List<ElementChip> chipList = new List<ElementChip>();
        public List<PartyMember> partyMembers = new List<PartyMember>();
        public List<PartyMemberCraft> stats = new List<PartyMemberCraft>();

        //variable to store selected item
        public Weapon selectedWeapon = new Weapon();
        public PartyMemberCraft craftStats = new PartyMemberCraft();

        //lists to store created variables for future use
        public List<Part> deletedParts = new List<Part>();
        public ElementChip deletedChip = new ElementChip();
        public List<PartyMemberCraft> finalStats = new List<PartyMemberCraft>();

        //general use variables
        public int value, parts, deleted, deletedLength, length;
        public string name;
        public Part previous = new Part();

        //booleans to determine  use of select & back buttons
        Boolean frontPage = true, partPage = true, chipPage = false, partyMemberPage = false, finalPage = false;

        //data access to obtain data
        DataAccess db = new DataAccess();

        public CraftMenu()
        {
            InitializeComponent();
            insertParts();
            sortParts(inventoryParts);
            displayParts();
        }

        //database functions to get variables & read them into lists
        private void insertParts()
        {
            inventoryParts = db.GetParts();
        }

        private void insertChips()
        {
            chipList = db.GetChips();
        }

        private void insertPartyMembers()
        {
            partyMembers = db.GetPartyMembers();
        }

        private void insertPartyMembersCraft()
        {
            stats = db.GetCraftingStats();
        }

        //add selected party members stats to list for multiplication reference
        private void getStats(string name)
        {
            stats = db.GetCraftingStatsByName(name);
        }

        //get specific weapon by value & element (crafting result)
        private void getWeapon(int value, string element)
        {
            List<Weapon> w = new List<Weapon>();
            w = db.GetCraftedWeapon(value, element);
            foreach (Weapon i in w)
            {
                selectedWeapon = i;
            }
        }

        //store crafted weapon in database
        private void storeWeapon(Weapon weapon)
        {
            db.InsertWeapon(weapon.name, weapon.type, weapon.health, weapon.meleeAttack, weapon.meleeDefence, weapon.rangedAttack, weapon.rangedDefence, weapon.movementSpeed, weapon.attackSpeed, weapon.status, weapon.element);
        }

        //display various lists in menuBox
        private void displayParts()
        {
            menuBox.DataSource = null;
            menuBox.Items.Clear();
            menuBox.DataSource = inventoryParts;
            menuBox.DisplayMember = "FullPartInfo";
        }

        private void displayChips()
        {
            menuBox.DataSource = null;
            menuBox.Items.Clear();
            menuBox.DataSource = chipList;
            menuBox.DisplayMember = "FullChipInfo";
        }

        private void displayPartyMemberCraft()
        {
            menuBox.DataSource = null;
            menuBox.Items.Clear();
            menuBox.DataSource = stats;
            menuBox.DisplayMember = "FullCraftInfo";
        }

        //display before and after stats to demonstrate changes to user
        private void displayStats(PartyMemberCraft craftStats)
        {
            menuBox.DataSource = null;
            menuBox.Items.Clear();
            menuBox.DataSource = craftStats.comparison;
            foreach (string i in craftStats.comparison)
            {
                menuBox.DisplayMember = i;
            }
        }

        //sort algorithms
        private void sortParts(List<Part> parts)
        {
            Part current = new Part();
            int length = parts.Count;
            Boolean complete = false;
            int sorted = 0;
            while (complete == false)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length - 1; j++)
                    {
                        if (parts[j].value > parts[j + 1].value)
                        {
                            current = parts[j];
                            parts[j] = parts[j + 1];
                            parts[j + 1] = current;
                            sorted++;
                        }
                    }
                }
                if (sorted == 0)
                {
                    complete = true;
                }
                sorted = 0;
            }
        }

        private void sortChips(List<ElementChip> chips)
        {
            ElementChip current = new ElementChip();
            int length = chipList.Count;
            Boolean complete = false;
            int sorted = 0;
            while (complete == false)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length - 1; j++)
                    {
                        if (chips[j].value > chips[j + 1].value)
                        {
                            current = chips[j];
                            chips[j] = chips[j + 1];
                            chips[j + 1] = current;
                            sorted++;
                        }
                    }
                }
                if (sorted == 0)
                {
                    complete = true;
                }
                sorted = 0;
            }
        }

        //add button adds parts & registers removed parts in list 
        private void selectButton_Click(object sender, EventArgs e)
        {
            if (frontPage == true || partPage == true)
            {
                List<int> weaponStats = new List<int>();
                List<int> craftingStats = new List<int>();
                Part current = menuBox.SelectedItem as Part;

                //add value of used parts together to help determine new weapon created
                value += current.value;
                previous = menuBox.SelectedItem as Part;
                deletedParts.Add(previous);
                deleted++;
                inventoryParts.Remove(current);
                sortParts(inventoryParts);
                displayParts();
                parts++;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //register number of parts removed from list due to crafting
            deletedLength = deletedParts.Count;

            //if front page, act as menu button
            if (frontPage == true)
            {
                this.Owner.Show();
                this.Close();
            }

            //if party member page, add deleted chip back to list, then display
            else if (partyMemberPage == true)
            {
                chipList.Add(deletedChip);
                deletedChip = null;
                sortChips(chipList);
                displayChips();
                partyMemberPage = false;
                chipPage = true;
            }

            //if final page, show crafting party members list
            else if (finalPage == true)
            {
                craftStats.comparison.Clear();
                craftStats.stats.Clear();
                insertPartyMembersCraft();
                displayPartyMemberCraft();

                finalPage = false;
                partyMemberPage = true;
            }

            //if chip page or not full part list, add last deleted part back 
            else
            {
                inventoryParts.Add(deletedParts[deletedParts.Count - 1]);
                deletedParts.RemoveAt(deletedParts.Count - 1);
                sortParts(inventoryParts);
                parts--;

                //if parts are zero, next back will take to main menu
                if (parts == 0)
                {
                    frontPage = true;
                }
                sortParts(inventoryParts);
                displayParts();
                partPage = true;
                chipPage = false;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //can only craft with two or more parts
            if (parts >= 2)
            {
                frontPage = false;
                //if final page, add new stats to party member
                if (finalPage == true)
                {
                    selectedWeapon.health = craftStats.stats[0];
                    selectedWeapon.meleeAttack = craftStats.stats[1];
                    selectedWeapon.meleeDefence = craftStats.stats[2];
                    selectedWeapon.rangedAttack = craftStats.stats[3];
                    selectedWeapon.rangedDefence = craftStats.stats[4];
                    selectedWeapon.movementSpeed = craftStats.stats[5];
                    selectedWeapon.attackSpeed = craftStats.stats[6];
                    selectedWeapon.status = craftStats.status;

                    //store weapon in inventory database, then clear all temporary variables & loop back to start
                    storeWeapon(selectedWeapon);
                    displayParts();
                    craftStats.comparison.Clear();
                    craftStats.stats.Clear();

                    finalPage = false;
                    frontPage = true;
                }

                //if chip page, save current chip in case of back button, then display list of party members to craft the weapon
                else if (chipPage == true)
                {
                    ElementChip current = menuBox.SelectedItem as ElementChip;
                    inventoryParts.Remove(current);
                    deletedChip = current;
                    getWeapon(value, current.element);
                    //displayPartyMembers
                    insertPartyMembersCraft();
                    displayPartyMemberCraft();
                    partyMemberPage = true;
                    chipPage = false;
                    finalPage = false;
                }

                //if party member page, multiply crafted weapon stats by party members crafting modifiers
                else if (partyMemberPage == true)
                {
                    PartyMemberCraft p = menuBox.SelectedItem as PartyMemberCraft;
                    getStats(p.name);

                    //use blank party member craft to store weapon stats
                    craftStats.addStats(selectedWeapon.health, stats[0].health);
                    craftStats.addStats(selectedWeapon.meleeAttack, stats[0].meleeAttack);
                    craftStats.addStats(selectedWeapon.meleeDefence, stats[0].meleeDefence);
                    craftStats.addStats(selectedWeapon.rangedAttack, stats[0].rangedAttack);
                    craftStats.addStats(selectedWeapon.rangedDefence, stats[0].rangedDefence);
                    craftStats.addStats(selectedWeapon.movementSpeed, stats[0].movementSpeed);
                    craftStats.addStats(selectedWeapon.attackSpeed, stats[0].attackSpeed);
                    craftStats.addStatus(selectedWeapon.status, stats[0].status);

                    //print out before and after stats to demonstrate changes to user
                    displayStats(craftStats);

                    partyMemberPage = false;
                    finalPage = true;
                }
                else
                {
                    partPage = false;
                    insertChips();
                    sortChips(chipList);
                    displayChips();
                    //frontPage = false;
                    chipPage = true;
                }
            }
        }
    }
}
