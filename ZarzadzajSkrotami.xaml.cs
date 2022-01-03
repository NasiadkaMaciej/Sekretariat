using Microsoft.VisualBasic;
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
    /// Interaction logic for ZarzadzajSkrotami.xaml
    /// </summary>
    public partial class ZarzadzajSkrotami : Window
    {
        public ZarzadzajSkrotami()
        {
            InitializeComponent();
        }

        public MainWindow.Menu changedMenu;

        private void Zapisz(object sender, RoutedEventArgs e)
        {
            String fraza = Interaction.InputBox("Wpisz tutaj swoją nazwę przycisku \"zapisz\" oraz jego skrót. Wstaw znak _ przed literą mającą być częścią skrótu klawiszowego", "Zmiana nazwy i skrótu przycisku", "Zapi_sz");
            ZapiszMenuItem.Header = fraza;
            changedMenu.zapisz = ZapiszMenuItem.Header.ToString();
        }
        private void Otworz(object sender, RoutedEventArgs e)
        {
            String fraza = Interaction.InputBox("Wpisz tutaj swoją nazwę przycisku \"otwórz\" oraz jego skrót. Wstaw znak _ przed literą mającą być częścią skrótu klawiszowego", "Zmiana nazwy i skrótu przycisku", "_Otwórz");
            OtworzMenuItem.Header = fraza;
            changedMenu.otworz = OtworzMenuItem.Header.ToString();
        }
        private void Wyjdz(object sender, RoutedEventArgs e)
        {
            String fraza = Interaction.InputBox("Wpisz tutaj swoją nazwę przycisku \"wyjdź\" oraz jego skrót. Wstaw znak _ przed literą mającą być częścią skrótu klawiszowego", "Zmiana nazwy i skrótu przycisku", "_Wyjdź");
            WyjdzMenuItem.Header = fraza;
            changedMenu.wyjdz = WyjdzMenuItem.Header.ToString();
        }
        private void UsunWpis(object sender, RoutedEventArgs e)
        {
            String fraza = Interaction.InputBox("Wpisz tutaj swoją nazwę przycisku \"usuń\" oraz jego skrót. Wstaw znak _ przed literą mającą być częścią skrótu klawiszowego", "Zmiana nazwy i skrótu przycisku", "_Usuń");
            UsunMenuItem.Header = fraza;
            changedMenu.usun = UsunMenuItem.Header.ToString();
        }
        private void ModyfikujWpis(object sender, RoutedEventArgs e)
        {
            String fraza = Interaction.InputBox("Wpisz tutaj swoją nazwę przycisku \"modyfikuj\" oraz jego skrót. Wstaw znak _ przed literą mającą być częścią skrótu klawiszowego", "Zmiana nazwy i skrótu przycisku", "_Modyfikuj");
            ModyfikujMenuItem.Header = fraza;
            changedMenu.modyfikuj = ModyfikujMenuItem.Header.ToString();
        }
        private void ModyfikujSkroty(object sender, RoutedEventArgs e)
        {
            String fraza = Interaction.InputBox("Wpisz tutaj swoją nazwę przycisku \"modyfikuj\" oraz jego skrót. Wstaw znak _ przed literą mającą być częścią skrótu klawiszowego", "Zmiana nazwy i skrótu przycisku", "_Modyfikuj");
            ModyfikujMenuItem.Header = fraza;
            changedMenu.zarzadzaj = ModyfikujMenuItem.Header.ToString();
        }
        private void zapiszPodaneMenuItems(object sender, RoutedEventArgs e)
        {
            PlikMenuItem.Header = PlikTB.Text;
            changedMenu.plik = PlikMenuItem.Header.ToString();
            WpisMenuItem.Header = WpisTB.Text;
            changedMenu.wpis = WpisMenuItem.Header.ToString();
            UstawieniaMenuItem.Header = UstawieniaTB.Text;
            changedMenu.ustawienia = UstawieniaMenuItem.Header.ToString();

        }
    }
}
