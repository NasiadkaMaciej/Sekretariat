using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Data;

namespace Sekretariat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Uczen> uczniowie = new List<Uczen>();
        List<Nauczyciel> nauczyciele = new List<Nauczyciel>();
        List<Pracownik> pracownicy = new List<Pracownik>();

        public MainWindow()
        {
            InitializeComponent();
            //Dodawanie przykładowych ludzi do tabel
            /* uczniowie.Add(new Uczen() { Imie = "Zawisza", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\Users\Zawisza\Desktop\\fotografia.png", Plec = "Mężczyzna", Klasa = "3Pr", Grupy = "Ang gr2" });
            uczniowie.Add(new Uczen() { Imie = "Janusz", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\Users\\Zawisza\Desktop\fotografia.png", Plec = "Mężczyzna", Klasa = "3Pr", Grupy = "Ang gr2" });
            nauczyciele.Add(new Nauczyciel() { Imie = "Janusz", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\Users\Zawisza\Desktop\\fotografia.png", Plec = "Mężczyzna", Wychowawstwo = "3Pr", Przedmioty = "Angielski", Klasy = "3Pr", DataZatrudnienia = DateTime.Today });
            nauczyciele.Add(new Nauczyciel() { Imie = "Krystian", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\Users\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Wychowawstwo = "3Pr", Przedmioty = "Angielski", Klasy = "3Pr", DataZatrudnienia = DateTime.Today });
            pracownicy.Add(new Pracownik() { Imie = "Janusz", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\Users\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Etat = "Pełny", Stanowisko = "Kucharz", DataZatrudnienia = DateTime.Today });
            pracownicy.Add(new Pracownik() { Imie = "Mariusz", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\Users\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Etat = "Pełny", Stanowisko = "Kucharz", DataZatrudnienia = DateTime.Today }); */

            //Zapisywanie przykładowych ludzi do plików
            /* BinarySerialization.WriteToBinaryFile<List<Uczen>>("uczniowie.txt", uczniowie);
            BinarySerialization.WriteToBinaryFile<List<Nauczyciel>>("nauczyciele.txt", nauczyciele);
            BinarySerialization.WriteToBinaryFile<List<Pracownik>>("pracownicy.txt", pracownicy); */

            //Wczytywanie ludzi z plików
            uczniowie = BinarySerialization.ReadFromBinaryFile<List<Uczen>>("uczniowie.txt");
            nauczyciele = BinarySerialization.ReadFromBinaryFile<List<Nauczyciel>>("nauczyciele.txt");
            pracownicy = BinarySerialization.ReadFromBinaryFile<List<Pracownik>>("pracownicy.txt");

            //Wstawianie ludzi do tabel
            dgUczen.ItemsSource = uczniowie;
            dgNauczyciel.ItemsSource = nauczyciele;
            dgPracownik.ItemsSource = pracownicy;

            dgUczen.IsReadOnly = true;
            dgNauczyciel.IsReadOnly = true;
            dgPracownik.IsReadOnly = true;
        }

        [Serializable]
        public class Czlowiek
        {
            public string Imie { get; set; }
            public string DrugieImie { get; set; }
            public string Nazwisko { get; set; }
            public string NazwiskoPanienskie { get; set; }
            public string ImieOjca { get; set; }
            public string ImieMatki { get; set; }
            public DateTime DataUrodzenia { get; set; }
            public string Pesel { get; set; }
            public string Zdjecie { get; set; }
            public string Plec { get; set; }
        }
        [Serializable]
        public class Uczen : Czlowiek
        {
            public override string ToString()
            {
                String data =
                    Imie + "\t" +
                    DrugieImie + "\t" +
                    Nazwisko + "\t" +
                    NazwiskoPanienskie + "\t" +
                    ImieOjca + "\t" +
                    ImieMatki + "\t" +
                    DataUrodzenia + "\t" +
                    Pesel + "\t" +
                    Zdjecie + "\t" +
                    Plec + "\t" +
                    Klasa + "\t" +
                    Grupy;
                return data;
            }
            public string Klasa { get; set; }
            public string Grupy { get; set; }
        }
        [Serializable]
        public class Nauczyciel : Czlowiek
        {
            public string Wychowawstwo { get; set; }
            public string Przedmioty { get; set; }
            public string Klasy { get; set; }
            public DateTime DataZatrudnienia { get; set; }

        }
        [Serializable]
        class Pracownik : Czlowiek
        {
            public string Etat { get; set; }
            public string Stanowisko { get; set; }
            public DateTime DataZatrudnienia { get; set; }

        }
        private void zaladujZdjecie(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                switch (rodzajCzlowieka.SelectedIndex)
                {
                    case 0:
                        uczenDodajZdjecie.Content = openFileDialog.FileName.ToString();
                        break;
                    case 1:
                        nauczycielDodajZdjecie.Content = openFileDialog.FileName.ToString();
                        break;
                    case 2:
                        pracownikDodajZdjecie.Content = openFileDialog.FileName.ToString();
                        break;
                }
            }
        }
        private void dodajCzlowieka(object sender, RoutedEventArgs e)
        {
            switch (rodzajCzlowieka.SelectedIndex)
            {
                case 0:
                    if (uczenDodajZdjecie.Content == null || uczenDataUr.SelectedDate == null) MessageBox.Show("Uzupełnij wszystkie wymagane pola");
                    else
                    {
                        uczniowie.Add(new Uczen()
                        {
                            Imie = uczenImie.Text,
                            DrugieImie = uczenDrugieImie.Text,
                            Nazwisko = uczenNazwisko.Text,
                            NazwiskoPanienskie = uczenNazwiskoPanienskie.Text,
                            ImieOjca = uczenOjciec.Text,
                            ImieMatki = uczenMatka.Text,
                            DataUrodzenia = uczenDataUr.SelectedDate.Value,
                            Pesel = uczenPesel.Text,
                            Zdjecie = uczenDodajZdjecie.Content.ToString(),
                            Plec = uczenPlec.Text,
                            Klasa = uczenKlasa.Text,
                            Grupy = uczenGrupy.Text
                        });
                        dgUczen.ItemsSource = null;
                        dgUczen.ItemsSource = uczniowie;
                    }
                    break;
                case 1:
                    if (nauczycielDodajZdjecie.Content == null || nauczycielDataUr.SelectedDate == null || nauczycielDataZatr.SelectedDate == null) MessageBox.Show("Uzupełnij wszystkie wymagane pola!");
                    else
                    {
                        nauczyciele.Add(new Nauczyciel()
                        {
                            Imie = nauczycielImie.Text,
                            DrugieImie = nauczycielDrugieImie.Text,
                            Nazwisko = nauczycielNazwisko.Text,
                            NazwiskoPanienskie = nauczycielNazwiskoPanienskie.Text,
                            ImieOjca = nauczycielOjciec.Text,
                            ImieMatki = nauczycielMatka.Text,
                            DataUrodzenia = nauczycielDataUr.SelectedDate.Value,
                            Pesel = nauczycielPesel.Text,
                            Zdjecie = nauczycielDodajZdjecie.Content.ToString(),
                            Plec = nauczycielPlec.Text,
                            Wychowawstwo = nauczycielWychowawstwo.Text,
                            Przedmioty = nauczycielPrzedmioty.Text,
                            Klasy = nauczycielKlasy.Text,
                            DataZatrudnienia = nauczycielDataZatr.SelectedDate.Value
                        });
                        dgNauczyciel.ItemsSource = null;
                        dgNauczyciel.ItemsSource = nauczyciele;
                    }
                    break;
                case 2:
                    if (pracownikDodajZdjecie.Content == null || pracownikDataUr.SelectedDate == null || pracownikDataZatr.SelectedDate == null) MessageBox.Show("Uzupełnij wszystkie wymagane pola!");
                    else
                    {
                        pracownicy.Add(new Pracownik()
                        {
                            Imie = pracownikImie.Text,
                            DrugieImie = pracownikDrugieImie.Text,
                            Nazwisko = pracownikNazwisko.Text,
                            NazwiskoPanienskie = pracownikNazwiskoPanienskie.Text,
                            ImieOjca = pracownikOjciec.Text,
                            ImieMatki = pracownikMatka.Text,
                            DataUrodzenia = pracownikDataUr.SelectedDate.Value,
                            Pesel = pracownikPesel.Text,
                            Zdjecie = pracownikDodajZdjecie.Content.ToString(),
                            Plec = pracownikPlec.Text,
                            Etat = pracownikEtat.Text,
                            Stanowisko = pracownikStanowisko.Text,
                            DataZatrudnienia = pracownikDataZatr.SelectedDate.Value
                        });
                        dgPracownik.ItemsSource = null;
                        dgPracownik.ItemsSource = pracownicy;
                    }
                    break;
            }
        }
        private void Zapisz(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                switch (rodzajCzlowieka.SelectedIndex)
                {
                    case 0:
                        BinarySerialization.WriteToBinaryFile<List<Uczen>>(saveFileDialog.FileName, uczniowie);
                        break;
                    case 1:
                        BinarySerialization.WriteToBinaryFile<List<Nauczyciel>>(saveFileDialog.FileName, nauczyciele);
                        break;
                    case 2:
                        BinarySerialization.WriteToBinaryFile<List<Pracownik>>(saveFileDialog.FileName, pracownicy);
                        break;
                }
            }
        }
        //Otwiera tabele z plików
        private void Otworz(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                switch (rodzajCzlowieka.SelectedIndex)
                {
                    case 0:
                        uczniowie = BinarySerialization.ReadFromBinaryFile<List<Uczen>>(openFileDialog.FileName.ToString());
                        dgUczen.ItemsSource = null;
                        dgUczen.ItemsSource = uczniowie;
                        break;
                    case 1:
                        nauczyciele = BinarySerialization.ReadFromBinaryFile<List<Nauczyciel>>(openFileDialog.FileName.ToString());
                        dgNauczyciel.ItemsSource = null;
                        dgNauczyciel.ItemsSource = nauczyciele;
                        break;
                    case 2:
                        pracownicy = BinarySerialization.ReadFromBinaryFile<List<Pracownik>>(openFileDialog.FileName.ToString());
                        dgPracownik.ItemsSource = null;
                        dgPracownik.ItemsSource = pracownicy;
                        break;
                }
            }
        }
        private void Wyjdz(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void UsunWpis(object sender, RoutedEventArgs e)
        {
            switch (rodzajCzlowieka.SelectedIndex)
            {
                case 0:
                    if (CzyWybranoPole(0))
                    {
                        int selectedIndex = dgUczen.SelectedIndex;
                        uczniowie.Remove(uczniowie[selectedIndex]);
                        dgUczen.ItemsSource = null;
                        dgUczen.ItemsSource = uczniowie;
                    }
                    break;
                case 1:
                    if (CzyWybranoPole(1))
                    {
                        int selectedIndex = dgNauczyciel.SelectedIndex;
                        nauczyciele.Remove(nauczyciele[selectedIndex]);
                        dgNauczyciel.ItemsSource = null;
                        dgNauczyciel.ItemsSource = nauczyciele;
                    }
                    break;
                case 2:
                    if (CzyWybranoPole(2))
                    {
                        int selectedIndex = dgPracownik.SelectedIndex;
                        pracownicy.Remove(pracownicy[selectedIndex]);
                        dgPracownik.ItemsSource = null;
                        dgPracownik.ItemsSource = pracownicy;
                    }
                    break;
            }
        }
        static public bool modified = false;
        private void ModyfikujWpis(object sender, RoutedEventArgs e)
        {
            switch (rodzajCzlowieka.SelectedIndex)
            {
                case 0:
                    if (CzyWybranoPole(0))
                    {
                        int selectedIndex = dgUczen.SelectedIndex;
                        //Utworzenie nowego okna i wpisanie do formularza oryginalnych wartości
                        ModyfikujUczen modyfikujUczen = new ModyfikujUczen();
                        modyfikujUczen.uczenImie.Text = uczniowie[selectedIndex].Imie;
                        modyfikujUczen.uczenDrugieImie.Text = uczniowie[selectedIndex].DrugieImie;
                        modyfikujUczen.uczenNazwisko.Text = uczniowie[selectedIndex].Nazwisko;
                        modyfikujUczen.uczenNazwiskoPanienskie.Text = uczniowie[selectedIndex].NazwiskoPanienskie;
                        modyfikujUczen.uczenOjciec.Text = uczniowie[selectedIndex].ImieOjca;
                        modyfikujUczen.uczenMatka.Text = uczniowie[selectedIndex].ImieMatki;
                        modyfikujUczen.uczenDataUr.Text = uczniowie[selectedIndex].DataUrodzenia.ToString();
                        modyfikujUczen.uczenPesel.Text = uczniowie[selectedIndex].Pesel;
                        modyfikujUczen.uczenDodajZdjecie.Content = uczniowie[selectedIndex].Zdjecie;
                        modyfikujUczen.uczenPlec.Text = uczniowie[selectedIndex].Plec;
                        modyfikujUczen.uczenKlasa.Text = uczniowie[selectedIndex].Klasa;
                        modyfikujUczen.uczenGrupy.Text = uczniowie[selectedIndex].Grupy;

                        //Wpisanie oryginalnych wartości do DataGrid w nowym oknie (Żeby mieć porównanie do zmodyfikowanych danych)
                        List<Uczen> podgladOryginalnegoUcznia = new List<Uczen>();
                        podgladOryginalnegoUcznia.Add(new Uczen()
                        {
                            Imie = uczniowie[selectedIndex].Imie,
                            DrugieImie = uczniowie[selectedIndex].DrugieImie,
                            Nazwisko = uczniowie[selectedIndex].Nazwisko,
                            NazwiskoPanienskie = uczniowie[selectedIndex].NazwiskoPanienskie,
                            ImieOjca = uczniowie[selectedIndex].ImieOjca,
                            ImieMatki = uczniowie[selectedIndex].ImieMatki,
                            DataUrodzenia = uczniowie[selectedIndex].DataUrodzenia,
                            Pesel = uczniowie[selectedIndex].Pesel,
                            Zdjecie = uczniowie[selectedIndex].Zdjecie,
                            Plec = uczniowie[selectedIndex].Plec,
                            Klasa = uczniowie[selectedIndex].Klasa,
                            Grupy = uczniowie[selectedIndex].Grupy
                        });
                        modyfikujUczen.dgUczen.ItemsSource = podgladOryginalnegoUcznia;
                        modyfikujUczen.ShowDialog();
                        podgladOryginalnegoUcznia.Clear();

                        //Jeśli dane zostały zmodyfikowane - nadpisz
                        if (modified)
                        {
                            uczniowie[selectedIndex].Imie = modyfikujUczen.uczenImie.Text;
                            uczniowie[selectedIndex].DrugieImie = modyfikujUczen.uczenDrugieImie.Text;
                            uczniowie[selectedIndex].Nazwisko = modyfikujUczen.uczenNazwisko.Text;
                            uczniowie[selectedIndex].NazwiskoPanienskie = modyfikujUczen.uczenNazwiskoPanienskie.Text;
                            uczniowie[selectedIndex].ImieOjca = modyfikujUczen.uczenOjciec.Text;
                            uczniowie[selectedIndex].ImieMatki = modyfikujUczen.uczenMatka.Text;
                            uczniowie[selectedIndex].DataUrodzenia = modyfikujUczen.uczenDataUr.SelectedDate.Value;
                            uczniowie[selectedIndex].Pesel = modyfikujUczen.uczenPesel.Text;
                            uczniowie[selectedIndex].Zdjecie = modyfikujUczen.uczenDodajZdjecie.Content.ToString();
                            uczniowie[selectedIndex].Plec = modyfikujUczen.uczenPlec.Text;
                            uczniowie[selectedIndex].Klasa = modyfikujUczen.uczenKlasa.Text;
                            uczniowie[selectedIndex].Grupy = modyfikujUczen.uczenGrupy.Text;
                            modified = false;
                            dgUczen.ItemsSource = null;
                            dgUczen.ItemsSource = uczniowie;
                        }
                    }
                    break;
                case 1:
                    if (CzyWybranoPole(1))
                    {
                        int selectedIndex = dgNauczyciel.SelectedIndex;
                        //Utworzenie nowego okna i wpisanie do formularza oryginalnych wartości
                        ModyfikujNauczyciel modyfikujNauczyciel = new ModyfikujNauczyciel();
                        modyfikujNauczyciel.nauczycielImie.Text = nauczyciele[selectedIndex].Imie;
                        modyfikujNauczyciel.nauczycielDrugieImie.Text = nauczyciele[selectedIndex].DrugieImie;
                        modyfikujNauczyciel.nauczycielNazwisko.Text = nauczyciele[selectedIndex].Nazwisko;
                        modyfikujNauczyciel.nauczycielNazwiskoPanienskie.Text = nauczyciele[selectedIndex].NazwiskoPanienskie;
                        modyfikujNauczyciel.nauczycielOjciec.Text = nauczyciele[selectedIndex].ImieOjca;
                        modyfikujNauczyciel.nauczycielMatka.Text = nauczyciele[selectedIndex].ImieMatki;
                        modyfikujNauczyciel.nauczycielDataUr.Text = nauczyciele[selectedIndex].DataUrodzenia.ToString();
                        modyfikujNauczyciel.nauczycielPesel.Text = nauczyciele[selectedIndex].Pesel;
                        modyfikujNauczyciel.nauczycielDodajZdjecie.Content = nauczyciele[selectedIndex].Zdjecie;
                        modyfikujNauczyciel.nauczycielPlec.Text = nauczyciele[selectedIndex].Plec;
                        modyfikujNauczyciel.nauczycielWychowawstwo.Text = nauczyciele[selectedIndex].Wychowawstwo;
                        modyfikujNauczyciel.nauczycielPrzedmioty.Text = nauczyciele[selectedIndex].Przedmioty;
                        modyfikujNauczyciel.nauczycielKlasy.Text = nauczyciele[selectedIndex].Klasy;
                        modyfikujNauczyciel.nauczycielDataZatr.Text = nauczyciele[selectedIndex].DataZatrudnienia.ToString();

                        //Wpisanie oryginalnych wartości do DataGrid w nowym oknie (Żeby mieć porównanie do zmodyfikowanych danych)
                        List<Nauczyciel> podgladOryginalnegoNauczyciela = new List<Nauczyciel>();
                        podgladOryginalnegoNauczyciela.Add(new Nauczyciel()
                        {
                            Imie = nauczyciele[selectedIndex].Imie,
                            DrugieImie = nauczyciele[selectedIndex].DrugieImie,
                            Nazwisko = nauczyciele[selectedIndex].Nazwisko,
                            NazwiskoPanienskie = nauczyciele[selectedIndex].NazwiskoPanienskie,
                            ImieOjca = nauczyciele[selectedIndex].ImieOjca,
                            ImieMatki = nauczyciele[selectedIndex].ImieMatki,
                            DataUrodzenia = nauczyciele[selectedIndex].DataUrodzenia,
                            Pesel = nauczyciele[selectedIndex].Pesel,
                            Zdjecie = nauczyciele[selectedIndex].Zdjecie,
                            Plec = nauczyciele[selectedIndex].Plec,
                            Wychowawstwo = nauczyciele[selectedIndex].Wychowawstwo,
                            Przedmioty = nauczyciele[selectedIndex].Przedmioty,
                            Klasy = nauczyciele[selectedIndex].Klasy,
                            DataZatrudnienia = nauczyciele[selectedIndex].DataZatrudnienia,
                        });
                        modyfikujNauczyciel.dgNauczyciel.ItemsSource = podgladOryginalnegoNauczyciela;
                        modyfikujNauczyciel.ShowDialog();
                        podgladOryginalnegoNauczyciela.Clear();

                        //Jeśli dane zostały zmodyfikowane - nadpisz i przeładuj
                        if (modified)
                        {
                            nauczyciele[selectedIndex].Imie = modyfikujNauczyciel.nauczycielImie.Text;
                            nauczyciele[selectedIndex].DrugieImie = modyfikujNauczyciel.nauczycielDrugieImie.Text;
                            nauczyciele[selectedIndex].Nazwisko = modyfikujNauczyciel.nauczycielNazwisko.Text;
                            nauczyciele[selectedIndex].NazwiskoPanienskie = modyfikujNauczyciel.nauczycielNazwiskoPanienskie.Text;
                            nauczyciele[selectedIndex].ImieOjca = modyfikujNauczyciel.nauczycielOjciec.Text;
                            nauczyciele[selectedIndex].ImieMatki = modyfikujNauczyciel.nauczycielMatka.Text;
                            nauczyciele[selectedIndex].DataUrodzenia = modyfikujNauczyciel.nauczycielDataUr.SelectedDate.Value;
                            nauczyciele[selectedIndex].Pesel = modyfikujNauczyciel.nauczycielPesel.Text;
                            nauczyciele[selectedIndex].Zdjecie = modyfikujNauczyciel.nauczycielDodajZdjecie.Content.ToString();
                            nauczyciele[selectedIndex].Plec = modyfikujNauczyciel.nauczycielPlec.Text;
                            nauczyciele[selectedIndex].Wychowawstwo = modyfikujNauczyciel.nauczycielWychowawstwo.Text;
                            nauczyciele[selectedIndex].Przedmioty = modyfikujNauczyciel.nauczycielPrzedmioty.Text;
                            nauczyciele[selectedIndex].Klasy = modyfikujNauczyciel.nauczycielKlasy.Text;
                            nauczyciele[selectedIndex].DataZatrudnienia = modyfikujNauczyciel.nauczycielDataZatr.SelectedDate.Value;
                            modified = false;
                            dgNauczyciel.ItemsSource = null;
                            dgNauczyciel.ItemsSource = nauczyciele;
                        }
                    }
                    break;
                case 2:
                    if (CzyWybranoPole(2))
                    {
                        int selectedIndex = dgPracownik.SelectedIndex;
                        //Utworzenie nowego okna i wpisanie do formularza oryginalnych wartości
                        ModyfikujPracownik modyfikujPracownik = new ModyfikujPracownik();
                        modyfikujPracownik.pracownikImie.Text = pracownicy[selectedIndex].Imie;
                        modyfikujPracownik.pracownikDrugieImie.Text = pracownicy[selectedIndex].DrugieImie;
                        modyfikujPracownik.pracownikNazwisko.Text = pracownicy[selectedIndex].Nazwisko;
                        modyfikujPracownik.pracownikNazwiskoPanienskie.Text = pracownicy[selectedIndex].NazwiskoPanienskie;
                        modyfikujPracownik.pracownikOjciec.Text = pracownicy[selectedIndex].ImieOjca;
                        modyfikujPracownik.pracownikMatka.Text = pracownicy[selectedIndex].ImieMatki;
                        modyfikujPracownik.pracownikDataUr.Text = pracownicy[selectedIndex].DataUrodzenia.ToString();
                        modyfikujPracownik.pracownikPesel.Text = pracownicy[selectedIndex].Pesel;
                        modyfikujPracownik.pracownikDodajZdjecie.Content = pracownicy[selectedIndex].Zdjecie;
                        modyfikujPracownik.pracownikPlec.Text = pracownicy[selectedIndex].Plec;
                        modyfikujPracownik.pracownikEtat.Text = pracownicy[selectedIndex].Etat;
                        modyfikujPracownik.pracownikStanowisko.Text = pracownicy[selectedIndex].Stanowisko;
                        modyfikujPracownik.pracownikDataZatr.Text = pracownicy[selectedIndex].DataZatrudnienia.ToString();

                        //Wpisanie oryginalnych wartości do DataGrid w nowym oknie (Żeby mieć porównanie do zmodyfikowanych danych)
                        List<Pracownik> podgladOryginalnegoPracownika = new List<Pracownik>();
                        podgladOryginalnegoPracownika.Add(new Pracownik()
                        {
                            Imie = pracownicy[selectedIndex].Imie,
                            DrugieImie = pracownicy[selectedIndex].DrugieImie,
                            Nazwisko = pracownicy[selectedIndex].Nazwisko,
                            NazwiskoPanienskie = pracownicy[selectedIndex].NazwiskoPanienskie,
                            ImieOjca = pracownicy[selectedIndex].ImieOjca,
                            ImieMatki = pracownicy[selectedIndex].ImieMatki,
                            DataUrodzenia = pracownicy[selectedIndex].DataUrodzenia,
                            Pesel = pracownicy[selectedIndex].Pesel,
                            Zdjecie = pracownicy[selectedIndex].Zdjecie,
                            Plec = pracownicy[selectedIndex].Plec,
                            Etat = pracownicy[selectedIndex].Etat,
                            Stanowisko = pracownicy[selectedIndex].Stanowisko,
                            DataZatrudnienia = pracownicy[selectedIndex].DataZatrudnienia,
                        });
                        modyfikujPracownik.dgPracownik.ItemsSource = podgladOryginalnegoPracownika;
                        modyfikujPracownik.ShowDialog();
                        podgladOryginalnegoPracownika.Clear();

                        //Jeśli dane zostały zmodyfikowane - nadpisz i przeładuj
                        if (modified)
                        {
                            pracownicy[selectedIndex].Imie = modyfikujPracownik.pracownikImie.Text;
                            pracownicy[selectedIndex].DrugieImie = modyfikujPracownik.pracownikDrugieImie.Text;
                            pracownicy[selectedIndex].Nazwisko = modyfikujPracownik.pracownikNazwisko.Text;
                            pracownicy[selectedIndex].NazwiskoPanienskie = modyfikujPracownik.pracownikNazwiskoPanienskie.Text;
                            pracownicy[selectedIndex].ImieOjca = modyfikujPracownik.pracownikOjciec.Text;
                            pracownicy[selectedIndex].ImieMatki = modyfikujPracownik.pracownikMatka.Text;
                            pracownicy[selectedIndex].DataUrodzenia = modyfikujPracownik.pracownikDataUr.SelectedDate.Value;
                            pracownicy[selectedIndex].Pesel = modyfikujPracownik.pracownikPesel.Text;
                            pracownicy[selectedIndex].Zdjecie = modyfikujPracownik.pracownikDodajZdjecie.Content.ToString();
                            pracownicy[selectedIndex].Plec = modyfikujPracownik.pracownikPlec.Text;
                            pracownicy[selectedIndex].Etat = modyfikujPracownik.pracownikEtat.Text;
                            pracownicy[selectedIndex].Stanowisko = modyfikujPracownik.pracownikStanowisko.Text;
                            pracownicy[selectedIndex].DataZatrudnienia = modyfikujPracownik.pracownikDataZatr.SelectedDate.Value;
                            modified = false;
                            dgPracownik.ItemsSource = null;
                            dgPracownik.ItemsSource = pracownicy;
                        }
                    }
                    break;
            }
        }
        private void szukaj(object sender, RoutedEventArgs e)
        {
            //dgUczen.IsTextSearchEnabled = true;
            String fraza = Interaction.InputBox("Wpisz swoje wyszukianie. Zostaw puste pole jeśli chcesz wyświetlić wszystkie dane", "Wyszukiwanie", "Szukanie");

            switch (rodzajCzlowieka.SelectedIndex)
            {
                case 0:
                    List<Uczen> searchedUczniowie = new List<Uczen>();
                    for (int i = 0; i < uczniowie.Count; i++)
                    {
                        if (uczniowie[i].ToString().Contains(fraza)) searchedUczniowie.Add(uczniowie[i]);
                    }
                    dgUczen.ItemsSource = searchedUczniowie;
                    break;
                case 1:
                    List<Nauczyciel> searchedNauczyciele = new List<Nauczyciel>();
                    for (int i = 0; i < nauczyciele.Count; i++)
                    {
                        if (nauczyciele[i].ToString().Contains(fraza)) searchedNauczyciele.Add(nauczyciele[i]);
                    }
                    dgUczen.ItemsSource = searchedNauczyciele;
                    break;
                case 2:
                    List<Pracownik> searchedPracownicy = new List<Pracownik>();
                    for (int i = 0; i < uczniowie.Count; i++)
                    {
                        if (pracownicy[i].ToString().Contains(fraza)) searchedPracownicy.Add(pracownicy[i]);
                    }
                    dgUczen.ItemsSource = searchedPracownicy;
                    break;
            }
        }
        public bool CzyWybranoPole(int rodzajCzlowieka)
        {
            switch (rodzajCzlowieka)
            {
                case 0:
                    if (dgUczen.SelectedIndex != -1) return true;
                    {
                        MessageBox.Show("Wybierz ucznia");
                        return false;
                    }
                case 1:
                    if (dgNauczyciel.SelectedIndex != -1) return true;
                    else
                    {
                        MessageBox.Show("Wybierz nauczyciela");
                        return false;
                    }
                case 2:
                    if (dgPracownik.SelectedIndex != -1) return true;
                    {
                        MessageBox.Show("Wybierz pracownika");
                        return false;
                    }
            }
            return false;

        }

        public static class BinarySerialization
        {
            //Zapisywanie do pliku
            public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
            {
                using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(stream, objectToWrite);
                }
            }
            //Czytanie z pliku
            public static T ReadFromBinaryFile<T>(string filePath)
            {
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    return (T)binaryFormatter.Deserialize(stream);
                }
            }
        }
    }
}