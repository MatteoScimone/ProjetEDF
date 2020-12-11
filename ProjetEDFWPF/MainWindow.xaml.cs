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

namespace ProjetEDFWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        edfEntities gst;
        edfEntities gst1;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
            gst1 = new edfEntities();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == null)
            {
                MessageBox.Show("Veuillez écrire votre login ", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else if (txtMotDePasse.Text== null)
            {
               MessageBox.Show("Veuillez écrire votre mot de passe ", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);

            }
            else
            {

                controleur leCtrl = gst.controleur.ToList().Find(c => c.login == txtLogin.Text && c.mdp == txtMotDePasse.Text);
                if(leCtrl == null)
                {
                   MessageBox.Show("Vos identifiant sont incorrecte ", "Votre choix", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                else
                {
                    if (leCtrl.statut == "ctrl")
                    {
                        frmGSTEDFCtrl frm = new frmGSTEDFCtrl();
                        frm.Show();
                    }
                    else
                    {
                        frmGstEdfAdmin frm1 = new frmGstEdfAdmin();
                        frm1.Show();
                    }
                }
               
                
            }
        }
    }
}
