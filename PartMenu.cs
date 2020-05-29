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
    public partial class PartMenu : Form
    {
        CraftMenu craftMenu = new CraftMenu();
        public PartMenu()
        {
            InitializeComponent();
            addParts();
            displayParts();
        }

        private void addParts()
        {
            DataAccess db = new DataAccess();
            craftMenu.inventoryParts = db.GetParts();
        }

        private void displayParts()
        {
            craftListBox.DataSource = craftMenu.inventoryParts;
            craftListBox.DisplayMember = "FullPartInfo";
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
