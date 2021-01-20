
namespace Ksiegarnia
{
    partial class formPrzegladanieOferty
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
            this.menuPrzegladanieOferty = new System.Windows.Forms.MenuStrip();
            this.stronaGlownaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladanieOfertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koszykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbDodajKsiazkeTytul = new System.Windows.Forms.RichTextBox();
            this.rtbDodajKsiazkeAutor = new System.Windows.Forms.RichTextBox();
            this.rtbDodajKsiazkeCena = new System.Windows.Forms.RichTextBox();
            this.buttonDodajKsiazke = new System.Windows.Forms.Button();
            this.labelDodajKsiazkeTytul = new System.Windows.Forms.Label();
            this.labelDodajKsiazkeAutor = new System.Windows.Forms.Label();
            this.labelDodajKsiazkeCena = new System.Windows.Forms.Label();
            this.menuPrzegladanieOferty.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrzegladanieOferty
            // 
            this.menuPrzegladanieOferty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stronaGlownaToolStripMenuItem,
            this.przegladanieOfertyToolStripMenuItem,
            this.koszykToolStripMenuItem});
            this.menuPrzegladanieOferty.Location = new System.Drawing.Point(0, 0);
            this.menuPrzegladanieOferty.Name = "menuPrzegladanieOferty";
            this.menuPrzegladanieOferty.Size = new System.Drawing.Size(941, 24);
            this.menuPrzegladanieOferty.TabIndex = 0;
            this.menuPrzegladanieOferty.Text = "menuStrip1";
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
            // rtbDodajKsiazkeTytul
            // 
            this.rtbDodajKsiazkeTytul.Location = new System.Drawing.Point(242, 52);
            this.rtbDodajKsiazkeTytul.Name = "rtbDodajKsiazkeTytul";
            this.rtbDodajKsiazkeTytul.Size = new System.Drawing.Size(201, 27);
            this.rtbDodajKsiazkeTytul.TabIndex = 3;
            this.rtbDodajKsiazkeTytul.Text = "";
            // 
            // rtbDodajKsiazkeAutor
            // 
            this.rtbDodajKsiazkeAutor.Location = new System.Drawing.Point(469, 52);
            this.rtbDodajKsiazkeAutor.Name = "rtbDodajKsiazkeAutor";
            this.rtbDodajKsiazkeAutor.Size = new System.Drawing.Size(145, 27);
            this.rtbDodajKsiazkeAutor.TabIndex = 3;
            this.rtbDodajKsiazkeAutor.Text = "";
            // 
            // rtbDodajKsiazkeCena
            // 
            this.rtbDodajKsiazkeCena.Location = new System.Drawing.Point(650, 52);
            this.rtbDodajKsiazkeCena.Name = "rtbDodajKsiazkeCena";
            this.rtbDodajKsiazkeCena.Size = new System.Drawing.Size(96, 27);
            this.rtbDodajKsiazkeCena.TabIndex = 3;
            this.rtbDodajKsiazkeCena.Text = "";
            // 
            // buttonDodajKsiazke
            // 
            this.buttonDodajKsiazke.Location = new System.Drawing.Point(54, 52);
            this.buttonDodajKsiazke.Name = "buttonDodajKsiazke";
            this.buttonDodajKsiazke.Size = new System.Drawing.Size(141, 27);
            this.buttonDodajKsiazke.TabIndex = 4;
            this.buttonDodajKsiazke.Text = "Dodaj ksiazke";
            this.buttonDodajKsiazke.UseVisualStyleBackColor = true;
            this.buttonDodajKsiazke.Click += new System.EventHandler(this.buttonDodajKsiazke_Click);
            // 
            // labelDodajKsiazkeTytul
            // 
            this.labelDodajKsiazkeTytul.AutoSize = true;
            this.labelDodajKsiazkeTytul.Location = new System.Drawing.Point(327, 31);
            this.labelDodajKsiazkeTytul.Name = "labelDodajKsiazkeTytul";
            this.labelDodajKsiazkeTytul.Size = new System.Drawing.Size(30, 13);
            this.labelDodajKsiazkeTytul.TabIndex = 5;
            this.labelDodajKsiazkeTytul.Text = "Tytul";
            // 
            // labelDodajKsiazkeAutor
            // 
            this.labelDodajKsiazkeAutor.AutoSize = true;
            this.labelDodajKsiazkeAutor.Location = new System.Drawing.Point(517, 31);
            this.labelDodajKsiazkeAutor.Name = "labelDodajKsiazkeAutor";
            this.labelDodajKsiazkeAutor.Size = new System.Drawing.Size(32, 13);
            this.labelDodajKsiazkeAutor.TabIndex = 5;
            this.labelDodajKsiazkeAutor.Text = "Autor";
            // 
            // labelDodajKsiazkeCena
            // 
            this.labelDodajKsiazkeCena.AutoSize = true;
            this.labelDodajKsiazkeCena.Location = new System.Drawing.Point(684, 31);
            this.labelDodajKsiazkeCena.Name = "labelDodajKsiazkeCena";
            this.labelDodajKsiazkeCena.Size = new System.Drawing.Size(32, 13);
            this.labelDodajKsiazkeCena.TabIndex = 5;
            this.labelDodajKsiazkeCena.Text = "Cena";
            // 
            // formPrzegladanieOferty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 693);
            this.Controls.Add(this.labelDodajKsiazkeCena);
            this.Controls.Add(this.labelDodajKsiazkeAutor);
            this.Controls.Add(this.labelDodajKsiazkeTytul);
            this.Controls.Add(this.buttonDodajKsiazke);
            this.Controls.Add(this.rtbDodajKsiazkeCena);
            this.Controls.Add(this.rtbDodajKsiazkeAutor);
            this.Controls.Add(this.rtbDodajKsiazkeTytul);
            this.Controls.Add(this.menuPrzegladanieOferty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuPrzegladanieOferty;
            this.Name = "formPrzegladanieOferty";
            this.Text = "Ksiegarnia";
            this.menuPrzegladanieOferty.ResumeLayout(false);
            this.menuPrzegladanieOferty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrzegladanieOferty;
        private System.Windows.Forms.ToolStripMenuItem stronaGlownaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladanieOfertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koszykToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbDodajKsiazkeTytul;
        private System.Windows.Forms.RichTextBox rtbDodajKsiazkeAutor;
        private System.Windows.Forms.RichTextBox rtbDodajKsiazkeCena;
        private System.Windows.Forms.Button buttonDodajKsiazke;
        private System.Windows.Forms.Label labelDodajKsiazkeTytul;
        private System.Windows.Forms.Label labelDodajKsiazkeAutor;
        private System.Windows.Forms.Label labelDodajKsiazkeCena;
    }
}