
namespace Ksiegarnia
{
    partial class formBazaZamowien
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
            this.components = new System.ComponentModel.Container();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.menuBazaZamowien = new System.Windows.Forms.MenuStrip();
            this.stronaGlownaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladanieOfertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koszykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTimerBazaZamowien = new System.Windows.Forms.Timer(this.components);
            this.menuBazaZamowien.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1034, 301);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(76, 20);
            this.textBox11.TabIndex = 1;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1034, 469);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(76, 20);
            this.textBox12.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1061, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Dane";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1054, 359);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Ksiazki";
            // 
            // menuBazaZamowien
            // 
            this.menuBazaZamowien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stronaGlownaToolStripMenuItem,
            this.przegladanieOfertyToolStripMenuItem,
            this.koszykToolStripMenuItem});
            this.menuBazaZamowien.Location = new System.Drawing.Point(0, 0);
            this.menuBazaZamowien.Name = "menuBazaZamowien";
            this.menuBazaZamowien.Size = new System.Drawing.Size(891, 24);
            this.menuBazaZamowien.TabIndex = 9;
            this.menuBazaZamowien.Text = "menuStrip1";
            // 
            // stronaGlownaToolStripMenuItem
            // 
            this.stronaGlownaToolStripMenuItem.Name = "stronaGlownaToolStripMenuItem";
            this.stronaGlownaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.stronaGlownaToolStripMenuItem.Text = "Strona Glowna";
            this.stronaGlownaToolStripMenuItem.Click += new System.EventHandler(this.stronaGlownaToolStripMenuItem_Click);
            // 
            // przegladanieOfertyToolStripMenuItem
            // 
            this.przegladanieOfertyToolStripMenuItem.Name = "przegladanieOfertyToolStripMenuItem";
            this.przegladanieOfertyToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.przegladanieOfertyToolStripMenuItem.Text = "Przegladanie Oferty";
            this.przegladanieOfertyToolStripMenuItem.Click += new System.EventHandler(this.przegladanieOfertyToolStripMenuItem_Click);
            // 
            // koszykToolStripMenuItem
            // 
            this.koszykToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.koszykToolStripMenuItem.Name = "koszykToolStripMenuItem";
            this.koszykToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.koszykToolStripMenuItem.Text = "Koszyk";
            this.koszykToolStripMenuItem.Click += new System.EventHandler(this.koszykToolStripMenuItem_Click);
            // 
            // helpTimerBazaZamowien
            // 
            this.helpTimerBazaZamowien.Enabled = true;
            this.helpTimerBazaZamowien.Tick += new System.EventHandler(this.helpTimerBazaZamowien_Tick);
            // 
            // formBazaZamowien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 633);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.menuBazaZamowien);
            this.MainMenuStrip = this.menuBazaZamowien;
            this.Name = "formBazaZamowien";
            this.Text = "formBazaZamowien";
            this.Load += new System.EventHandler(this.formBazaZamowien_Load);
            this.menuBazaZamowien.ResumeLayout(false);
            this.menuBazaZamowien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MenuStrip menuBazaZamowien;
        private System.Windows.Forms.ToolStripMenuItem stronaGlownaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladanieOfertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koszykToolStripMenuItem;
        private System.Windows.Forms.Timer helpTimerBazaZamowien;
    }
}