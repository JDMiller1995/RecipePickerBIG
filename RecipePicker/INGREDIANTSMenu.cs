using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipePicker
{

    public partial class INGREDIANTSMenu : Form
    {
        public static Dictionary<string, double> check = new Dictionary<string, double>(); //making a dictionary up here to be used below
        public INGREDIANTSMenu()
        {
            InitializeComponent();
        }

        internal void INGREDIANTSMenu_Load(object sender, EventArgs e)
        {
            //so each of these below is loading the dropbox I have for each menu item from my FUNCTIONS class where i set up these methods. 
            dropavocado.DataSource = Recipes.getavocado();
            dropblackbeans.DataSource = Recipes.getblackbeans();
            dropbreadcrumbs.DataSource = Recipes.getbreadcrumbs();
            dropbutter.DataSource = Recipes.getbutter();
            dropcilantro.DataSource = Recipes.getcilantro();
            dropeggs.DataSource = Recipes.geteggs();
            dropfeta.DataSource = Recipes.getfetacheese();
            dropflour.DataSource = Recipes.getflour();
            dropgarlic.DataSource = Recipes.getgarlic();
            dropgrapetomatoes.DataSource = Recipes.gettomatoes();
            dropmilk.DataSource = Recipes.getmilk();
            dropoliveoil.DataSource = Recipes.getoliveoil();
            droponion.DataSource = Recipes.getonions();
            droppasta.DataSource = Recipes.getpasta();
            droppepper.DataSource = Recipes.getblackpepper();
            dropsugar.DataSource = Recipes.getsugar();

        }

        internal void recipecheckbutton_Click(object sender, EventArgs e)
        {
                 //so this is taking each item and putting it in the "check" dictionary. I'll later compare these to each recipe with the same values in the dictionary and give recipes on the next form based on this. 
                check.Clear(); //this dictionary has to be empty at the beginning so this button can be reused. So makes sure empty, then fills, then other stuff happens. 
                check.Add("avocado", Convert.ToDouble(dropavocado.SelectedItem));
                check.Add("blackbeans", Convert.ToDouble(dropblackbeans.SelectedItem));
                check.Add("breadcrumbs", Convert.ToDouble(dropbreadcrumbs.SelectedItem));
                check.Add("butter", Convert.ToDouble(dropbutter.SelectedItem));
                check.Add("cilantro", Convert.ToDouble(dropcilantro.SelectedItem));
                check.Add("eggs", Convert.ToDouble(dropeggs.SelectedItem));
                check.Add("fetacheese", Convert.ToDouble(dropfeta.SelectedItem));
                check.Add("flour", Convert.ToDouble(dropflour.SelectedItem));
                check.Add("garlic", Convert.ToDouble(dropgarlic.SelectedItem));
                check.Add("tomatoes", Convert.ToDouble(dropgrapetomatoes.SelectedItem));
                check.Add("milk", Convert.ToDouble(dropmilk.SelectedItem));
                check.Add("oliveoil", Convert.ToDouble(dropoliveoil.SelectedItem));
                check.Add("onions", Convert.ToDouble(droponion.SelectedItem));
                check.Add("pasta", Convert.ToDouble(droppasta.SelectedItem));
                check.Add("blackpepper", Convert.ToDouble(droppepper.SelectedItem));
                check.Add("sugar", Convert.ToDouble(dropsugar.SelectedItem));
                IngrediantsRecipes show = new IngrediantsRecipes(); //pulls up the available recipes after making the dictionary 
                show.Visible = true;
        } 
    }
}
