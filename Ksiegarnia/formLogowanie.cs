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
    public partial class formLogowanie : Form
    {
        public formLogowanie()
        {
            InitializeComponent();
        }

        private void bZalogujSie_Click(object sender, EventArgs e)  // event po kliknieciu buttona logowania
        {
            if (tbLogin.Text != "" && tbHaslo.Text != "")  // jesli pola nie sa puste
            {
                if (Uzytkownik.Logowanie(tbLogin.Text, tbHaslo.Text)) // jesli dane sa poprawne 
                {
                    ZmienneGlobalne.czy_zalogowany_get_set = true; // ustawiana jest zmienna globalna czy uzytkownik jest zalogowany na true
                    tbLogin.Text = ""; // czyszczenie tb loginu
                    tbHaslo.Text = ""; // czyszczenie tb hasla
                    this.Hide();
                    ZmienneGlobalne.formaKomunikatZarejestrowano_get_set.ShowDialog(); // komunikat o poprawnym logowaniu
                    ZmienneGlobalne.formaStronaGlowna_get_set.Visible = true; // powrot do strony glownej
                }
                else
                {
                    ZmienneGlobalne.czy_zalogowany_get_set = false; // jesli dane sa nieprawidlowe - uzytkownik jest nizalogowany
                }
            }
            
        }
        
        private void bZarejestrujSie_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaRejestracja_get_set.Visible = true; // po kliknieciu przycisku zarejestruj sie- osoba jest przekierowana do formy rejestracji
        }

        private void stronaGlownaToolStripMenuItem_Click(object sender, EventArgs e)  // menu takie samo jak w innych formach
        {
            this.Hide();
            ZmienneGlobalne.formaStronaGlowna_get_set.Visible = true;
        }

        private void przegladanieOfertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaPrzegladanieOferty_get_set.Visible = true;
        }

        private void koszykToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaKoszyk_get_set.Visible = true;
        }
    }
}
