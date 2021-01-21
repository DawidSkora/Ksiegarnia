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
    public partial class formRejestracja : Form
    {
        public formRejestracja()
        {
            InitializeComponent();
        }

        private void stronaGlownaToolStripMenuItem_Click(object sender, EventArgs e) // menu takie jak w innych formach
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
            
        }

        private void bRejestruj_Click(object sender, EventArgs e) // event po kliknieciu przycisku rejestruj
        {
            if (tbLoginR.Text != "" && tbHasloR.Text != "" && tbImieR.Text != "" && tbNazwiskoR.Text != "" && tbAdresR.Text != "" && tbNumerTelefonuR.Text != "" && tbEmailR.Text != "" && Int32.Parse(tbNumerTelefonuR.Text) < 1000000000 && Int32.Parse(tbNumerTelefonuR.Text) > 99999999)
            { // powyzszy if odpowiada za to, czy uzytkownik nie zostawil jakiegos pola pustego oraz czy numer telefonu zawiera 9 cyfr
                Uzytkownik nowyUzytkownik = new Uzytkownik(tbLoginR.Text, tbHasloR.Text, tbImieR.Text, tbNazwiskoR.Text, tbAdresR.Text, Int32.Parse(tbNumerTelefonuR.Text), tbEmailR.Text, false);
                BazaDanych.Dodaj_uzytkownika(nowyUzytkownik); // jesli tak to tworzony jest nowy uzytkownik i dodawany jest do bazy danych
                ZmienneGlobalne.formaKomunikatZarejestrowano_get_set.ShowDialog(); // wyswielany jest komunikat o poprawnosci rejestracji
                this.Hide();
                ZmienneGlobalne.formaStronaGlowna_get_set.Visible = true; // wyswietla sie strona glowna
                tbLoginR.Text = "";
                tbHasloR.Text = "";
                tbImieR.Text = ""; // czyszczone sa textboxy zawierajace podane dane w rejestracji
                tbNazwiskoR.Text = "";
                tbAdresR.Text = "";
                tbNumerTelefonuR.Text = "";
                tbEmailR.Text = "";
            }
        }

    }
}
