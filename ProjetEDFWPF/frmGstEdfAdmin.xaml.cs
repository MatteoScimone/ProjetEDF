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
    /// Logique d'interaction pour frmGstEdfAdmin.xaml
    /// </summary>
    public partial class frmGstEdfAdmin : Window
    {
        edfEntities gst1;
        public frmGstEdfAdmin()
        {
            InitializeComponent();
        }

        private void lstControleur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstControleur.SelectedItem != null)
            {
                int numCtrl = (lstControleur.SelectedItem as controleur).id;
                lstClient.ItemsSource = gst1.client.ToList().FindAll(c => c.idcontroleur == numCtrl);
            }
            // var tousLesClient = gst1.client.ToList();
            //var lesControleurClient = gst1.controleur.ToList().FindAll(ct => ct.id == (lstClient.SelectedItem as client).idcontroleur);

            //lstClient.ItemsSource = from leClient in tousLesClient
            //                           // Any : test si ça contient les éléments;
            //                       where !lesControleurClient.Any(cts => cts.id == leClient.idcontroleur)
            //                       select leClient;
           
        }

        private void btnInsereClient_Click(object sender, RoutedEventArgs e)
        {
            if (txtNomClientt.Text == null)
            {
                MessageBox.Show("Veuillez écrire votre nom ", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else if (txtPrenomClient.Text == null)
            {
                MessageBox.Show("Veuillez écrire prenom ", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);

            }
            else
            {
                client cl = new client()
                {

                    nom = (lstClient.SelectedItem as client).nom,
                    prenom = (lstClient.SelectedItem as client).prenom,

                };
                gst1.client.Add(cl);
                gst1.SaveChanges();
                MessageBox.Show("L'insersion de votre controleur \na bien été effectuée", "Insertion", MessageBoxButton.OK, MessageBoxImage.Information);
                //lstClient.ItemsSource =
            }
            }

        private void btnInsereControleur_Click(object sender, RoutedEventArgs e)
        {
            if (txtNomControl.Text == null)
            {
                MessageBox.Show("Veuillez écrire votre nom ", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else if (txtPrenomControl.Text == null)
            {
                MessageBox.Show("Veuillez écrire votre prenom ", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);

            }
            else
            {
                controleur c = new controleur()
                {
                    
                    nom = (lstControleur.SelectedItem as controleur).nom,
                    prenom = (lstControleur.SelectedItem as controleur).prenom,
                    
                };
                gst1.controleur.Add(c);
                gst1.SaveChanges();
                foreach (controleur ct in lstControleur.ItemsSource)
                {
                    //gst1.controleur.ToList().Find(cts => cts. == 
                    //gst1.SaveChanges();
                }
                   
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            // var lesControleurAdmin = gst1.controleur.ToList().FindAll(ct => ct.id == (lstControleur.SelectedItem as controleur).statut;
            gst1 = new edfEntities();
            lstControleur.ItemsSource = gst1.controleur.ToList();
        }

        private void lstClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
