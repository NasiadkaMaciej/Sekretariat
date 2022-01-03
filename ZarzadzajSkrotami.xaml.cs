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
            String fraza = Interaction.InputBox("Wpisz tutaj swoją nazwę przycisku zapisz oraz jego skrót. Wstaw znak _ przed literą mającą być częścią skrótu klawiszowego", "Zmiana nazwy i skrótu przycisku szukaj", "Zapi_sz");
            ZapiszMenuItem.Header = fraza;
            changedMenu.zapisz = ZapiszMenuItem.Header.ToString();
        }
        private void Otworz(object sender, RoutedEventArgs e)
        {
        }
        private void Wyjdz(object sender, RoutedEventArgs e)
        {
        }
        private void UsunWpis(object sender, RoutedEventArgs e)
        {
        }
        private void ModyfikujWpis(object sender, RoutedEventArgs e)
        {
        }
        private void ModyfikujSkroty(object sender, RoutedEventArgs e)
        {
        }
    }
}
