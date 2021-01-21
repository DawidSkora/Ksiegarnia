using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksiegarnia
{
    public partial class formPrzegladanieOferty : Form
    {
        public formPrzegladanieOferty()
        {
            InitializeComponent();
        }

        // event po kliknieciu menu strona glowna
        private void stronaGlownaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZmienneGlobalne.formaStronaGlowna_get_set.Visible = true;
            this.Visible = false;
        }

        // event po kliknieciu menu przegladanie oferty
        private void przegladanieOfertyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // event po kliknieciu menu koszyk
        private void koszykToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        int counter = 121;
        int counter_2 = 194;
        int counter_3 = 121;
        int counter_4 = 153;
        int counter_5 = 168;
        int counter_6 = 223;
        int counter_7 = 152;
        int counter_8 = 207;
        private void buttonDodajKsiazke_Click(object sender, EventArgs e)
        {
            if (rtbDodajKsiazkeAutor.Text != "" && rtbDodajKsiazkeTytul.Text != "" && rtbDodajKsiazkeCena.Text != "")
            {
               // int cenaPomocnicza;
               // cenaPomocnicza = Int16.Parse(rtbDodajKsiazkeCena.Text);
                Ksiazka pomocnicza = new Ksiazka(rtbDodajKsiazkeTytul.Text, rtbDodajKsiazkeAutor.Text, Int16.Parse(rtbDodajKsiazkeCena.Text));
                
                // dodawanie pictureboxa
                PictureBox pbPomocniczy = new PictureBox();
                pbPomocniczy.Tag = "ksiazka" + pomocnicza.Tytul;
                pbPomocniczy.Size = new Size(160, 160);
                pbPomocniczy.Location = new Point(35, counter);
                this.Controls.Add(pbPomocniczy);
                // dodawanie jpg ksiazki
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pbPomocniczy.Image = new Bitmap(open.FileName);
                }

                // dodawanie buttona
                Button bPomocniczy = new Button();
                bPomocniczy.Tag = "bDodaj" + pomocnicza.Tytul;
                bPomocniczy.Location = new Point(799, counter_2);
                bPomocniczy.Size = new Size(112, 39);
                this.Controls.Add(bPomocniczy);
                bPomocniczy.Text = "Dodaj do koszyka";
                bPomocniczy.Enabled = true;
                bPomocniczy.Visible = true;

                // dodawanie boxa przechowującego tytul
                RichTextBox rtbTytulPom = new RichTextBox();
                rtbTytulPom.Location = new Point(382, counter);
                rtbTytulPom.Size = new Size(140, 22);
                rtbTytulPom.Text = pomocnicza.Tytul;
                this.Controls.Add(rtbTytulPom);
                rtbTytulPom.Visible = true;
                rtbTytulPom.ReadOnly = true;

                // dodawanie boxa przechowującego opis
                RichTextBox rtbOpisPom = new RichTextBox();
                rtbOpisPom.Location = new Point(242, counter_4);
                rtbOpisPom.Size = new Size(371, 91);
                this.Controls.Add(rtbOpisPom);
                rtbOpisPom.Visible = true;
                rtbOpisPom.ReadOnly = true;

                // dodawanie boxa przechowującego autora
                RichTextBox rtbAutorPom = new RichTextBox();
                rtbAutorPom.Location = new Point(650, counter_5);
                rtbAutorPom.Size = new Size(113, 21);
                rtbAutorPom.Text = pomocnicza.Autor;
                this.Controls.Add(rtbAutorPom);
                rtbAutorPom.Visible = true;
                rtbAutorPom.ReadOnly = true;

                // dodawanie boxa przechowującego ceny
                RichTextBox rtbCenaPom = new RichTextBox();
                rtbCenaPom.Location = new Point(650, counter_6);
                rtbCenaPom.Size = new Size(113, 21);
                rtbCenaPom.Text = pomocnicza.Cena.ToString() + " zl";
                this.Controls.Add(rtbCenaPom);
                rtbCenaPom.Visible = true;
                rtbCenaPom.ReadOnly = true;

                // dodawanie labela autor
                Label labelAutorPom = new Label();
                labelAutorPom.Location = new Point(684, counter_7);
                labelAutorPom.Size = new Size(32, 13);
                labelAutorPom.Text = "Autor";
                this.Controls.Add(labelAutorPom);
                labelAutorPom.Visible = true;

                // dodawanie labela cena
                Label labelCenaPom = new Label();
                labelCenaPom.Location = new Point(684, counter_8);
                labelCenaPom.Size = new Size(32, 13);
                labelCenaPom.Text = "Cena";
                this.Controls.Add(labelCenaPom);
                labelCenaPom.Visible = true;
 
                 counter += 191;
                 counter_2 += 191;
                 counter_3 += 191;
                 counter_4 += 191;
                 counter_5 += 191;
                 counter_6 += 191;
                 counter_7 += 191;
                 counter_8 += 191;

                BazaDanych.Dodaj_ksiazke(pomocnicza);
            }
        }
    }
}
