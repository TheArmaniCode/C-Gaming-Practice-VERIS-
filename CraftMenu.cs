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
    public partial class CraftMenu : Form
    {
        List<Weapon> inventoryWeapons = new List<Weapon>();
        public List<Part> inventoryParts = new List<Part>();
        public List<ElementChip> chipList = new List<ElementChip>();
        public int value = 0;
        
    public CraftMenu()
        {
            InitializeComponent();
            insertParts();
            displayParts();
        }
        
        private void addValue(int value, Part selected)
        { 
            //selected.value = Selected Part.Value
            value += selected.value;
        }

        private void insertParts()
        {
            DataAccess db = new DataAccess();
            //inventoryParts = db.GetParts();
        }

        private void displayParts()
        {
            menuBox.DataSource = inventoryParts;
            menuBox.DisplayMember = "FullPartInfo";
        }

        private void displayChips()
        {
            menuBox.DataSource = chipList;
            menuBox.DisplayMember = "FullChipInfo";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            List<int> weaponStats = new List<int>();
            List<int> craftingStats = new List<int>();

            displayParts();
            //sort parts by key

            //value += selectedPart.value
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            menuBox.Items.Clear();
            displayChips();
        }
    }
}
