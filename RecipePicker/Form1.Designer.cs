
namespace RecipePicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewUserRecipes = new System.Windows.Forms.Button();
            this.addRecipe = new System.Windows.Forms.Button();
            this.viewIngrediants = new System.Windows.Forms.Button();
            this.viewDessert = new System.Windows.Forms.Button();
            this.viewVegan = new System.Windows.Forms.Button();
            this.viewVeggie = new System.Windows.Forms.Button();
            this.viewMeat = new System.Windows.Forms.Button();
            this.viewAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RecipeBox = new System.Windows.Forms.TextBox();
            this.SaveRecipe = new System.Windows.Forms.Button();
            this.RecipeName = new System.Windows.Forms.TextBox();
            this.finalizebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewUserRecipes
            // 
            this.viewUserRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUserRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUserRecipes.Location = new System.Drawing.Point(14, 359);
            this.viewUserRecipes.Name = "viewUserRecipes";
            this.viewUserRecipes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewUserRecipes.Size = new System.Drawing.Size(182, 30);
            this.viewUserRecipes.TabIndex = 17;
            this.viewUserRecipes.Text = "View User Recipes";
            this.viewUserRecipes.UseVisualStyleBackColor = true;
            this.viewUserRecipes.Click += new System.EventHandler(this.viewUserRecipes_Click);
            // 
            // addRecipe
            // 
            this.addRecipe.BackColor = System.Drawing.Color.Aqua;
            this.addRecipe.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.addRecipe.FlatAppearance.BorderSize = 5;
            this.addRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecipe.Location = new System.Drawing.Point(443, 359);
            this.addRecipe.Name = "addRecipe";
            this.addRecipe.Size = new System.Drawing.Size(151, 30);
            this.addRecipe.TabIndex = 16;
            this.addRecipe.Text = "Add Recipe";
            this.addRecipe.UseVisualStyleBackColor = false;
            this.addRecipe.Click += new System.EventHandler(this.addRecipe_Click);
            // 
            // viewIngrediants
            // 
            this.viewIngrediants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewIngrediants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewIngrediants.Location = new System.Drawing.Point(14, 311);
            this.viewIngrediants.Name = "viewIngrediants";
            this.viewIngrediants.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewIngrediants.Size = new System.Drawing.Size(182, 30);
            this.viewIngrediants.TabIndex = 15;
            this.viewIngrediants.Text = "View By Ingredients";
            this.viewIngrediants.UseVisualStyleBackColor = true;
            this.viewIngrediants.Click += new System.EventHandler(this.viewIngrediants_Click);
            // 
            // viewDessert
            // 
            this.viewDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDessert.Location = new System.Drawing.Point(14, 262);
            this.viewDessert.Name = "viewDessert";
            this.viewDessert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewDessert.Size = new System.Drawing.Size(151, 30);
            this.viewDessert.TabIndex = 14;
            this.viewDessert.Text = "View Dessert";
            this.viewDessert.UseVisualStyleBackColor = true;
            this.viewDessert.Click += new System.EventHandler(this.viewDessert_Click);
            // 
            // viewVegan
            // 
            this.viewVegan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewVegan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewVegan.Location = new System.Drawing.Point(14, 211);
            this.viewVegan.Name = "viewVegan";
            this.viewVegan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewVegan.Size = new System.Drawing.Size(151, 30);
            this.viewVegan.TabIndex = 13;
            this.viewVegan.Text = "View Vegan";
            this.viewVegan.UseVisualStyleBackColor = true;
            this.viewVegan.Click += new System.EventHandler(this.viewVegan_Click);
            // 
            // viewVeggie
            // 
            this.viewVeggie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewVeggie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewVeggie.Location = new System.Drawing.Point(14, 164);
            this.viewVeggie.Name = "viewVeggie";
            this.viewVeggie.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewVeggie.Size = new System.Drawing.Size(151, 30);
            this.viewVeggie.TabIndex = 12;
            this.viewVeggie.Text = "View Vegetarian";
            this.viewVeggie.UseVisualStyleBackColor = true;
            this.viewVeggie.Click += new System.EventHandler(this.viewVeggie_Click);
            // 
            // viewMeat
            // 
            this.viewMeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMeat.Location = new System.Drawing.Point(14, 117);
            this.viewMeat.Name = "viewMeat";
            this.viewMeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewMeat.Size = new System.Drawing.Size(151, 30);
            this.viewMeat.TabIndex = 11;
            this.viewMeat.Text = "View Meat";
            this.viewMeat.UseVisualStyleBackColor = true;
            this.viewMeat.Click += new System.EventHandler(this.viewMeat_Click);
            // 
            // viewAll
            // 
            this.viewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAll.Location = new System.Drawing.Point(14, 72);
            this.viewAll.Name = "viewAll";
            this.viewAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewAll.Size = new System.Drawing.Size(151, 30);
            this.viewAll.TabIndex = 10;
            this.viewAll.Text = "View All";
            this.viewAll.UseVisualStyleBackColor = true;
            this.viewAll.Click += new System.EventHandler(this.viewAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quick Recipe Picker";
            this.label1.UseMnemonic = false;
            // 
            // RecipeBox
            // 
            this.RecipeBox.AcceptsReturn = true;
            this.RecipeBox.AcceptsTab = true;
            this.RecipeBox.Location = new System.Drawing.Point(-2, 2);
            this.RecipeBox.Multiline = true;
            this.RecipeBox.Name = "RecipeBox";
            this.RecipeBox.Size = new System.Drawing.Size(439, 382);
            this.RecipeBox.TabIndex = 18;
            this.RecipeBox.TabStop = false;
            this.RecipeBox.Visible = false;
            // 
            // SaveRecipe
            // 
            this.SaveRecipe.BackColor = System.Drawing.Color.Aqua;
            this.SaveRecipe.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.SaveRecipe.FlatAppearance.BorderSize = 5;
            this.SaveRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRecipe.Location = new System.Drawing.Point(445, 8);
            this.SaveRecipe.Name = "SaveRecipe";
            this.SaveRecipe.Size = new System.Drawing.Size(151, 30);
            this.SaveRecipe.TabIndex = 19;
            this.SaveRecipe.Text = "Save Recipe";
            this.SaveRecipe.UseVisualStyleBackColor = false;
            this.SaveRecipe.Visible = false;
            this.SaveRecipe.Click += new System.EventHandler(this.SaveRecipe_Click);
            // 
            // RecipeName
            // 
            this.RecipeName.Location = new System.Drawing.Point(472, 124);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(101, 20);
            this.RecipeName.TabIndex = 20;
            this.RecipeName.TabStop = false;
            this.RecipeName.Visible = false;
            // 
            // finalizebutton
            // 
            this.finalizebutton.BackColor = System.Drawing.Color.Aqua;
            this.finalizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.finalizebutton.FlatAppearance.BorderSize = 5;
            this.finalizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finalizebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizebutton.Location = new System.Drawing.Point(443, 44);
            this.finalizebutton.Name = "finalizebutton";
            this.finalizebutton.Size = new System.Drawing.Size(151, 30);
            this.finalizebutton.TabIndex = 21;
            this.finalizebutton.Text = "Finalize Recipe";
            this.finalizebutton.UseVisualStyleBackColor = false;
            this.finalizebutton.Visible = false;
            this.finalizebutton.Click += new System.EventHandler(this.finalizebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RecipePicker.Properties.Resources.backgroiund;
            this.ClientSize = new System.Drawing.Size(603, 396);
            this.Controls.Add(this.finalizebutton);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.SaveRecipe);
            this.Controls.Add(this.RecipeBox);
            this.Controls.Add(this.viewUserRecipes);
            this.Controls.Add(this.addRecipe);
            this.Controls.Add(this.viewIngrediants);
            this.Controls.Add(this.viewDessert);
            this.Controls.Add(this.viewVegan);
            this.Controls.Add(this.viewVeggie);
            this.Controls.Add(this.viewMeat);
            this.Controls.Add(this.viewAll);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewUserRecipes;
        private System.Windows.Forms.Button addRecipe;
        private System.Windows.Forms.Button viewIngrediants;
        private System.Windows.Forms.Button viewDessert;
        private System.Windows.Forms.Button viewVegan;
        private System.Windows.Forms.Button viewVeggie;
        private System.Windows.Forms.Button viewMeat;
        private System.Windows.Forms.Button viewAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RecipeBox;
        private System.Windows.Forms.Button SaveRecipe;
        private System.Windows.Forms.TextBox RecipeName;
        private System.Windows.Forms.Button finalizebutton;
    }
}

