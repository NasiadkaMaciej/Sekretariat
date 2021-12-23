using Microsoft.Win32;
using System.Windows;

namespace Sekretariat
{
    /// <summary>
    /// Interaction logic for ModyfikujNauczyciel.xaml
    /// </summary>
    public partial class ModyfikujNauczyciel : Window
    {
        public ModyfikujNauczyciel()
        {
            InitializeComponent();
            dgNauczyciel.IsReadOnly = true;
        }
        private void zaladujZdjecie(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) nauczycielDodajZdjecie.Content = openFileDialog.FileName.ToString();
        }

        private void doModyfikuj(object sender, RoutedEventArgs e)
        {
            MainWindow.modified = true;
            this.Close();

        }
        private void AnulujModyfikuj(object sender, RoutedEventArgs e)
        {
            MainWindow.modified = false;
            this.Close();
        }
    }
}
