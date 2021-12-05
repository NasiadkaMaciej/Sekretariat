using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

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

            //uczniowie.Add(new Uczen() { Imie = "Zawisza", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\\Users\\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Klasa = "3Pr", Grupy = "Ang gr2" });
            //uczniowie.Add(new Uczen() { Imie = "Janusz", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\\Users\\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Klasa = "3Pr", Grupy = "Ang gr2" });
            nauczyciele.Add(new Nauczyciel() { Imie = "Janusz", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\\Users\\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Wychowawstwo = "3Pr", Przedmioty = "Angielski", Klasy = "3Pr", DataZatrudnienia = DateTime.Today });
            nauczyciele.Add(new Nauczyciel() { Imie = "Krystian", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\\Users\\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Wychowawstwo = "3Pr", Przedmioty = "Angielski", Klasy = "3Pr", DataZatrudnienia = DateTime.Today });
            pracownicy.Add(new Pracownik() { Imie = "Janusz", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\\Users\\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Etat = "Pełny", Stanowisko = "Kucharz", DataZatrudnienia = DateTime.Today });
            pracownicy.Add(new Pracownik() { Imie = "Mariusz", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\\Users\\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Etat = "Pełny", Stanowisko = "Kucharz", DataZatrudnienia = DateTime.Today });

            //Uczen hej = new Uczen() { Imie = "Zawisza", DrugieImie = "Konstanty", Nazwisko = "Jabłoński", NazwiskoPanienskie = "Jabłoński", ImieOjca = "Janusz", ImieMatki = "Irena", DataUrodzenia = DateTime.Today, Pesel = "12345678901", Zdjecie = "C:\\Users\\Zawisza\\Desktop\\fotografia.png", Plec = "Mężczyzna", Klasa = "3Pr", Grupy = "Ang gr2" };
            //BinarySerialization.WriteToBinaryFile("C:\\Users\\Gall Anonim\\Desktop\\test.txt", hej, false);
            // BinarySerialization.WriteToBinaryFile<List<Uczen>>("uczniowie.txt", uczniowie);
            //BinarySerialization.WriteToBinaryFile<List<Nauczyciel>>("nauczyciele.txt", nauczyciele);
            //BinarySerialization.WriteToBinaryFile<List<Pracownik>>("pracownicy.txt", pracownicy);

            uczniowie = BinarySerialization.ReadFromBinaryFile<List<Uczen>>("uczniowie.txt");
            nauczyciele = BinarySerialization.ReadFromBinaryFile<List<Nauczyciel>>("nauczyciele.txt");
            pracownicy = BinarySerialization.ReadFromBinaryFile<List<Pracownik>>("pracownicy.txt");
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
        class Uczen : Czlowiek
        {
            public string Klasa { get; set; }
            public string Grupy { get; set; }
        }
        [Serializable]
        class Nauczyciel : Czlowiek
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
        private void uczenZaladujZdjecie(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                uczenDodajZdjecie.Content = openFileDialog.FileName.ToString();
        }
        private void nauczycielZaladujZdjecie(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                nauczycielDodajZdjecie.Content = openFileDialog.FileName.ToString();
        }
        private void pracownikZaladujZdjecie(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                pracownikDodajZdjecie.Content = openFileDialog.FileName.ToString();
        }
        private void uczenDodaj(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbiUczenPlec = (ComboBoxItem)uczenPlec.SelectedItem;
            //Dodaj sprawdzanie innych pól
            if (uczenDodajZdjecie.Content == null || cbiUczenPlec == null || uczenDataUr.SelectedDate == null)
            {
                MessageBox.Show("Uzupełnij wszystkie wymagane pola, world!");
            }
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
                    Plec = cbiUczenPlec.Content.ToString(),
                    Klasa = uczenKlasa.Text,
                    Grupy = uczenGrupy.Text
                });
                dgUczen.ItemsSource = null;
                dgUczen.ItemsSource = uczniowie;
            }
        }
        private void nauczycielDodaj(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbiNauczycielPlec = (ComboBoxItem)nauczycielPlec.SelectedItem;
            //Dodaj sprawdzanie innych pól
            if (nauczycielDodajZdjecie.Content == null || cbiNauczycielPlec == null || nauczycielDataUr.SelectedDate == null || nauczycielDataZatr.SelectedDate == null)
            {
                MessageBox.Show("Uzupełnij wszystkie wymagane pola, world!");
            }
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
                    Plec = cbiNauczycielPlec.Content.ToString(),
                    Wychowawstwo = nauczycielWychowawstwo.Text,
                    Przedmioty = nauczycielPrzedmioty.Text,
                    Klasy = nauczycielKlasy.Text,
                    DataZatrudnienia = nauczycielDataZatr.SelectedDate.Value
                });
                dgNauczyciel.ItemsSource = null;
                dgNauczyciel.ItemsSource = nauczyciele;
            }
        }
        private void pracownikDodaj(object sender, RoutedEventArgs e)
        {
        }

        public static class BinarySerialization
        {
            /// <summary>
            /// Writes the given object instance to a binary file.
            /// <para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para>
            /// <para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
            /// </summary>
            /// <typeparam name="T">The type of object being written to the XML file.</typeparam>
            /// <param name="filePath">The file path to write the object instance to.</param>
            /// <param name="objectToWrite">The object instance to write to the XML file.</param>
            /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
            public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
            {
                using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(stream, objectToWrite);
                }
            }

            /// <summary>
            /// Reads an object instance from a binary file.
            /// </summary>
            /// <typeparam name="T">The type of object to read from the XML.</typeparam>
            /// <param name="filePath">The file path to read the object instance from.</param>
            /// <returns>Returns a new instance of the object read from the binary file.</returns>
            public static T ReadFromBinaryFile<T>(string filePath)
            {
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    return (T)binaryFormatter.Deserialize(stream);
                }
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
        private void UsunWpis(object sender, RoutedEventArgs e)
        {
            switch (rodzajCzlowieka.SelectedIndex)
            {
                case 0:
                    int selectedIndex = dgUczen.SelectedIndex;
                    uczniowie.Remove(uczniowie[selectedIndex]);
                    dgUczen.ItemsSource = null;
                    dgUczen.ItemsSource = uczniowie;
                    break;
                case 1:
                    selectedIndex = dgNauczyciel.SelectedIndex;
                    nauczyciele.Remove(nauczyciele[selectedIndex]);
                    dgNauczyciel.ItemsSource = null;
                    dgNauczyciel.ItemsSource = uczniowie;
                    break;
                case 2:
                    selectedIndex = dgPracownik.SelectedIndex;
                    pracownicy.Remove(pracownicy[selectedIndex]);
                    dgPracownik.ItemsSource = null;
                    dgPracownik.ItemsSource = uczniowie;
                    break;
            }
        }
    }
}