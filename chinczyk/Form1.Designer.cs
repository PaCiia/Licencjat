﻿namespace chinczyk
{
    partial class chinczyk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chinczyk));
            this.plansza = new System.Windows.Forms.Panel();
            this.kostka = new System.Windows.Forms.Panel();
            this.rzut = new System.Windows.Forms.Button();
            this.plansza.SuspendLayout();
            this.SuspendLayout();
            // 
            // plansza
            // 
            this.plansza.BackgroundImage = global::chinczyk.Properties.Resources.plansza_rowna;
            resources.ApplyResources(this.plansza, "plansza");
            this.plansza.Controls.Add(this.kostka);
            this.plansza.Controls.Add(this.rzut);
            this.plansza.Name = "plansza";
            this.plansza.Paint += new System.Windows.Forms.PaintEventHandler(this.plansza_Paint);
            // 
            // kostka
            // 
            this.kostka.BackColor = System.Drawing.Color.White;
            this.kostka.BackgroundImage = global::chinczyk.Properties.Resources.Dice_0_svg;
            resources.ApplyResources(this.kostka, "kostka");
            this.kostka.Name = "kostka";
            this.kostka.Paint += new System.Windows.Forms.PaintEventHandler(this.kostka_Paint);
            // 
            // rzut
            // 
            this.rzut.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.rzut, "rzut");
            this.rzut.Name = "rzut";
            this.rzut.UseVisualStyleBackColor = false;
            this.rzut.Click += new System.EventHandler(this.rzut_Click);
            // 
            // chinczyk
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plansza);
            this.DoubleBuffered = true;
            this.Name = "chinczyk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.plansza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plansza;
        private System.Windows.Forms.Button rzut;
        private System.Windows.Forms.Panel kostka;
    }
}

