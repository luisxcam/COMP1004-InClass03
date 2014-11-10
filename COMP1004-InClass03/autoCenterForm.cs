using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_InClass03
{
    public partial class autoCenterForm : Form
    {
        //Constants
        String[] SERVICES_EXTERIOR_STRING = { "Hand Wash", "Hand Wax", "Check Engine Fluids", "Detail Engine Compartment", "Detail Undercarriage" };
        String[] SERVICES_INTERIOR_STRING = { "Fragrance", "Shampoo Carpets", "Interior Protection Coat(dashboard and console)", "Shampoo Upholstery", "Scotchguard" };
        const int ITEMS_IN_STANDARD_INTEGER = 1;
        const int ITEMS_IN_DELUXE_INTEGER = 2;
        const int ITEMS_IN_EXECUTIVE_INTEGER = 3;
        const int ITEMS_IN_LUXURY_INTEGER = 5;



        public autoCenterForm()
        {
            InitializeComponent();
        }

        private void packageSelectedChanged(object sender, EventArgs e)
        {
            //instance variables
            int packageSelectedInteger = 0;

            //Select the amount of benefits to display
            switch (packageComboBox.Text)
            {
                case "Standard":
                    packageSelectedInteger = ITEMS_IN_STANDARD_INTEGER;
                    break;
                case "Deluxe":
                    packageSelectedInteger = ITEMS_IN_DELUXE_INTEGER;
                    break;
                case "Executive":
                    packageSelectedInteger = ITEMS_IN_EXECUTIVE_INTEGER;
                    break;
                case "Luxury":
                    packageSelectedInteger = ITEMS_IN_LUXURY_INTEGER;
                    break;
            }

            //Clear the list
            exteriorListBox.Items.Clear();
            interiorListBox.Items.Clear();

            //Fill the list boxes
            for (int x = 0; x < packageSelectedInteger; x++)
            {
                exteriorListBox.Items.Add(SERVICES_EXTERIOR_STRING[x]);
                interiorListBox.Items.Add(SERVICES_INTERIOR_STRING[x]);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exteriorListBox.Items.Clear();
            interiorListBox.Items.Clear();
            fraganceComboBox.Text = "";
            packageComboBox.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}
