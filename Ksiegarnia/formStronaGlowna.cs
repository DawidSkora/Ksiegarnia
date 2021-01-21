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
                labelStronaGlownaImie.Text = ZmienneGlobalne.ZalogowanyUzytkownik_get_set.Imie;
                labelStronaGlownaImie.Visible = true;
            }
            else if (ZmienneGlobalne.czy_zalogowany_get_set == true && ZmienneGlobalne.czy_admin_get_set == true)
            {
                labelCzyZalogowany.Location = new Point(667, 660);
                labelCzyZalogowany.Text = "Jestes zalogowany [admin] !";
                labelZalogujSie.Visible = false;
                labelStronaGlownaImie.Text = " [Admin]";
                labelStronaGlownaImie.Visible = true;
            }
            else
            {
                labelCzyZalogowany.Text = "Jestes niezalogowany!";
                labelZalogujSie.Visible = true;
                labelStronaGlownaImie.Visible = false;
            }
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
            this.Hide();
            ZmienneGlobalne.formaKoszyk_get_set.Visible = true;
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

        private void labelStronaGlownaImie_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmienneGlobalne.formaPanelUzytkownika_get_set.Visible = true;
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

        // ponizej dla kazdej formy sa dokladnie takie same procedury
        // opsize dokladniej jedna - natomiast reszta rozni sie tylko nazwami form
        // idea pozostaje dokladnie taka sama

        private static formStronaGlowna formaStronaGlowna = new formStronaGlowna();  // tworzenie nowego obiektu formy Strona Glowna
        public static formStronaGlowna formaStronaGlowna_get_set // funkcja pozwala na dostep do formy oraz jej zmiane w dowolnym miejscu kodu
        {
            get { return formaStronaGlowna; } // getter
            set { formaStronaGlowna = value; } //setter
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

        private static formRejestracja formaRejestracja = new formRejestracja();

        public static formRejestracja formaRejestracja_get_set
        {
            get { return formaRejestracja; }
            set { formaRejestracja = value; }
        }
        
        private static formKomunikatZarejestrowano formaKomunikatZarejestrowano = new formKomunikatZarejestrowano();

        public static formKomunikatZarejestrowano formaKomunikatZarejestrowano_get_set
        {
            get { return formaKomunikatZarejestrowano; }
            set { formaKomunikatZarejestrowano = value; }
        }

        private static Uzytkownik ZalogowanyUzytkownik;
        
        public static Uzytkownik ZalogowanyUzytkownik_get_set
        {
            get { return ZalogowanyUzytkownik; }
            set { ZalogowanyUzytkownik = value; }
        }

        private static formKoszyk formaKoszyk= new formKoszyk();

        public static formKoszyk formaKoszyk_get_set
        {
            get { return formaKoszyk; }
            set { formaKoszyk = value; }
        }

        public static bool if_changed = false; // zmienna pomocnicza 

        private static formFinalizacja formaFinalizacja = new formFinalizacja();
        public static formFinalizacja formaFinalizacja_get_set
        {
            get { return formaFinalizacja; }
            set { formaFinalizacja = value; }
        }

        private static formBazaZamowien formaBazaZamowien = new formBazaZamowien();
        public static formBazaZamowien formaBazaZamowien_get_set
        {
            get { return formaBazaZamowien; }
            set { formaBazaZamowien = value; }
        }

        private static formPanelUzytkownika formaPanelUzytkownika = new formPanelUzytkownika();
        public static formPanelUzytkownika formaPanelUzytkownika_get_set
        {
            get { return formaPanelUzytkownika; }
            set { formaPanelUzytkownika = value; }
        }


    }

    public class Ksiazka // klasa ksiazka
    {
        public string Autor { get; }
        public string Tytul { get; }
        public int Cena { get; } 

        public Ksiazka(string tytul, string autor, int cena)
        {
            Tytul = tytul;
            Autor = autor;
            Cena = cena;  // konstruktor z danymi
        }

        public Ksiazka() { } // konstruktor bez danych


    }

    

    // klasa uzytkownik 
    public class Uzytkownik 
    {
        private string Login { get; set; }
        private string Haslo { get; set; }
        
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public int Numer_telefonu { get; set; }
        public string Email { get; set; } // podstawowe pola klasy Uzytkownik

        public bool Uprawnienia_admina { get; set; }

        public Uzytkownik (string login, string haslo, string imie, string nazwisko, string adres, int numer_telefonu, string email, bool uprawnienia_admina)
        {
            Login = login; // konstruktor podstawowy klasy Uzytkownik
            Haslo = haslo;
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
            Numer_telefonu = numer_telefonu;
            Email = email;
            Uprawnienia_admina = uprawnienia_admina;
            
            

        }

        static public bool Logowanie(string login, string haslo) // metoda logowanie klasy uzytkownik
        {
            bool if_correct = false;
            if (BazaDanych.BazaUzytkownikow != null) // aby sprawdzic czy uzytkownik jest w bazie
            {                                       // baza musi zawierac jakichkolwiek uzytkownikow
                foreach (Uzytkownik x in BazaDanych.BazaUzytkownikow) // sprawdzana jest baza danych czy znajduje sie w niej dany uzytkownik
                {
                    if (x != null && login == x.Login && haslo == x.Haslo) // jesli tak
                    {
                        if_correct = true;
                        ZmienneGlobalne.ZalogowanyUzytkownik_get_set = x; // to ustawiamy go na zalogowanego
                        
                    }
                    if (login == "admin" && login == "admin")
                    {
                        ZmienneGlobalne.czy_admin_get_set = true; // jesli jest adinem to dajemu mu flage ze jest adminem
                        
                        if_correct = true; 
                    }
                }
                
                if (if_correct) return true;
                else return false; // jesli podane dane logowania sa nieprawidlowe to zwraca falsz
            }
            else return false; // jesli baza uzytkownikow jest pusta rowniez zwraca falsz
        }
        static public void Wyloguj(Uzytkownik x) // metoda wylogowywanie klasy uzytkownik
        {
            if (x != null) // dla pewnosci jesli uzytkownik istnieje
            {
                ZmienneGlobalne.ZalogowanyUzytkownik_get_set = null;
                ZmienneGlobalne.czy_admin_get_set = false;
                ZmienneGlobalne.czy_zalogowany_get_set = false;
            }
            if (x == null) // natomiast jesli nie istnieje to tez go wylogowujemy dla pewnosci
            {
                ZmienneGlobalne.czy_admin_get_set = false;
                ZmienneGlobalne.czy_zalogowany_get_set = false;
            }
        }
    }

    public class BazaDanych // baza danych
    {
        static public Uzytkownik[] BazaUzytkownikow = new Uzytkownik[100]; 
        public static int counter=0; // baza uzytkownikow moze zawierac maksymalnie 100 uzytkownikow (jest to wartosc tylko dla przykladu)
                                    // mozna to rowniez przestawic na tablice dynamiczna w razie wymagan
        static public void Dodaj_uzytkownika (Uzytkownik nowyUzytkownik) // metoda dodajaca uzytkownika do bazy 
        {
            BazaUzytkownikow[counter] = nowyUzytkownik;
            counter++;
        }

        static public Ksiazka[] BazaKsiazek = new Ksiazka[100]; // podobnie w wypadku bazy ksiazek
        public static int ksiazka_counter = 1;

        static public void Dodaj_ksiazke (Ksiazka nowaKsiazka)
        {
            BazaKsiazek[ksiazka_counter] = nowaKsiazka;
            ksiazka_counter++;
        }

        public static Zamowienie[] Baza_zamowien = new Zamowienie[100];
        public static int zamowienia_counter = 0;
        
        public static void Dodaj_zamowienie (Zamowienie nowe_zamowienie) // rowniez podobnie w przypadku bazy zamowien
        {
            Baza_zamowien[zamowienia_counter] = nowe_zamowienie;
            zamowienia_counter++;
        }

        //static public Ksiazka[] Zamowienie = new Ksiazka[100];
    }

    public class Koszyk // klasa koszyk to tak naprawde tylko tablica ksiazek oraz metody operujacej na tej tablicy
    {
        static public Ksiazka[] BazaKoszyk = new Ksiazka[100];  // koszyk to nic innego jak tablica 100 ksiazek
        public static int koszyk_counter = 0;

        static public void Dodaj_do_koszyka(Ksiazka dodajDoKoszyka) // metoda dodawania ksiazki do koszyka
        {
            BazaKoszyk[koszyk_counter] = dodajDoKoszyka;
            koszyk_counter++;
        }

        static public void Wyczysc_koszyk ()  // metoda czyszczaca koszyk
        {
            for (int i = 0; i < 100; i++) BazaKoszyk[i] = null;
            formKoszyk nowaFormaKoszyk = new formKoszyk();
            ZmienneGlobalne.formaKoszyk_get_set = nowaFormaKoszyk;
        }

    }
    
    public class Zamowienie // klasa zamowienie 
    {
        public Ksiazka[] Dane_zamowienie = new Ksiazka[100]; // klasa zamowienie to rowniez tablica ksiazek 
        public static int i = 0;                // dla wygody jest to osobna klasa od koszyka
        public Uzytkownik dany_uzytkownik;      // natomiast pobiera dane z aktualnego koszyka
        public int SUMA;                        // oraz posiada pole ktore jest referencja do uzytkownika
                                                // poniewaz same ksiazki z koszyka nie sa zamowieniem, a potrzebne jest rowniez wiedziec
                                                // jaki uzytkownik zamawia dane ksiazki
        public Zamowienie(Uzytkownik od_kogo, int suma) //konstruktor Zamowienia
        {
            foreach (Ksiazka x in Koszyk.BazaKoszyk)  // konstruktor przyjmuje jako argumenty aktualna sume oraz referencje do uzytkownika
            {                                           // ktory jest aktualnie zalogowany- czyli ktory zamawia 
                if (x != null)
                {
                    Dane_zamowienie[i] = x;
                    i++;
                }
            }
            dany_uzytkownik = od_kogo;
            SUMA = suma;
        }

    }

}
