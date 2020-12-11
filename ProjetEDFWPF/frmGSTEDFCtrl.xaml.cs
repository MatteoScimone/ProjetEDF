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

namespace ProjetEDFWPF
{
    /// <summary>
    /// Logique d'interaction pour frmGSTEDFCtrl.xaml
    /// </summary>
    public partial class frmGSTEDFCtrl : Window
    {
        edfEntities gst;
        public frmGSTEDFCtrl()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            lstClient.ItemsSource = gst.client.ToList();
        }

        private void btnReleve_Click(object sender, RoutedEventArgs e)
        {
            if (lstClient.SelectedItem == null)
            {
                MessageBox.Show("Veuillez saisir un client ", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else if (txtNvReleve == null)
            {
                MessageBox.Show("Veuillez écrire votre releve ", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);

            }
            else
            {

            }
        }

        private void lstClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
