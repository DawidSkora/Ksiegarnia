
namespace Ksiegarnia
{
    partial class formStronaGlowna
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStronaGlowna = new System.Windows.Forms.MenuStrip();
            this.stronaGlownaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladanieOfertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koszykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPowitanie = new System.Windows.Forms.Label();
            this.timerStronaGlowna = new System.Windows.Forms.Timer(this.components);
            this.labelCzyZalogowany = new System.Windows.Forms.Label();
            this.buttonPrzegladanieOferty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelZalogujSie = new System.Windows.Forms.Label();
            this.menuStronaGlowna.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStronaGlowna
            // 
            this.menuStronaGlowna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stronaGlownaToolStripMenuItem,
            this.przegladanieOfertyToolStripMenuItem,
            this.koszykToolStripMenuItem});
            this.menuStronaGlowna.Location = new System.Drawing.Point(0, 0);
            this.menuStronaGlowna.Name = "menuStronaGlowna";
            this.menuStronaGlowna.Size = new System.Drawing.Size(923, 24);
            this.menuStronaGlowna.TabIndex = 0;
            this.menuStronaGlowna.Text = "menuStrip1";
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
            // labelPowitanie
            // 
            this.labelPowitanie.AutoSize = true;
            this.labelPowitanie.Font = new System.Drawing.Font("Modern No. 20", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPowitanie.Location = new System.Drawing.Point(150, 24);
            this.labelPowitanie.Name = "labelPowitanie";
            this.labelPowitanie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPowitanie.Size = new System.Drawing.Size(636, 83);
            this.labelPowitanie.TabIndex = 1;
            this.labelPowitanie.Text = "Witaj w ksiegarni!";
            // 
            // timerStronaGlowna
            // 
            this.timerStronaGlowna.Enabled = true;
            this.timerStronaGlowna.Tick += new System.EventHandler(this.timerStronaGlowna_tick);
            // 
            // labelCzyZalogowany
            // 
            this.labelCzyZalogowany.AutoSize = true;
            this.labelCzyZalogowany.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCzyZalogowany.Location = new System.Drawing.Point(721, 660);
            this.labelCzyZalogowany.Name = "labelCzyZalogowany";
            this.labelCzyZalogowany.Size = new System.Drawing.Size(190, 24);
            this.labelCzyZalogowany.TabIndex = 2;
            this.labelCzyZalogowany.Text = "Jestes niezalogowany!";
            // 
            // buttonPrzegladanieOferty
            // 
            this.buttonPrzegladanieOferty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPrzegladanieOferty.Font = new System.Drawing.Font("Modern No. 20", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrzegladanieOferty.ForeColor = System.Drawing.Color.White;
            this.buttonPrzegladanieOferty.Location = new System.Drawing.Point(164, 257);
            this.buttonPrzegladanieOferty.Name = "buttonPrzegladanieOferty";
            this.buttonPrzegladanieOferty.Size = new System.Drawing.Size(614, 182);
            this.buttonPrzegladanieOferty.TabIndex = 3;
            this.buttonPrzegladanieOferty.Text = "Przejdz do oferty!";
            this.buttonPrzegladanieOferty.UseVisualStyleBackColor = false;
            this.buttonPrzegladanieOferty.Click += new System.EventHandler(this.buttonPrzegladanieOferty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Autorzy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weronika Rusinek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patryk Stefan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dawid Skora";
            // 
            // labelZalogujSie
            // 
            this.labelZalogujSie.AutoSize = true;
            this.labelZalogujSie.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZalogujSie.Location = new System.Drawing.Point(761, 629);
            this.labelZalogujSie.Name = "labelZalogujSie";
            this.labelZalogujSie.Size = new System.Drawing.Size(108, 24);
            this.labelZalogujSie.TabIndex = 5;
            this.labelZalogujSie.Text = "Zaloguj sie!";
            this.labelZalogujSie.Click += new System.EventHandler(this.labelZalogujSie_Click);
            // 
            // formStronaGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 693);
            this.Controls.Add(this.labelZalogujSie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrzegladanieOferty);
            this.Controls.Add(this.labelCzyZalogowany);
            this.Controls.Add(this.labelPowitanie);
            this.Controls.Add(this.menuStronaGlowna);
            this.MainMenuStrip = this.menuStronaGlowna;
            this.Name = "formStronaGlowna";
            this.Text = "Ksiegarnia";
            this.Load += new System.EventHandler(this.formStronaGlowna_Load);
            this.menuStronaGlowna.ResumeLayout(false);
            this.menuStronaGlowna.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStronaGlowna;
        private System.Windows.Forms.ToolStripMenuItem stronaGlownaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladanieOfertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koszykToolStripMenuItem;
        private System.Windows.Forms.Label labelPowitanie;
        private System.Windows.Forms.Timer timerStronaGlowna;
        private System.Windows.Forms.Label labelCzyZalogowany;
        private System.Windows.Forms.Button buttonPrzegladanieOferty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelZalogujSie;
    }
}

