
namespace Ksiegarnia
{
    partial class formLogowanie
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
            this.menuLogowanie = new System.Windows.Forms.MenuStrip();
            this.stronaGlownaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladanieOfertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koszykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bZalogujSie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bZarejestrujSie = new System.Windows.Forms.Button();
            this.menuLogowanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLogowanie
            // 
            this.menuLogowanie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stronaGlownaToolStripMenuItem,
            this.przegladanieOfertyToolStripMenuItem,
            this.koszykToolStripMenuItem});
            this.menuLogowanie.Location = new System.Drawing.Point(0, 0);
            this.menuLogowanie.Name = "menuLogowanie";
            this.menuLogowanie.Size = new System.Drawing.Size(555, 24);
            this.menuLogowanie.TabIndex = 0;
            this.menuLogowanie.Text = "menuStrip1";
            // 
            // stronaGlownaToolStripMenuItem
            // 
            this.stronaGlownaToolStripMenuItem.Name = "stronaGlownaToolStripMenuItem";
            this.stronaGlownaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.stronaGlownaToolStripMenuItem.Text = "Strona Glowna";
            // 
            // przegladanieOfertyToolStripMenuItem
            // 
            this.przegladanieOfertyToolStripMenuItem.Name = "przegladanieOfertyToolStripMenuItem";
            this.przegladanieOfertyToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.przegladanieOfertyToolStripMenuItem.Text = "Przegladanie oferty";
            // 
            // koszykToolStripMenuItem
            // 
            this.koszykToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.koszykToolStripMenuItem.Name = "koszykToolStripMenuItem";
            this.koszykToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.koszykToolStripMenuItem.Text = "Koszyk";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(112, 105);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(185, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(112, 197);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(185, 20);
            this.tbHaslo.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(179, 65);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(65, 24);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Haslo:";
            // 
            // bZalogujSie
            // 
            this.bZalogujSie.Location = new System.Drawing.Point(112, 260);
            this.bZalogujSie.Name = "bZalogujSie";
            this.bZalogujSie.Size = new System.Drawing.Size(185, 35);
            this.bZalogujSie.TabIndex = 3;
            this.bZalogujSie.Text = "Zaloguj Sie";
            this.bZalogujSie.UseVisualStyleBackColor = true;
            this.bZalogujSie.Click += new System.EventHandler(this.bZalogujSie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nie posiadasz konta? \r\n     Zarejestruj sie!";
            // 
            // bZarejestrujSie
            // 
            this.bZarejestrujSie.Location = new System.Drawing.Point(383, 206);
            this.bZarejestrujSie.Name = "bZarejestrujSie";
            this.bZarejestrujSie.Size = new System.Drawing.Size(126, 36);
            this.bZarejestrujSie.TabIndex = 5;
            this.bZarejestrujSie.Text = "Zarejestruj sie";
            this.bZarejestrujSie.UseVisualStyleBackColor = true;
            // 
            // formLogowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 347);
            this.Controls.Add(this.bZarejestrujSie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bZalogujSie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.menuLogowanie);
            this.MainMenuStrip = this.menuLogowanie;
            this.Name = "formLogowanie";
            this.Text = "Ksiegarnia";
            this.menuLogowanie.ResumeLayout(false);
            this.menuLogowanie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuLogowanie;
        private System.Windows.Forms.ToolStripMenuItem stronaGlownaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladanieOfertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koszykToolStripMenuItem;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bZalogujSie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bZarejestrujSie;
    }
}