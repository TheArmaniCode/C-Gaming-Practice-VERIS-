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
        Boolean frontPage = true;
        public ItemMenu()
        {
            InitializeComponent();
            addItems();
            countItems();
            sortItems(inventoryItems);
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

        private void sortItems(List<Item> items)
        {
            Item current = new Item();
            int length = inventoryItems.Count;
            Boolean complete = false;
            int sorted = 0;
            while (complete == false)
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length - 1; j++)
                    {
                        if (inventoryItems[j].effect > inventoryItems[j + 1].effect)
                        {
                            current = inventoryItems[j];
                            inventoryItems[j] = inventoryItems[j + 1];
                            inventoryItems[j + 1] = current;
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

        private void displayItems()
        {
            itemListBox.DataSource = inventoryItems;
            itemListBox.DisplayMember = "BaseItemInfo";
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            itemListBox.DataSource = null;
            itemListBox.Items.Clear();
            itemListBox.DataSource = inventoryItems;
            itemListBox.DisplayMember = "FullItemInfo";
            frontPage = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(frontPage == true)
            {
                this.Owner.Show();
                this.Close();
            }
            else
            {
                itemListBox.DataSource = inventoryItems;
                itemListBox.DisplayMember = "BaseItemInfo";
                frontPage = true;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
