
namespace Ksiegarnia
{
    partial class formFinalizacja
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
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbNrTelefonu = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.bZamow = new System.Windows.Forms.Button();
            this.cbRegulamin = new System.Windows.Forms.CheckBox();
            this.bPowrot = new System.Windows.Forms.Button();
            this.helpTimerFinalizacja = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(35, 36);
            this.tbImie.Name = "tbImie";
            this.tbImie.ReadOnly = true;
            this.tbImie.Size = new System.Drawing.Size(159, 20);
            this.tbImie.TabIndex = 0;
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(35, 84);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.ReadOnly = true;
            this.tbNazwisko.Size = new System.Drawing.Size(159, 20);
            this.tbNazwisko.TabIndex = 0;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(35, 138);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.ReadOnly = true;
            this.tbAdres.Size = new System.Drawing.Size(159, 20);
            this.tbAdres.TabIndex = 0;
            // 
            // tbNrTelefonu
            // 
            this.tbNrTelefonu.Location = new System.Drawing.Point(35, 192);
            this.tbNrTelefonu.Name = "tbNrTelefonu";
            this.tbNrTelefonu.ReadOnly = true;
            this.tbNrTelefonu.Size = new System.Drawing.Size(159, 20);
            this.tbNrTelefonu.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(35, 253);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(159, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(77, 336);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.ReadOnly = true;
            this.tbSuma.Size = new System.Drawing.Size(76, 20);
            this.tbSuma.TabIndex = 0;
            // 
            // bZamow
            // 
            this.bZamow.Location = new System.Drawing.Point(47, 438);
            this.bZamow.Name = "bZamow";
            this.bZamow.Size = new System.Drawing.Size(147, 43);
            this.bZamow.TabIndex = 1;
            this.bZamow.Text = "Zamow";
            this.bZamow.UseVisualStyleBackColor = true;
            this.bZamow.Click += new System.EventHandler(this.bZamow_Click);
            // 
            // cbRegulamin
            // 
            this.cbRegulamin.AutoSize = true;
            this.cbRegulamin.Location = new System.Drawing.Point(57, 400);
            this.cbRegulamin.Name = "cbRegulamin";
            this.cbRegulamin.Size = new System.Drawing.Size(122, 17);
            this.cbRegulamin.TabIndex = 2;
            this.cbRegulamin.Text = "Akceptuje regulamin";
            this.cbRegulamin.UseVisualStyleBackColor = true;
            // 
            // bPowrot
            // 
            this.bPowrot.Location = new System.Drawing.Point(168, 514);
            this.bPowrot.Name = "bPowrot";
            this.bPowrot.Size = new System.Drawing.Size(81, 25);
            this.bPowrot.TabIndex = 3;
            this.bPowrot.Text = "Powrot";
            this.bPowrot.UseVisualStyleBackColor = true;
            this.bPowrot.Click += new System.EventHandler(this.bPowrot_Click);
            // 
            // helpTimerFinalizacja
            // 
            this.helpTimerFinalizacja.Enabled = true;
            this.helpTimerFinalizacja.Interval = 1000;
            this.helpTimerFinalizacja.Tick += new System.EventHandler(this.helpTimerFinalizacja_Tick);
            // 
            // formFinalizacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(252, 541);
            this.Controls.Add(this.bPowrot);
            this.Controls.Add(this.cbRegulamin);
            this.Controls.Add(this.bZamow);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNrTelefonu);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.tbImie);
            this.Name = "formFinalizacja";
            this.Text = "formFinalizacja";
            this.Load += new System.EventHandler(this.formFinalizacja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbNrTelefonu;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Button bZamow;
        private System.Windows.Forms.CheckBox cbRegulamin;
        private System.Windows.Forms.Button bPowrot;
        private System.Windows.Forms.Timer helpTimerFinalizacja;
    }
}