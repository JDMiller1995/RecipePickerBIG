using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace RecipePicker
{ //ALRIGHTYYYYY SO THIS IS WHERE THE MILK AND BUTTER HAPPENS
    class FUNCTIONS
    {
        public static void SaveRecipesfunction(string input, string name) //so this is for saving user input recipes to a file within the program so they can be accessed later 
        {

            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase); //so this makes sure i have the path of where my executable is 
            path = path.Substring(6); //so now I have the path for the bin folder. we can take that and append name and then .pdf and save, the path is given as file:\\C:\\ though, and I need it to start at C:\\
            StreamWriter recipe = new StreamWriter(path + "\\Recipes\\" + name + ".txt"); //THIS starts a streamwriter to whatever file name is passed through here and ends it in .txt, it's done inside the bin folder and named recipes
            recipe.Write(input); //writes the input, which is the text box I opened up. These parameters are seen in the form1.cs 
            recipe.Close(); //gotta memba to close it 
        }
        public async Task timer() //okay so i needed a timer of 15 seconds where people could change their file name if it was somehting that windows doesnt allow and that's what this function does. it's my 15 sec timer 
        {
            await Task.Delay(15000);
        }
        public static void OpenRecipes() //this method opens up the recipes folder where I save the recipes given above 
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6) + "\\Recipes";
            ProcessStartInfo startInfo = new ProcessStartInfo //gotta start explorer.exe (file explorer) at the path where the recipes be 
            {
                Arguments = path,
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);   
        }
    }
    class Recipes
    {
        public static double[] getoliveoil() //so all of these below are for filling in the drop boxes on ingredientsmenu. I made them doubles so they can all chill in the dictionary and it was quicker/easier while typing out .25 stuff 
        {
            double[] oliveoil = new double[5] { 0, 1, 2, 3, 4 };
            return oliveoil;
        }
        public static double[] gettomatoes()
        {
            double[] grapetomatoes = new double[3] { 0, .5, 1 };
            return grapetomatoes;
        }
        public static double[] getcilantro()
        {
            double[] cilantro = new double[3] { 0, 1, 2 };
            return cilantro;
        }
        public static double[] geteggs()
        {
            double[] eggs = new double[3] { 0, 1, 2 };
            return eggs;
        }
        public static double[] getavocado()
        {
            double[] avocado = new double[2] { 0, 1 };
            return avocado;
        }
        public static double[] getpasta()
        {
            double[] pasta = new double[3] { 0, 8, 16 };
            return pasta;
        }
        public static double[] getgarlic()
        {
            double[] garlic = new double[7] { 0, 1, 2, 3, 4, 5, 6 };
            return garlic;
        }
        public static double[] getflour()
        {
            double[] flour = new double[4] { 0, 1, 2, 3 };
            return flour;
        }
        public static double[] getfetacheese()
        {
            double[] fetacheese = new double[5] { 0, 1, 2, 3, 4 };
            return fetacheese;
        }
        public static double[] getonions()
        {
            double[] onions = new double[4] { 0, 1, 2, 3 };
            return onions;
        }
        public static double[] getblackbeans()
        {
            double[] blackbeans = new double[6] { 0, .5, 1, 2, 3, 4 };
            return blackbeans;
        }
        public static double[] getbreadcrumbs()
        {
            double[] breadcrumbs = new double[3] { 0, .5, 1 };
            return breadcrumbs;
        }
        public static double[] getblackpepper()
        {
            double[] blackpepper = new double[5] { 0, .25, .5, .75, 1 };
            return blackpepper;
        }
        public static double[] getbutter()
        {
            double[] butter = new double[5] { 0, .25, .5, .75, 1 };
            return butter;
        }
        public static double[] getsugar()
        {
            double[] sugar = new double[5] { 0, .25, .5, .75, 1 };
            return sugar;
        }
        public static double[] getmilk()
        {
            double[] milk = new double[6] { 0, .25, .5, .75, 1, 2 };
            return milk;
        }
        public static string quinoachecker(Dictionary<string, double> test) //so each fooditem followed by checker is where i take the created dictionary (called check in ingrediants menu) and see if the=y have the required ingrediants for this recipe. Was V important to copy and paste "key's" because mistyping them once sucked. 
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("oliveoil", 2); //list of common ingrediants amongst recipes and how much this requires. 
            list.Add("tomatoes", 1);
            list.Add("blackbeans", .5);
            list.Add("cilantro", 2);
            list.Add("eggs", 2);
            list.Add("avocado", 1);
            if (list["oliveoil"] <= test["oliveoil"] && list["tomatoes"] <= test["tomatoes"] && list["blackbeans"] <= test["blackbeans"] && list["cilantro"] <= test["cilantro"] && list["eggs"] <= test["eggs"] && list["avocado"] <= test["avocado"])
            {
                return "Quinoa"; //this returns the string so i can know if the user had enough ingrediants(:
            }
            else
            {
                return "Not enough ingredients";
            }

        }
        public static string charredpastachecker(Dictionary<string, double> test)
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("oliveoil", 3);
            list.Add("pasta", 8);
            list.Add("garlic", 2);
            list.Add("flour", 1.5);
            list.Add("milk", .5);
            list.Add("fetacheese", 3);
            list.Add("blackpepper", .25);
            if (list["oliveoil"] <= test["oliveoil"] && list["pasta"] <= test["pasta"] && list["garlic"] <= test["garlic"] && list["flour"] <= test["flour"] && list["milk"] <= test["milk"] && list["fetacheese"] <= test["fetacheese"] && list["blackpepper"] <= test["blackpepper"])
            {
                return "Lemon Feta Pasta";
            }
            else
            {
                return "Not enough ingredients";
            }

        }
        public static string BlackBeanBurger(Dictionary<string, double> test) //I guess I got too lazy to type checker after each one 
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("oliveoil", 1); //what is 1 olive oil? It's listed in the ingrediants menu, I had a notepad pulled up
            list.Add("blackbeans", 4);
            list.Add("garlic", 3);
            list.Add("onions", 1);
            list.Add("eggs", 2);
            list.Add("fetacheese", 4);
            list.Add("breadcrumbs", .5);
            if (list["oliveoil"] <= test["oliveoil"] && list["blackbeans"] <= test["blackbeans"] && list["garlic"] <= test["garlic"] && list["onions"] <= test["onions"] && list["eggs"] <= test["eggs"] && list["fetacheese"] <= test["fetacheese"] && list["breadcrumbs"] <= test["breadcrumbs"])
            {
                return "Black Bean Burgers";
            }
            else
            {
                return "Not enough ingredients";
            }

        }
        public static string avocadocharredtomatobowl(Dictionary<string, double> test)
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("oliveoil", 1);
            list.Add("blackbeans", .5);
            list.Add("tomatoes", .5);
            list.Add("avocado", .5);
            list.Add("cilantro", 2);
            list.Add("blackpepper", .2);
            if (list["oliveoil"] <= test["oliveoil"] && list["blackbeans"] <= test["blackbeans"] && list["tomatoes"] <= test["tomatoes"] && list["avocado"] <= test["avocado"] && list["cilantro"] <= test["cilantro"] && list["blackpepper"] <= test["blackpepper"])
            {
                return "Avocado Charred Tomato Bowl";
            }
            else
            {
                return "Not enough ingredients";
            }

        }
        public static string pennepasta(Dictionary<string, double> test)
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("oliveoil", 2);
            list.Add("garlic", 2);
            list.Add("pasta", 8);
            list.Add("blackpepper", .25);
            if (list["oliveoil"] <= test["oliveoil"] && list["garlic"] <= test["garlic"] && list["pasta"] <= test["pasta"] && list["blackpepper"] <= test["blackpepper"])
            {
                return "Penne Pasta";
            }
            else
            {
                return "Not enough ingredients";
            }

        }
        public static string bananabread(Dictionary<string, double> test)
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("butter", .3);
            list.Add("sugar", .75);
            list.Add("eggs", 1);
            list.Add("flour", 1.5);
            if (list["butter"] <= test["butter"] && list["sugar"] <= test["sugar"] && list["eggs"] <= test["eggs"] && list["flour"] <= test["flour"])
            {
                return "Banana Bread";
            }
            else
            {
                return "Not enough ingredients";
            }

        }
        public static string chocolatechipcookies(Dictionary<string, double> test)
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("butter", 1);
            list.Add("sugar", 1);
            list.Add("eggs", 2);
            list.Add("flour", 3);
            if (list["butter"] <= test["butter"] && list["sugar"] <= test["sugar"] && list["eggs"] <= test["eggs"] && list["flour"] <= test["flour"])
            {
                return "Chocolate Chip Cookies";
            }
            else
            {
                return "Not enough ingredients";
            }

        }
        public static string friedapples(Dictionary<string, double> test)
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("butter", .5);
            list.Add("sugar", .75);
            if (list["butter"] <= test["butter"] && list["sugar"] <= test["sugar"])
            {
                return "Fried Apples";
            }
            else
            {
                return "Not enough ingredients";
            }

        }
        public static string meatloaf(Dictionary<string, double> test)
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("eggs", 1);
            list.Add("onions", 2);
            list.Add("milk", 2);
            list.Add("breadcrumbs", 1);
            list.Add("sugar", .2);
            if (list["eggs"] <= test["eggs"] && list["onions"] <= test["onions"] && list["milk"] <= test["milk"] && list["breadcrumbs"] <= test["breadcrumbs"] && list["sugar"] <= test["sugar"])
            {
                return "Meatloaf";
            }
            else
            {
                return "Not enough ingredients";
            }

        }
        public static string spaghetti(Dictionary<string, double> test)
        {
            Dictionary<string, double> list = new Dictionary<string, double>();
            list.Add("pasta", 16);
            list.Add("breadcrumbs", 1);
            list.Add("blackpepper", .5);
            list.Add("eggs", 1);
            list.Add("onions", .75);
            list.Add("garlic", 5);
            list.Add("sugar", .1);
            if (list["pasta"] <= test["pasta"] && list["breadcrumbs"] <= test["breadcrumbs"] && list["blackpepper"] <= test["blackpepper"] && list["eggs"] <= test["eggs"] && list["onions"] <= test["onions"] && list["garlic"] <= test["garlic"] && list["sugar"] <= test["sugar"])
            {
                return "Spaghetti";
            }
            else
            {
                return "Not enough ingredients";
            }

        }


    }
}
