using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DESSERTdll;

namespace RecipePicker
{
    public partial class DESSERTMenu : Form
    {
        public DESSERTMenu()
        {
            InitializeComponent();
        }

        private void dessertBananaBread_Click(object sender, EventArgs e)
        {
            DESSERT.bananaload(); //same as the others, opens each in EDGE, check dessert DLL for how
        }

        private void dessertFriedApples_Click(object sender, EventArgs e)
        {
            DESSERT.applesload();
        }

        private void DessertchocolateChip_Click(object sender, EventArgs e)
        {
            DESSERT.cookieload();
        }
    }
}
