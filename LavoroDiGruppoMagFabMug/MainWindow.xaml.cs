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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LavoroDiGruppoMagFabMug
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, RoutedEventArgs e)
        {
            lstCD.Items.Add(new Brano);
            txtAutore.Text = autore;
            txtTitolo.Text = titolo;
            txtDurata.Text = durata;
            txtNomeCD.Text = NomeCD;
            txtAutoreCD.Text = AutoreCD;
        }

        private void lstCD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtTitolo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
