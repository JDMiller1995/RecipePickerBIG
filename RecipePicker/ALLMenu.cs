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
using VEGANDll;
using VEGGIEDLL;
using DESSERTdll;

namespace RecipePicker
{
    public partial class ALLMenu : Form
    {
        public ALLMenu()
        {
            InitializeComponent();
        }

        private void Allmeatloaf_Click(object sender, EventArgs e)
        {
            MEAT.meatloafload(); //each of these are the same as the seperated menus. Each DLL has the logic
        }

        private void AllSpaghetti_Click(object sender, EventArgs e)
        {
            MEAT.spaghettiload();
        }

        private void allveganpenne_Click(object sender, EventArgs e)
        {
            VEGAN.PenneLoad();
        }

        private void Allavocadobowl_Click(object sender, EventArgs e)
        {
            VEGAN.Avocadoload();
        }

        private void Allquinoabowl_Click(object sender, EventArgs e)
        {
            VEGGIE.Quinoaload();
        }

        private void allCharredbroccoliPasta_Click(object sender, EventArgs e)
        {
            VEGGIE.CharredbroccoliLoad();
        }

        private void AllBlackbeanBurgers_Click(object sender, EventArgs e)
        {
            VEGGIE.BlackBeanBurgersload();
        }

        private void AllBananaBread_Click(object sender, EventArgs e)
        {
            DESSERT.bananaload();
        }

        private void AllchocolateChip_Click(object sender, EventArgs e)
        {
            DESSERT.cookieload();
        }

        private void AllFriedApples_Click(object sender, EventArgs e)
        {
            DESSERT.applesload();
        }

        private void Allsteak_Click(object sender, EventArgs e)
        {
            string filename = "SteakAndVeggies.pdf"; //PDF Loader from file I put in with project bin folder
            System.Diagnostics.Process.Start(filename);
        }

        private void AllbutterHerbPasta_Click(object sender, EventArgs e)
        {
            string filename = "EasyGarlicParmPasta.pdf";
            System.Diagnostics.Process.Start(filename);
        }
    }
}
