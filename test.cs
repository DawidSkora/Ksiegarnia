using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ksiegarnia;


namespace Tests
{
    [TestClass]
    public class Testy_Ksiazka
    {
        [TestMethod]
        public void Test_Konstruktora()
        {
            //przygotowanie
            string tytul = "Noc";
            string autor = "Elie Wiesel";
            int cena = 25;

            //dzialanie
            Ksiazka k = new Ksiazka(tytul, autor, cena);



            //weryfikacja
            Assert.AreEqual(tytul, k.Tytul, "Niepowodzenie - tytul");
            Assert.AreEqual(autor, k.Autor, "Niepowodzenie - autor");
            Assert.AreEqual(cena, k.Cena, "Niepowodzenie - cena");
        }

    }

    [TestClass]
    public class Testy_Uzytkownik
    {
        [TestMethod]
        public void Test_Konstruktora()
        {
            //przygotowanie
            string login = "user12";
            string haslo = "testowe22";
            int id = 2345;
            string imie = "Jan";
            string nazwisko = "Kowalski";
            string adres = "Krakow";
            int numer_telefonu = 23456789;
            string email = "test@test.com";
            bool uprawnienia_admina = false;


            //dzialanie
            Uzytkownik user = new Uzytkownik(login, haslo, id, imie, nazwisko, adres, numer_telefonu, email, uprawnienia_admina);


      
            PrivateObject priv = new PrivateObject(user);
            string login_user = (string)priv.GetProperty("Login");
            string haslo_user = (string)priv.GetProperty("Haslo");


            //weryfikacja
            Assert.AreEqual(login, login_user, "Niepowodzenie - Login");
            Assert.AreEqual(haslo, haslo_user, "Niepowodzenie - Haslo");
            Assert.AreEqual(id, user.ID, "Niepowodzenie - ID");
            Assert.AreEqual(imie, user.Imie, "Niepowodzenie - Imie");
            Assert.AreEqual(nazwisko, user.Nazwisko, "Niepowodzenie - Nazwisko");
            Assert.AreEqual(adres, user.Adres, "Niepowodzenie - Adres");
            Assert.AreEqual(numer_telefonu, user.Numer_telefonu, "Niepowodzenie - Numer_telefonu");
            Assert.AreEqual(email, user.Email, "Niepowodzenie - Email");
            Assert.AreEqual(uprawnienia_admina, user.Uprawnienia_admina, "Niepowodzenie - Uprawnienia_admina");
        }
    }

    [TestClass]
    public class Testy_BazaDanych
    {
        [TestMethod]
        public void Test_Dodaj_uzytkownika()
        {
            string login = "user12";
            string haslo = "testowe22";
            int id = 2345;
            string imie = "Jan";
            string nazwisko = "Kowalski";
            string adres = "Krakow";
            int numer_telefonu = 23456789;
            string email = "test@test.com";
            bool uprawnienia_admina = false;


            int przed = BazaDanych.counter;
           
            Uzytkownik pierwszy = new Uzytkownik(login, haslo, id, imie, nazwisko, adres, numer_telefonu, email, uprawnienia_admina);
            BazaDanych.Dodaj_uzytkownika(pierwszy);



            int po = BazaDanych.counter;
          


            Assert.AreNotEqual(przed, po); // czy licznik sie zmieni³
            Assert.ReferenceEquals(pierwszy, BazaDanych.BazaUzytkownikow[po]); // czy poprawnie dodano do tablicy
        }


        [TestMethod]
        public void Test_Dodaj_ksiazke()
        {
            int przed = BazaDanych.ksiazka_counter;

            Ksiazka pierwsza = new Ksiazka();
            BazaDanych.Dodaj_ksiazke(pierwsza);

            int po = BazaDanych.ksiazka_counter;

            Assert.AreNotEqual(przed, po);  // czy licznik sie zmienil
            Assert.ReferenceEquals(pierwsza, BazaDanych.BazaKsiazek[po]); // czy poprawnie dodano do tablicy
        }






    }







}
