
namespace Ksiegarnia
{
    partial class formPanelUzytkownika
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
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelNumerTelefonu = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.bWyloguj = new System.Windows.Forms.Button();
            this.bBazaZamowien = new System.Windows.Forms.Button();
            this.menuPanelUzytkownika = new System.Windows.Forms.MenuStrip();
            this.stronaGlownaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladanieOfertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koszykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTimerPaneluzytkownika = new System.Windows.Forms.Timer(this.components);
            this.menuPanelUzytkownika.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(45, 66);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(35, 13);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "admin";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(45, 112);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(35, 13);
            this.labelNazwisko.TabIndex = 0;
            this.labelNazwisko.Text = "admin";
            // 
            // labelNumerTelefonu
            // 
            this.labelNumerTelefonu.AutoSize = true;
            this.labelNumerTelefonu.Location = new System.Drawing.Point(45, 154);
            this.labelNumerTelefonu.Name = "labelNumerTelefonu";
            this.labelNumerTelefonu.Size = new System.Drawing.Size(35, 13);
            this.labelNumerTelefonu.TabIndex = 0;
            this.labelNumerTelefonu.Text = "admin";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(45, 198);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "admin";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(45, 240);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(35, 13);
            this.labelAdres.TabIndex = 0;
            this.labelAdres.Text = "admin";
            // 
            // bWyloguj
            // 
            this.bWyloguj.Location = new System.Drawing.Point(126, 534);
            this.bWyloguj.Name = "bWyloguj";
            this.bWyloguj.Size = new System.Drawing.Size(195, 61);
            this.bWyloguj.TabIndex = 1;
            this.bWyloguj.Text = "Wyloguj sie!";
            this.bWyloguj.UseVisualStyleBackColor = true;
            this.bWyloguj.Click += new System.EventHandler(this.bWyloguj_Click);
            // 
            // bBazaZamowien
            // 
            this.bBazaZamowien.Location = new System.Drawing.Point(126, 452);
            this.bBazaZamowien.Name = "bBazaZamowien";
            this.bBazaZamowien.Size = new System.Drawing.Size(195, 61);
            this.bBazaZamowien.TabIndex = 1;
            this.bBazaZamowien.Text = "Baza zamowien";
            this.bBazaZamowien.UseVisualStyleBackColor = true;
            this.bBazaZamowien.Click += new System.EventHandler(this.bBazaZamowien_Click);
            // 
            // menuPanelUzytkownika
            // 
            this.menuPanelUzytkownika.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stronaGlownaToolStripMenuItem,
            this.przegladanieOfertyToolStripMenuItem,
            this.koszykToolStripMenuItem});
            this.menuPanelUzytkownika.Location = new System.Drawing.Point(0, 0);
            this.menuPanelUzytkownika.Name = "menuPanelUzytkownika";
            this.menuPanelUzytkownika.Size = new System.Drawing.Size(447, 24);
            this.menuPanelUzytkownika.TabIndex = 2;
            this.menuPanelUzytkownika.Text = "menuStrip1";
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
            this.przegladanieOfertyToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.przegladanieOfertyToolStripMenuItem.Text = "Przegladanie oferty";
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
            // helpTimerPaneluzytkownika
            // 
            this.helpTimerPaneluzytkownika.Enabled = true;
            this.helpTimerPaneluzytkownika.Interval = 1000;
            this.helpTimerPaneluzytkownika.Tick += new System.EventHandler(this.helpTimerPaneluzytkownika_Tick);
            // 
            // formPanelUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 623);
            this.Controls.Add(this.bBazaZamowien);
            this.Controls.Add(this.bWyloguj);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelNumerTelefonu);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.menuPanelUzytkownika);
            this.MainMenuStrip = this.menuPanelUzytkownika;
            this.Name = "formPanelUzytkownika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ksiegarnia";
            this.Load += new System.EventHandler(this.formPanelUzytkownika_Load);
            this.menuPanelUzytkownika.ResumeLayout(false);
            this.menuPanelUzytkownika.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelNumerTelefonu;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Button bWyloguj;
        private System.Windows.Forms.Button bBazaZamowien;
        private System.Windows.Forms.MenuStrip menuPanelUzytkownika;
        private System.Windows.Forms.ToolStripMenuItem stronaGlownaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladanieOfertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koszykToolStripMenuItem;
        private System.Windows.Forms.Timer helpTimerPaneluzytkownika;
    }
}