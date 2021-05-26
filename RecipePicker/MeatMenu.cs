using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEATDll;

namespace RecipePicker
{
    public partial class MeatMenu : Form
    {
        public MeatMenu()
        {
            InitializeComponent();
        }

        private void MEATSpaghetti_Click(object sender, EventArgs e)
        {
            MEAT.spaghettiload(); //check the MEAT DLL, loads the spaghetti recipe in EDGE
        }

        private void MEATmeatloaf_Click(object sender, EventArgs e)
        {
            MEAT.meatloafload(); //same as above but with MEATLOAF
        }

        private void MEATsteak_Click(object sender, EventArgs e)
        {
            string filename = "SteakAndVeggies.pdf"; //so this opens up the steak and veggies recipe that I made and put in the same file. Opens it however your computer likes to open a PDF 
            System.Diagnostics.Process.Start(filename);
        }
    }
}
