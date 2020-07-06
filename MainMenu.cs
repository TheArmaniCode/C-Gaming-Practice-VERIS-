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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            UpdateBinding();
        }
        public List<PartyMember> partyMembers = new List<PartyMember>();
        private void UpdateBinding()
        {
            PartyMembersFoundList.DataSource = partyMembers;
            PartyMembersFoundList.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            //partyMembers = db.GetPartyMembers(NameText.Text);

            UpdateBinding();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            //convert all int boxes to ints
            int hp = Int32.Parse(hpBox.Text);
            int meleeAttack = Int32.Parse(meleeAttackBox.Text);
            int meleeDefence = Int32.Parse(meleeDefenceBox.Text);
            int rangedAttack = Int32.Parse(rangedAttackBox.Text);
            int rangedDefence = Int32.Parse(rangedDefenceBox.Text);
            int movementSpeed = Int32.Parse(movementSpeedBox.Text);
            int attackSpeed = Int32.Parse(attackSpeedBox.Text);

            /*db.InsertPartyMember(NameBox.Text, WeaponBox.Text, hp, meleeAttack, meleeDefence,
                rangedAttack, rangedDefence, movementSpeed, attackSpeed);*/

            NameBox.Text = "";
            WeaponBox.Text = "";
            hpBox.Text = "";
            meleeAttackBox.Text = "";
            meleeDefenceBox.Text = "";
            rangedAttackBox.Text = "";
            rangedDefenceBox.Text = "";
            movementSpeedBox.Text = "";
            attackSpeedBox.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void WeaponBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void craftButton_Click(object sender, EventArgs e)
        {
            Form craftMenu = new CraftMenu();
            craftMenu.Owner = this;
            craftMenu.Show();
            this.Hide();
        }

        private void partyButton_Click(object sender, EventArgs e)
        {
            Form partyMenu = new PartyMenu();
            partyMenu.Owner = this;
            partyMenu.Show(this);
            this.Hide();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            Form partMenu = new PartMenu();
            partMenu.Owner = this;
            partMenu.Show(this);
            this.Hide();
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            Form itemMenu = new ItemMenu();
            itemMenu.Owner = this;
            itemMenu.Show(this);
            this.Hide();
        }

        private void equipButton_Click(object sender, EventArgs e)
        {
            Form equipMenu = new EquipMenu();
            equipMenu.Owner = this;
            equipMenu.Show(this);
            this.Hide();
        }
    }
   
}
