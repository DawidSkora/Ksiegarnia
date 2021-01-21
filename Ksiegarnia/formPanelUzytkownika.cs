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
    public partial class formPanelUzytkownika : Form
    {
        public formPanelUzytkownika()
        {
            InitializeComponent();
        }

        private void formPanelUzytkownika_Load(object sender, EventArgs e)
        {
            
        }

        private void bWyloguj_Click(object sender, EventArgs e) // po kliknieciu wyloguj sie
        {
            if (ZmienneGlobalne.ZalogowanyUzytkownik_get_set != null) // jesli uzytkownik jest zalogowany (dla pewnosci)
            Uzytkownik.Wyloguj(ZmienneGlobalne.ZalogowanyUzytkownik_get_set); // funkcja wylogowywania 

            if (ZmienneGlobalne.czy_admin_get_set == true) // jesli admin chce sie wylogowac
            {
                ZmienneGlobalne.czy_admin_get_set = false;  // zmienna globalna czy admin jest zalogowany na false
                ZmienneGlobalne.czy_zalogowany_get_set = false; // i zwyklego uzytkownika tez 
            }

            ZmienneGlobalne.formaKomunikatZarejestrowano_get_set.ShowDialog(); // wyswietlenie komunikatu pomyslnie
            this.Hide();
            ZmienneGlobalne.formaStronaGlowna_get_set.Visible = true; // powrot do strony glownej
        }

        private void bBazaZamowien_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaBazaZamowien_get_set.Visible = true; // po kliknieciu przycisku bazy zamowien wyswietlana jest baza zamowien
        }

        private void stronaGlownaToolStripMenuItem_Click(object sender, EventArgs e) // menu tak jak w innych formach
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

        private void helpTimerPaneluzytkownika_Tick(object sender, EventArgs e) // dynamiczne sprawdzanie zalogowanego uzytkownika
        {
            if (ZmienneGlobalne.ZalogowanyUzytkownik_get_set != null)  // proces jest umieszczony w timerze- malo wydajne rozwiazanie
            {                                                           // natomiast dziala i jestesmy pewni ze mamy aktualne dane
                labelImie.Text = "Imie: " + ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Imie;
                labelNazwisko.Text = "Nazwisko: " + ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Nazwisko;
                labelEmail.Text = "Email: " + ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Email;
                labelNumerTelefonu.Text = "Numer telefonu: " + ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Numer_telefonu.ToString(); ;
                labelAdres.Text = "Adres: " + ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Adres; // wypelnianie labeli odpowiednimi danymi
            }
            if (ZmienneGlobalne.ZalogowanyUzytkownik_get_set == null) // dla admina ustawienie domyslnych wartosci labeli- "admin"
            {
                labelImie.Text = "admin";
                labelNazwisko.Text = "admin";
                labelEmail.Text = "admin";
                labelNumerTelefonu.Text = "admin";
                labelAdres.Text = "admin";
            }
            if (ZmienneGlobalne.czy_admin_get_set == false) // bazaa zamowien nie jest widoczna dla zwyklego uzytkownika
            {
                bBazaZamowien.Visible = false;
            }
            if (ZmienneGlobalne.czy_admin_get_set == true) // natomiast dla admina juz tak
            {
                bBazaZamowien.Visible = true;
            }
        }
    }
}
