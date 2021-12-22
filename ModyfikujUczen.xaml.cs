using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sekretariat
{
    /// <summary>
    /// Interaction logic for ModyfikujUczen.xaml
    /// </summary>
    public partial class ModyfikujUczen : Window
    {
        public ModyfikujUczen()
        {
            InitializeComponent();
        }

        private void uczenZaladujZdjecie(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) uczenDodajZdjecie.Content = openFileDialog.FileName.ToString();
        }

        private void doModyfikujUczen(object sender, RoutedEventArgs e)
        {
            /*
            uczenImie.Text = uczniowie[selectedIndex].Imie;
            uczenDrugieImie.Text = uczniowie[selectedIndex].DrugieImie;
            uczenNazwisko.Text = uczniowie[selectedIndex].Nazwisko;
            uczenNazwiskoPanienskie.Text = uczniowie[selectedIndex].NazwiskoPanienskie;
            uczenOjciec.Text = uczniowie[selectedIndex].ImieOjca;
            uczenMatka.Text = uczniowie[selectedIndex].ImieMatki;
            uczenDataUr.Text = uczniowie[selectedIndex].DataUrodzenia.ToString();
            uczenPesel.Text = uczniowie[selectedIndex].Pesel;
            uczenDodajZdjecie.Content = uczniowie[selectedIndex].Zdjecie;
            uczenPlec.Text = uczniowie[selectedIndex].Plec;
            uczenKlasa.Text = uczniowie[selectedIndex].Klasa;
            uczenGrupy.Text = uczniowie[selectedIndex].Grupy;
            */
            this.Close();

        }
        private void AnulujModyfikujUczen(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        /*
        public void sendValues(List<MainWindow.Uczen> uczniowie, int selectedIndex, DataGrid dg)
        {
            
            uczenImie.Text = uczniowie[selectedIndex].Imie;
            uczenDrugieImie.Text = uczniowie[selectedIndex].DrugieImie;
            uczenNazwisko.Text = uczniowie[selectedIndex].Nazwisko;
            uczenNazwiskoPanienskie.Text = uczniowie[selectedIndex].NazwiskoPanienskie;
            uczenOjciec.Text = uczniowie[selectedIndex].ImieOjca;
            uczenMatka.Text = uczniowie[selectedIndex].ImieMatki;
            uczenDataUr.Text = uczniowie[selectedIndex].DataUrodzenia.ToString();
            uczenPesel.Text = uczniowie[selectedIndex].Pesel;
            uczenDodajZdjecie.Content = uczniowie[selectedIndex].Zdjecie;
            uczenPlec.Text = uczniowie[selectedIndex].Plec;
            uczenKlasa.Text = uczniowie[selectedIndex].Klasa;
            uczenGrupy.Text = uczniowie[selectedIndex].Grupy;

            dg.ItemsSource = null;
            dg.ItemsSource = uczniowie;
        }
        */
    }
}
/*
 * public View(string table)
{
     this.table = table;
}

And when you initialize your window:

var table = "DS";
View viewWindow = new View(table);
viewWindow.Show();
*/
