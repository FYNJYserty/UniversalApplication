namespace Tic_Tac_Toe
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonC = new Design.ButtonDesign();
            this.buttonGame = new Design.ButtonDesign();
            this.buttonCalculator = new Design.ButtonDesign();
            this.SuspendLayout();
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(146)))), ((int)(((byte)(210)))));
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.buttonC, "buttonC");
            this.buttonC.Name = "buttonC";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonСС);
            // 
            // buttonGame
            // 
            this.buttonGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(146)))), ((int)(((byte)(210)))));
            this.buttonGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGame.FlatAppearance.BorderSize = 0;
            this.buttonGame.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.buttonGame, "buttonGame");
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.UseVisualStyleBackColor = false;
            this.buttonGame.Click += new System.EventHandler(this.buttonPlay);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(146)))), ((int)(((byte)(210)))));
            this.buttonCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculator.FlatAppearance.BorderSize = 0;
            this.buttonCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.buttonCalculator, "buttonCalculator");
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.UseVisualStyleBackColor = false;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalc);
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonGame);
            this.Controls.Add(this.buttonCalculator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Design.ButtonDesign buttonCalculator;
        private Design.ButtonDesign buttonGame;
        private Design.ButtonDesign buttonC;
    }
}