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
    public partial class ItemMenu : Form
    {
        List<Item> inventoryItems = new List<Item>();
        public ItemMenu()
        {
            InitializeComponent();
            addItems();
            countItems();
            displayItems();
        }

        private void addItems()
        {
            DataAccess db = new DataAccess();
            inventoryItems = db.GetItems();
        }

        private void countItems()
        {
            foreach (Item i in inventoryItems)
            {
                foreach(Item j in inventoryItems)
                {
                    if (i.name == j.name)
                    {
                        i.number++;
                    }
                }
            }
        }

        private void displayItems()
        {
            itemListBox.DataSource = inventoryItems;
            itemListBox.DisplayMember = "FullItemInfo";
        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            itemListBox.DataSource = inventoryItems;
            itemListBox.DisplayMember = "FullPartInfo";
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
