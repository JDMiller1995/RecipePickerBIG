
namespace RecipePicker
{
    partial class MeatMenu
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
            this.MEATsteak = new System.Windows.Forms.Button();
            this.MEATSpaghetti = new System.Windows.Forms.Button();
            this.MEATmeatloaf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MEATsteak
            // 
            this.MEATsteak.BackColor = System.Drawing.Color.Transparent;
            this.MEATsteak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MEATsteak.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEATsteak.ForeColor = System.Drawing.Color.White;
            this.MEATsteak.Location = new System.Drawing.Point(79, 226);
            this.MEATsteak.Name = "MEATsteak";
            this.MEATsteak.Size = new System.Drawing.Size(138, 46);
            this.MEATsteak.TabIndex = 13;
            this.MEATsteak.Text = "Steak and Veggies";
            this.MEATsteak.UseVisualStyleBackColor = false;
            this.MEATsteak.Click += new System.EventHandler(this.MEATsteak_Click);
            // 
            // MEATSpaghetti
            // 
            this.MEATSpaghetti.BackColor = System.Drawing.Color.Transparent;
            this.MEATSpaghetti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MEATSpaghetti.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEATSpaghetti.ForeColor = System.Drawing.Color.White;
            this.MEATSpaghetti.Location = new System.Drawing.Point(376, 226);
            this.MEATSpaghetti.Name = "MEATSpaghetti";
            this.MEATSpaghetti.Size = new System.Drawing.Size(138, 46);
            this.MEATSpaghetti.TabIndex = 12;
            this.MEATSpaghetti.Text = "Spaghetti and Meatballs";
            this.MEATSpaghetti.UseVisualStyleBackColor = false;
            this.MEATSpaghetti.Click += new System.EventHandler(this.MEATSpaghetti_Click);
            // 
            // MEATmeatloaf
            // 
            this.MEATmeatloaf.BackColor = System.Drawing.Color.Transparent;
            this.MEATmeatloaf.FlatAppearance.BorderSize = 0;
            this.MEATmeatloaf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MEATmeatloaf.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEATmeatloaf.ForeColor = System.Drawing.Color.White;
            this.MEATmeatloaf.Location = new System.Drawing.Point(671, 226);
            this.MEATmeatloaf.Name = "MEATmeatloaf";
            this.MEATmeatloaf.Size = new System.Drawing.Size(138, 46);
            this.MEATmeatloaf.TabIndex = 11;
            this.MEATmeatloaf.Text = "Meatloaf";
            this.MEATmeatloaf.UseVisualStyleBackColor = false;
            this.MEATmeatloaf.Click += new System.EventHandler(this.MEATmeatloaf_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(351, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 56);
            this.label2.TabIndex = 10;
            this.label2.Text = "MEAT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecipePicker.Properties.Resources.MEATLOAF;
            this.pictureBox1.Location = new System.Drawing.Point(590, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 181);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RecipePicker.Properties.Resources.spaghetti2;
            this.pictureBox2.Location = new System.Drawing.Point(316, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 181);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RecipePicker.Properties.Resources.steakplz;
            this.pictureBox3.Location = new System.Drawing.Point(54, 291);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 143);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // MeatMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RecipePicker.Properties.Resources.menu;
            this.ClientSize = new System.Drawing.Size(926, 561);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MEATsteak);
            this.Controls.Add(this.MEATSpaghetti);
            this.Controls.Add(this.MEATmeatloaf);
            this.Controls.Add(this.label2);
            this.Name = "MeatMenu";
            this.Text = "MeatMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MEATsteak;
        private System.Windows.Forms.Button MEATSpaghetti;
        private System.Windows.Forms.Button MEATmeatloaf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}