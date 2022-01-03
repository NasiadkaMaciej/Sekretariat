using Microsoft.Win32;
using System.Windows;

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
            dgUczen.IsReadOnly = true;
        }
        private void zaladujZdjecie(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) uczenDodajZdjecie.Content = openFileDialog.FileName.ToString();
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
