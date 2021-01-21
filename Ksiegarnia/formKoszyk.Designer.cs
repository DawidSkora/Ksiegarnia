
namespace Ksiegarnia
{
    partial class formKoszyk
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuKoszyk = new System.Windows.Forms.MenuStrip();
            this.stronaGlownaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladanieOfertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koszykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSuma = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.helpTimer = new System.Windows.Forms.Timer(this.components);
            this.menuKoszyk.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Finalizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuKoszyk
            // 
            this.menuKoszyk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stronaGlownaToolStripMenuItem,
            this.przegladanieOfertyToolStripMenuItem,
            this.koszykToolStripMenuItem});
            this.menuKoszyk.Location = new System.Drawing.Point(0, 0);
            this.menuKoszyk.Name = "menuKoszyk";
            this.menuKoszyk.Size = new System.Drawing.Size(818, 24);
            this.menuKoszyk.TabIndex = 2;
            this.menuKoszyk.Text = "menuStrip1";
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
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Location = new System.Drawing.Point(376, 221);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(34, 13);
            this.labelSuma.TabIndex = 3;
            this.labelSuma.Text = "Suma";
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(325, 237);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.ReadOnly = true;
            this.tbSuma.Size = new System.Drawing.Size(131, 20);
            this.tbSuma.TabIndex = 4;
            // 
            // helpTimer
            // 
            this.helpTimer.Enabled = true;
            this.helpTimer.Interval = 2000;
            this.helpTimer.Tick += new System.EventHandler(this.helpTimer_Tick);
            // 
            // formKoszyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 601);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.labelSuma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuKoszyk);
            this.MainMenuStrip = this.menuKoszyk;
            this.Name = "formKoszyk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ksiegarnia";
            this.Load += new System.EventHandler(this.formKoszyk_Load);
            this.menuKoszyk.ResumeLayout(false);
            this.menuKoszyk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuKoszyk;
        private System.Windows.Forms.ToolStripMenuItem stronaGlownaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladanieOfertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koszykToolStripMenuItem;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Timer helpTimer;
    }
}