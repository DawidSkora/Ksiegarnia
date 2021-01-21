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
    public partial class formFinalizacja : Form
    {
        public formFinalizacja()
        {
            InitializeComponent();
        }

        private void formFinalizacja_Load(object sender, EventArgs e)
        {
            

        }

        private void bZamow_Click(object sender, EventArgs e)
        {
            if (cbRegulamin.Checked == true) // po kliknieciu buttona Zamow wykonywane sa czynnosci
            {
               
                Zamowienie nowe_zamowienie = new Zamowienie(ZmienneGlobalne.ZalogowanyUzytkownik_get_set, Int32.Parse(tbSuma.Text)); // tworzenie zamowienia
                BazaDanych.Dodaj_zamowienie(nowe_zamowienie); // dodawanie zamowienia do bazy
                Koszyk.Wyczysc_koszyk(); // czyszczenie koszyka
                ZmienneGlobalne.if_changed = true; // pozostalosc po probie zwiekszenia wydajnosci kodu
                this.Hide();
                ZmienneGlobalne.formaStronaGlowna_get_set.Visible = true; // powrot do strony glownej 
            }
        }

        private void bPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaKoszyk_get_set.Visible = true;  // po kliknieciu przycisku powrotu wracamy do koszyka
        }

        private void helpTimerFinalizacja_Tick(object sender, EventArgs e)
        {
            if (ZmienneGlobalne.ZalogowanyUzytkownik_get_set != null) // proces finalizacji- tylko jak uzytkownik jest zalogowany
            {
                tbImie.Text = ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Imie;
                tbNazwisko.Text = ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Nazwisko;
                tbAdres.Text = ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Adres;
                tbNrTelefonu.Text = ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Numer_telefonu.ToString();
                tbEmail.Text = ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Email; // wpisanie do texboxow odpowiednich danych

                int helpSuma = 0;
                foreach (Ksiazka x in Koszyk.BazaKoszyk)
                {
                    if (x != null)
                    {
                        helpSuma += x.Cena;         // obliczanie sumy 
                    }
                }
                tbSuma.Text = helpSuma.ToString();
            }
        }
    }
}
