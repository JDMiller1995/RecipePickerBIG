using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VEGGIEDLL;
using System.Timers;

namespace RecipePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void viewVeggie_Click(object sender, EventArgs e)
        {
            VEGGIEmenu show = new VEGGIEmenu(); //this calls to/creates my other forms (this one is specifically veggie menu) 
            show.Visible = true; //this shows my form I just made:) each view menu thing below is the same 
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            ALLMenu show = new ALLMenu();
            show.Visible = true;
        }

        private void viewMeat_Click(object sender, EventArgs e)
        {
            MeatMenu show = new MeatMenu();
            show.Visible = true;
        }

        private void viewVegan_Click(object sender, EventArgs e)
        {
            VEGANmenu show = new VEGANmenu();
            show.Visible = true;
        }

        private void viewDessert_Click(object sender, EventArgs e)
        {
            DESSERTMenu show = new DESSERTMenu();
            show.Visible = true;
        }

        private void viewIngrediants_Click(object sender, EventArgs e)
        {
            INGREDIANTSMenu show = new INGREDIANTSMenu();
            show.Visible = true;
        }

        private void addRecipe_Click(object sender, EventArgs e) 
        {
            RecipeBox.Clear(); //when someone clicks my add recipe button, I want to clear the text boxes I have for recipes and their names. then I want the recipe box to be visible as well as the save recipe button to be visible and able to be touched
            RecipeName.Clear();
            RecipeBox.Visible = true;
            SaveRecipe.Visible = true;
            SaveRecipe.Enabled = true;
            
        }

        private void SaveRecipe_Click(object sender, EventArgs e)
        {
            RecipeName.Visible = true; //makes the name box for saving the file visible 
            finalizebutton.Visible = true; //enables the finalize button which will let finalize saving the recipe
            finalizebutton.Enabled = true; //allows people to click the finalize button 
            MessageBox.Show("What file name would you like? Make sure to input it in the new text box without spaces or weird characters, then click the finalize recipe button! If you already have a file named this, it will add to that file."); //gives user info
            SaveRecipe.Enabled = false; //this stops people from messing up mah program so that they can only finish up the recipe lol
            addRecipe.Enabled = false;
        }

        private async void finalizebutton_Click(object sender, EventArgs e) //HAD TO MAKE THIS ASYNC SO IT WOULD WAIT WHEN I SET A TIMER 
        {
            try //can't let this be outside of a try/catch in case there are issues with the saving of a name 
            {
                FUNCTIONS.SaveRecipesfunction(RecipeBox.Text, RecipeName.Text); //this calls my save recipe function and sends the text to a file as well as saves the file with the name the user input, check FUNCTIONS for how it works
                RecipeName.Visible = false; //just making all the buttons/text boxes dissapear once done. 
                SaveRecipe.Visible = false;
                finalizebutton.Visible = false;
                addRecipe.Enabled = true; //gotta reenable the add recipe button so people can add more recipes
                RecipeBox.Visible = false;
            }
            catch
            {
                FUNCTIONS use = new FUNCTIONS(); //initialize an object so i can use the timer
                MessageBox.Show("You input something that wasn't allowed for the name! You have 15 seconds to change the name.");
                try
                {
                    finalizebutton.Enabled = false;
                    await use.timer(); //this gives people 15 seconds before trying to automatically save the file again, it does this once more and then if it still is an unallowed name, it boots them 
                    FUNCTIONS.SaveRecipesfunction(RecipeBox.Text, RecipeName.Text);
                    RecipeName.Visible = false;
                    SaveRecipe.Visible = false;
                    finalizebutton.Visible = false;
                    addRecipe.Enabled = true;
                    RecipeBox.Visible = false;
                }
                catch
                {
                    MessageBox.Show("You did it again!");
                    try
                    {
                        finalizebutton.Enabled = false;
                        await use.timer();
                        FUNCTIONS.SaveRecipesfunction(RecipeBox.Text, RecipeName.Text);
                        RecipeName.Visible = false;
                        SaveRecipe.Visible = false;
                        finalizebutton.Visible = false;
                        addRecipe.Enabled = true;
                        RecipeBox.Visible = false;
                    }
                    catch
                    {
                        MessageBox.Show("You did it again, I'm clearing out your recipe."); //no more chances, they'll have to retype everything 
                        RecipeName.Visible = false;
                        SaveRecipe.Visible = false;
                        finalizebutton.Visible = false;
                        addRecipe.Enabled = true;
                        RecipeBox.Visible = false;
                    }
                }
                
            }
        }

        private void viewUserRecipes_Click(object sender, EventArgs e)
        {
            FUNCTIONS.OpenRecipes(); //this opens the file where I save the user input recipes, check FUNCTIONS for how it works.
        }
    }
}
