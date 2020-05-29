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
    public partial class PartyMenu : Form
    {
        public PartyMenu()
        {
            InitializeComponent();
            addPartyMembers();
            displayPartyMembers();
        }

        private void addPartyMembers()
        {
            MainMenu mainMenu = new MainMenu();
            DataAccess db = new DataAccess();
            //mainMenu.partyMembers = db.GetPartyMembers();
        }

        private void displayPartyMembers()
        {
            MainMenu mainMenu = new MainMenu();
            partyListBox.DataSource = mainMenu.partyMembers;
            partyListBox.DisplayMember = "FullInfo";
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            partyListBox.Text = "FullPartyMemberInfo";
        }
    }
}
