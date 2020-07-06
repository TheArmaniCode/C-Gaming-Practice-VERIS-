using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInterface
{
    public partial class PartyMenu : Form
    {
        public List<PartyMember> partyMembers = new List<PartyMember>();
        public Boolean frontPage = true;
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
            partyMembers = db.GetPartyMembers();
        }

        private void viewPartyMember(PartyMember current)
        {
            partyListBox.DataSource = null;
            partyListBox.Items.Clear();
            partyListBox.Items.Add(current.fullInfo);
        }

        private void displayPartyMembers()
        {
            partyListBox.DataSource = null;
            partyListBox.Items.Clear();
            partyListBox.DataSource = partyMembers;
            partyListBox.DisplayMember = "menuInfo";
        }

        private void exitPage()
        {
            this.Owner.Show();
            this.Close();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            exitPage();
        }
        private void ViewButton_Click(object sender, EventArgs e)
        {
            PartyMember current = partyListBox.SelectedItem as PartyMember;
            viewPartyMember(current);
            frontPage = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (frontPage == true)
            {
                exitPage();
            }
            else
            {
                displayPartyMembers();
                frontPage = true;
            }
        }
    }
}
