using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Czcionka uzywana do tekstow: Modern No. 20
// Kolor background: Active Caption


namespace Ksiegarnia
{
    public partial class formStronaGlowna : Form
    {
        public formStronaGlowna() // inicjalizowanie komponentow- raczej tutaj nic nie wpisywac ani nie zmieniac :)
        {
            InitializeComponent();
        }

        private void formStronaGlowna_Load(object sender, EventArgs e)
        {
            timerStronaGlowna.Enabled = true; // podczas pierwszego ładowania strony uruchamiamy timer, który jest timerem pomocniczym
        }



        private void timerStronaGlowna_tick(object sender, EventArgs e)  // event timera ktory wspiera prace programu
        {
            //********************************************************
            // Ciąg instrukcji poniżej odpowiada za regularne sprawdzanie, czy użytkownik się zalogowal
            // oraz czy uzytkownik jest adminem.
            // W każdym przypadku wykonywane są odpowiednie instrukcje - jesli zalogowal sie admin: uprawnienia admina,
            // jesli uzytkownik- uprawnienia uzytkownika.
            // Ciąg instrukcji wykonywany jest co sekundę. Dla wiekszej wydajnosci mozna zwiekszyc tą wartość na np. co 2 sekundy.
            // *******************************************************
            if (ZmienneGlobalne.czy_zalogowany_get_set == true && ZmienneGlobalne.czy_admin_get_set == false)
            {
                labelCzyZalogowany.Text = "Jestes zalogowany!";
                labelZalogujSie.Visible = false;
            }
            else if (ZmienneGlobalne.czy_zalogowany_get_set == true && ZmienneGlobalne.czy_admin_get_set == true)
            {
                labelCzyZalogowany.Location = new Point(667, 660);
                labelCzyZalogowany.Text = "Jestes zalogowany [admin] !";
                labelZalogujSie.Visible = false;
            }
            else
                labelCzyZalogowany.Text = "Jestes niezalogowany!";
            // *******************************************************
            
        }

        // event wykonujacy sie po kliknieciu na Strone Glowna w menu
        private void stronaGlownaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // event wykonujacy sie po kliknieciu na przegladanie oferty w menu
        private void przegladanieOfertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZmienneGlobalne.formaPrzegladanieOferty_get_set.Visible = true;
            this.Visible = false;
        }

        // event wykonujacy sie po kliknieciu na Koszyk w menu
        private void koszykToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // event wykonujacy sie po kliknieciu na przycisk Przegladania oferty
        private void buttonPrzegladanieOferty_Click(object sender, EventArgs e)
        {
            ZmienneGlobalne.formaPrzegladanieOferty_get_set.Visible = true;
            this.Visible = false;
        }

        // event wykonujacy sie po kliknieciu na label zaloguj sie
        private void labelZalogujSie_Click(object sender, EventArgs e)
        {
            ZmienneGlobalne.formaLogowanie_get_set.Visible = true;
            this.Visible = false;
        }
    }

    public static class ZmienneGlobalne // zmienne globalne mają za zadanie służyć w dowolnym miejscu kodu
    {
        

        private static bool czy_zalogowany = false; // zmienna bool do przechowywania informacji 
        public static bool czy_zalogowany_get_set // getter i setter 
        {
            get { return czy_zalogowany; }
            set { czy_zalogowany = value; }
        }

        private static bool czy_admin = false; // podobnie jak powyżej, w tym przypadku informacja czy mamy prawa admina
        public static bool czy_admin_get_set // i rowniez getter i setter
        {
            get { return czy_admin; }
            set { czy_admin = value; }
        }

        private static formStronaGlowna formaStronaGlowna = new formStronaGlowna();
        public static formStronaGlowna formaStronaGlowna_get_set
        {
            get { return formaStronaGlowna; }
            set { formaStronaGlowna = value; }
        }

        private static formPrzegladanieOferty formaPrzegladanieOferty = new formPrzegladanieOferty();

        public static formPrzegladanieOferty formaPrzegladanieOferty_get_set
        {
            get { return formaPrzegladanieOferty; }
            set { formaPrzegladanieOferty = value; }
        }

        private static formLogowanie formaLogowanie = new formLogowanie();

        public static formLogowanie formaLogowanie_get_set
        {
            get { return formaLogowanie; }
            set { formaLogowanie = value; }
        }

    }

    public class Ksiazka
    {
        public string Autor { get; }
        public string Tytul { get; }
        public int Cena { get; } // should not be a part of book, but I added it for simplicity reasons

        public Ksiazka(string tytul, string autor, int cena)
        {
            Tytul = tytul;
            Autor = autor;
            Cena = cena;
        }


    }

    // klasa uzytkownik 
    public class Uzytkownik 
    {
        private string Login { get; set; }
        private string Haslo { get; set; }
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public int Numer_telefonu { get; set; }
        public string Email { get; set; }

        public bool Uprawnienia_admina { get; set; }

        public Uzytkownik (string login, string haslo, int id, string imie, string nazwisko, string adres, int numer_telefonu, string email, bool uprawnienia_admina)
        {
            Login = login;
            Haslo = haslo;
            ID = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
            Numer_telefonu = numer_telefonu;
            Email = email;
            Uprawnienia_admina = uprawnienia_admina;
        }

        static public bool Logowanie(string login, string haslo)
        {
            bool if_correct = false;
            if (BazaDanych.BazaUzytkownikow != null)
            {
                foreach (Uzytkownik x in BazaDanych.BazaUzytkownikow)
                {
                    if (x != null && login == x.Login && haslo == x.Haslo) if_correct = true;
                }
                if (if_correct) return true;
                else return false;
            }
            else return false;
        }
    }

    public class BazaDanych
    {
        static public Uzytkownik[] BazaUzytkownikow { get; set; }
        static int counter=0;
        static public void Dodaj_uzytkownika (Uzytkownik nowyUzytkownik)
        {
            BazaUzytkownikow[counter] = nowyUzytkownik;
            counter++;
        }
    }
    
}
