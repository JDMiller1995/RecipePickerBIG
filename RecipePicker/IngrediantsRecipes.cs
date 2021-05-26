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
    public partial class IngrediantsRecipes : Form
    {
        public IngrediantsRecipes()
        {
            InitializeComponent();
        }

        private void IngrediantsRecipes_Load(object sender, EventArgs e)
        {
            
            string[] listarray = new string[10]; //Since I have 10 web recipes, I settled on 10 available from the picker. This created a string array to store some info below
            listarray[0] = Recipes.quinoachecker(INGREDIANTSMenu.check); //these functions compare the dictionary we made in the INGREDIANTSMenu with each recipe and it's own dictionary of needed ingrediants. 
            listarray[1] = Recipes.charredpastachecker(INGREDIANTSMenu.check); //Once the comparison is done, if the user indicated they had enough ingrediants, this method returns the name of the Recipe
            listarray[2] = Recipes.BlackBeanBurger(INGREDIANTSMenu.check); //if the user indicated they did not have enough ingrediants, it returns the string "Not enough Ingrediants" 
            listarray[3] = Recipes.avocadocharredtomatobowl(INGREDIANTSMenu.check); //check FUNCTIONS to see these coded 
            listarray[4] = Recipes.pennepasta(INGREDIANTSMenu.check);
            listarray[5] = Recipes.bananabread(INGREDIANTSMenu.check);
            listarray[6] = Recipes.chocolatechipcookies(INGREDIANTSMenu.check);
            listarray[7] = Recipes.friedapples(INGREDIANTSMenu.check);
            listarray[8] = Recipes.meatloaf(INGREDIANTSMenu.check);
            listarray[9] = Recipes.spaghetti(INGREDIANTSMenu.check);

            linkLabel1.Text = listarray[0]; //So in this menu i have 10 linklabels, and this just makes the displayed text either the name OR "Not enough Ingrediants" 
            linkLabel2.Text = listarray[1];
            linkLabel3.Text = listarray[2];
            linkLabel4.Text = listarray[3];
            linkLabel5.Text = listarray[4];
            linkLabel6.Text = listarray[5];
            linkLabel7.Text = listarray[6];
            linkLabel8.Text = listarray[7];
            linkLabel9.Text = listarray[8];
            linkLabel10.Text = listarray[9];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!linkLabel1.Text.Contains("Not enough ingredients")) //each of these below basically makes sure the text in the linklabel doesnt say not enough ingrediants, and if it doesn't say that, it turns it into a link for the recipe(: 
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://www.cookinglight.com/recipes/quinoa-bowls-avocado-egg"); //these just open edge to the rigth recipe 
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel2.Text.Contains("Not enough ingredients")) //yeah I know I couldv'e done "linklabel2.text != "Not enough Ingrediants" BUTTTTT I was trying to put the name then "not enough ingrediants" but the form was too small and it looked bad.
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://www.cookinglight.com/recipes/pasta-charred-broccoli-feta-lemon");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel3.Text.Contains("Not enough ingredients"))
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://sallysbakingaddiction.com/best-black-bean-burgers/#tasty-recipes-66440-jump-target");
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel4.Text.Contains("Not enough ingredients"))
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://www.cookinglight.com/recipes/avocado-black-bean-and-charred-tomato-bowl");
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel5.Text.Contains("Not enough ingredients"))
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://www.pastabased.com/vegan-penne-alla-vodka/");

            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel6.Text.Contains("Not enough ingredients"))
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://www.simplyrecipes.com/recipes/banana_bread/");
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel7.Text.Contains("Not enough ingredients"))
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://www.allrecipes.com/recipe/10813/best-chocolate-chip-cookies/");
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel8.Text.Contains("Not enough ingredients"))
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://www.tasteofhome.com/recipes/mom-s-fried-apples/");
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel9.Text.Contains("Not enough ingredients"))
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://www.allrecipes.com/recipe/16354/easy-meatloaf/");
            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!linkLabel10.Text.Contains("Not enough ingredients"))
            {
                System.Diagnostics.Process.Start("microsoft-edge:https://www.allrecipes.com/recipe/21353/italian-spaghetti-sauce-with-meatballs/");
            }
        }
    }
}
