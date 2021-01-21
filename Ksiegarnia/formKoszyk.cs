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
    public partial class formKoszyk : Form
    {
        public formKoszyk()
        {
            InitializeComponent();
        }

        private void formKoszyk_Load(object sender, EventArgs e)
        {
            helpTimer.Enabled = true;

            
        }

        private void helpTimer_Tick(object sender, EventArgs e)
        {
            short counter_1 = 0;  // podobnie jak w bazie zamowien
            short counter_2 = 0; // odpowiednie liczniki odpowiadaja za dynamiczne wyswietlanie wszystkich ksiazek w koszyku

            
                 counter_1 = 52;
                 counter_2 = 36;

            foreach (Ksiazka x in Koszyk.BazaKoszyk)
            {
                if (x != null)
                {

                    TextBox tbTytul = new TextBox();
                    tbTytul.Location = new Point(42, counter_1);
                    tbTytul.Size = new Size(223, 20);
                    tbTytul.Text = x.Tytul;
                    this.Controls.Add(tbTytul);
                    tbTytul.Visible = true;
                    tbTytul.ReadOnly = true;

                    TextBox tbAutor = new TextBox();
                    tbAutor.Location = new Point(286, counter_1);
                    tbAutor.Size = new Size(207, 20);
                    tbAutor.Text = x.Autor;
                    this.Controls.Add(tbAutor);
                    tbAutor.Visible = true;
                    tbAutor.ReadOnly = true;

                    TextBox tbCena = new TextBox();
                    tbCena.Location = new Point(542, counter_1);
                    tbCena.Size = new Size(92, 20);
                    tbCena.Text = x.Cena.ToString() + " zl";
                    this.Controls.Add(tbCena);
                    tbCena.Visible = true;
                    tbCena.ReadOnly = true;

                    Label labelTytul = new Label();
                    labelTytul.Location = new Point(130, counter_2);
                    labelTytul.Size = new Size(35, 13);
                    labelTytul.Text = "Tytul";
                    this.Controls.Add(labelTytul);
                    labelTytul.Visible = true;

                    Label labelAutor = new Label();
                    labelAutor.Location = new Point(368, counter_2);
                    labelAutor.Size = new Size(35, 13);
                    labelAutor.Text = "Autor";
                    this.Controls.Add(labelAutor);
                    labelAutor.Visible = true;

                    Label labelCena = new Label();
                    labelCena.Location = new Point(570, counter_2);
                    labelCena.Size = new Size(35, 13);
                    labelCena.Text = "Cena";
                    this.Controls.Add(labelCena);
                    labelCena.Visible = true;

                    button1.Location = new Point(280, 263 + counter_1);
                    tbSuma.Location = new Point(325, 237 + counter_1);
                    labelSuma.Location = new Point(376, 221 + counter_1);

                    counter_1 += 52;
                    counter_2 += 52;

                    button1.Location = new Point(280, 263 + counter_1);
                }
            }

                int helpSuma = 0;
                foreach (Ksiazka x in Koszyk.BazaKoszyk)
                {
                    if (x != null)
                    {
                        helpSuma += x.Cena;  // oraz dynamiczne obliczanie sumy
                    }
                }
                tbSuma.Text = helpSuma.ToString();
                ZmienneGlobalne.if_changed = false;
            
        }

        private void stronaGlownaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaStronaGlowna_get_set.Visible = true; // event po kliknieciu menu -> strona glowna
        }

        private void przegladanieOfertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaPrzegladanieOferty_get_set.Visible = true;     // event po kliknieciu menu -> przegladanie oferty
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ZmienneGlobalne.czy_zalogowany_get_set == true)
            {
                this.Hide();
                ZmienneGlobalne.formaFinalizacja_get_set.Visible = true;    // event po kliknieciu przycisku finalizacji
            }
        }
    }
}
