using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInterface
{
    public partial class EquipMenu : Form
    {
        //lists to store items from database
        public List<PartyMember> partyMembers = new List<PartyMember>();
        public List<Weapon> inventoryWeapons = new List<Weapon>();

        //empty variables to store selected party member & weapon
        PartyMember selectedPartyMember = new PartyMember();
        Weapon selectedWeapon = new Weapon();

        //booleans to determine functions of select & back buttons
        Boolean frontPage = true, menuPage = false, finalPage = false;

        //array to store newly created stats & double to store status
        int[] newStats = { 0, 0, 0, 0, 0, 0, 0 };
        double newStatus = 0;

        //string used alongside booleans for select & back buttons
        string currentPage = "";

        //list of options for when character is selected
        string [] menu = {"Weapon", "Gear", "Accessory"};

        //new data access to obtain data
        DataAccess db = new DataAccess();
        public EquipMenu()
        {
            InitializeComponent();
            addPartyMembers();
            displayPartyMembers();
        }

        //gets party members from database
        private void addPartyMembers()
        {
            MainMenu mainMenu = new MainMenu();
            partyMembers = db.GetPartyMembers();
        }

        //puts obtained party members in menuBox
        private void displayPartyMembers()
        {
            menuBox.DataSource = null;
            menuBox.Items.Clear();
            menuBox.DataSource = partyMembers;
            menuBox.DisplayMember = "menuInfo";
        }

        //gets inventory weapons from database
        private void getInventoryWeapons()
        {
            inventoryWeapons = db.GetWeapons();
        }

        //puts obtained weapons in menuBox
        private void displayInventoryWeapons()
        {
            menuBox.DataSource = null;
            menuBox.Items.Clear();
            menuBox.DataSource = inventoryWeapons;
            menuBox.DisplayMember = "fullInfo";
        }

        //returns to main menu
        private void exitPage()
        {
            this.Owner.Show();
            this.Close();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            //if menu page, splits up selected item so equip type can be obtained, then displays appropraite page
            if(menuPage == true)
            {
                menuPage = false;
                string current = menuBox.SelectedItem as string;
                string[] type = current.Split();

                if (type[0] == "Weapon")
                {
                    currentPage = "Weapon";
                    getInventoryWeapons();
                    displayInventoryWeapons();
                }
            }

            //if weapon page, resets any previous newStats & gets selected weapon
            else if (currentPage == "Weapon")
            {
                for (int i=0; i<newStats.Length; i++)
                {
                    newStats[0] = 0;
                }

                selectedWeapon = menuBox.SelectedItem as Weapon;

                //if partyMember has no weapon equipped, add weapon stats to base stats
                if(selectedPartyMember.equippedWeapon == null)
                {
                    newStats[0] = selectedPartyMember.maxHealth + selectedWeapon.health;
                    newStats[1] = selectedPartyMember.meleeAttack + selectedWeapon.meleeAttack;
                    newStats[2] = selectedPartyMember.meleeDefence + selectedWeapon.meleeDefence;
                    newStats[3] = selectedPartyMember.rangedAttack + selectedWeapon.rangedAttack;
                    newStats[4] = selectedPartyMember.rangedDefence + selectedWeapon.rangedDefence;
                    newStats[5] = selectedPartyMember.movementSpeed + selectedWeapon.movementSpeed;
                    newStats[6] = selectedPartyMember.attackSpeed + selectedWeapon.attackSpeed;
                    newStatus = (selectedPartyMember.status + selectedWeapon.status) / 2;
                }

                //if weapon already equipped, subtract those stats first before adding new ones and saving in newStats
                else
                {
                    newStats[0] = (selectedPartyMember.maxHealth - selectedPartyMember.equippedWeapon.health) + selectedWeapon.health;
                    newStats[1] = (selectedPartyMember.meleeAttack - selectedPartyMember.equippedWeapon.meleeAttack) + selectedWeapon.meleeAttack;
                    newStats[2] = (selectedPartyMember.meleeDefence - selectedPartyMember.equippedWeapon.meleeDefence) + selectedWeapon.meleeDefence;
                    newStats[3] = (selectedPartyMember.rangedAttack - selectedPartyMember.equippedWeapon.rangedAttack) + selectedWeapon.rangedAttack;
                    newStats[4] = (selectedPartyMember.rangedDefence - selectedPartyMember.equippedWeapon.rangedDefence) + selectedWeapon.rangedDefence;
                    newStats[5] = (selectedPartyMember.movementSpeed - selectedPartyMember.equippedWeapon.movementSpeed) + selectedWeapon.movementSpeed;
                    newStats[6] = (selectedPartyMember.attackSpeed - selectedPartyMember.equippedWeapon.attackSpeed) + selectedWeapon.attackSpeed;
                    newStatus = (selectedPartyMember.status * 2) - selectedWeapon.status;
                }

                //add all new stats to comparison string in selectedPartyMember
                selectedPartyMember.addStats(newStats[0], selectedPartyMember.maxHealth);
                selectedPartyMember.addStats(newStats[1], selectedPartyMember.meleeAttack);
                selectedPartyMember.addStats(newStats[2], selectedPartyMember.meleeDefence);
                selectedPartyMember.addStats(newStats[3], selectedPartyMember.rangedAttack);
                selectedPartyMember.addStats(newStats[4], selectedPartyMember.rangedDefence);
                selectedPartyMember.addStats(newStats[5], selectedPartyMember.movementSpeed);
                selectedPartyMember.addStats(newStats[6], selectedPartyMember.attackSpeed);
                selectedPartyMember.addStatus(selectedPartyMember.status, selectedWeapon.status);

                //store & print comparison of stats before & stats after to demonstrate changes to user
                menuBox.DataSource = null;
                menuBox.Items.Clear();
                foreach (string i in selectedPartyMember.comparison)
                {
                    menuBox.Items.Add(i);
                }
                currentPage = "";
                finalPage = true;
            }

            //if final page, equip weapon & update Party Member stats
            else if (finalPage == true)
            {
                selectedPartyMember.equippedWeapon = selectedWeapon;

                selectedPartyMember.maxHealth = newStats[0];
                selectedPartyMember.meleeAttack = newStats[1];
                selectedPartyMember.meleeDefence= newStats[2];
                selectedPartyMember.rangedAttack = newStats[3];
                selectedPartyMember.rangedDefence= newStats[4];
                selectedPartyMember.movementSpeed = newStats[5];
                selectedPartyMember.attackSpeed = newStats[6];
                selectedPartyMember.status = newStatus;

                //if at full health, set equal to new max health too
                if (selectedPartyMember.currentHealth >= newStats[0])
                {
                    selectedPartyMember.currentHealth = newStats[0];
                }

                //loop back to party member list
                selectedPartyMember.stats.Clear();
                selectedPartyMember.comparison.Clear();
                finalPage = false;
                frontPage = true;
                displayPartyMembers();
            }

            //if on first page, store selected party member & display equip options (Weapon, Gear, Accessory)
            else
            {
                selectedPartyMember = menuBox.SelectedItem as PartyMember;
                menuBox.DataSource = null;
                menuBox.Items.Clear();

                for (int i = 0; i < menu.Length; i++)
                {
                    menuBox.Items.Add(menu[i]);
                }

                frontPage = false;
                menuPage = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //if first page, act as main menu button
            if (frontPage == true)
            {
                exitPage();
            }

            //if weapon page, go back to options menu
            else if(currentPage == "Weapon")
            {
                menuBox.DataSource = null;
                menuBox.Items.Clear();

                for (int i = 0; i < menu.Length; i++)
                {
                    menuBox.Items.Add(menu[i]);
                }

                currentPage = "";
                menuPage = true;
            }

            //if comparison/final page, clear selected weapon & display weapon inventory
            else if(finalPage == true)
            {
                selectedWeapon = null;
                currentPage = "Weapon";
                getInventoryWeapons();
                displayInventoryWeapons();
            }

            //if equip options page, display party member list
            else
            {
                displayPartyMembers();
                frontPage = true;
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            exitPage();
        }

    }
}
