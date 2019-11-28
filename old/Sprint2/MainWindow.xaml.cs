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

namespace Sprint2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Programm wird beendet
        private void btn_Ende_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Berechne alles
        private void btn_Rechne_Click(object sender, RoutedEventArgs e)
        {
            //tb_b.Text = "asd";
        }

        //Überprüfe, ob die Eingabe stimmt (ist eine Zahl?)
        private void funk_checkIfNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //WILLKOMMEN
        private void it_Willkommen_Selected(object sender, RoutedEventArgs e)
        {
            img_Image.Visibility = Visibility.Hidden;
            profilName.Visibility = Visibility.Hidden;

            label1.Visibility = Visibility.Hidden;
            tb_1.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            tb_2.Visibility = Visibility.Hidden;
            label3.Visibility = Visibility.Hidden;
            tb_3.Visibility = Visibility.Hidden;
            label4.Visibility = Visibility.Hidden;
            tb_4.Visibility = Visibility.Hidden;
            label5.Visibility = Visibility.Hidden;
            tb_5.Visibility = Visibility.Hidden;

            label_Dichte.Visibility = Visibility.Hidden;
            tb_Dichte.Visibility = Visibility.Hidden;

            label_Laenge.Visibility = Visibility.Hidden;
            tb_Laenge.Visibility = Visibility.Hidden;

            btn_Rechne.IsEnabled = false;

            lb_Flaeche.Visibility = Visibility.Hidden;
            tb_Flaeche.Visibility = Visibility.Hidden;
            lb_Volumen.Visibility = Visibility.Hidden;
            tb_Volumen.Visibility = Visibility.Hidden;
            
        }

        //EIN PROFIL IST AUSGEWÄHLT
        private void it_Profil_Selected(object sender, RoutedEventArgs e)
        {
            label_Dichte.Visibility = Visibility.Visible;
            tb_Dichte.Visibility = Visibility.Visible;
            label_Dichte.Content = "Dichte [kg/m^3]";
            

            label_Laenge.Visibility = Visibility.Visible;
            tb_Laenge.Visibility = Visibility.Visible;
            label_Laenge.Content = "Länge [mm]";

            btn_Rechne.IsEnabled = true;

            lb_Volumen.Content = "Volumen [mm^3]";
            lb_Flaeche.Content = "Flaeche [mm^2]";
            lb_Flaeche.Visibility = Visibility.Visible;
            tb_Flaeche.Visibility = Visibility.Visible;
            lb_Volumen.Visibility = Visibility.Visible;
            tb_Volumen.Visibility = Visibility.Visible;

            tb_1.Text = ""; tb_2.Text = ""; tb_3.Text = ""; tb_4.Text = ""; tb_5.Text = "";

        }

            //RECHTECKT
            private void it_Rechteckprofil_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_Rechteckprofil.Header;
            profilName.Visibility = Visibility.Visible;

            img_Image.Source = new BitmapImage(new Uri("Resources/img_Rechteck.jpg", UriKind.Relative));
            img_Image.Visibility = Visibility.Visible;

            label1.Content = "Breite b";
            tb_1.Visibility = Visibility.Visible;

            label2.Content = "Höhe h";
            tb_2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Hidden;
            tb_3.Visibility = Visibility.Hidden;
            label4.Visibility = Visibility.Hidden;
            tb_4.Visibility = Visibility.Hidden;
            label5.Visibility = Visibility.Hidden;
            tb_5.Visibility = Visibility.Hidden;

            

        }

        //I-Profil
        private void it_IProfil_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content =  it_IProfil.Header;
            profilName.Visibility = Visibility.Visible;

            img_Image.Source = new BitmapImage(new Uri("Resources/img_IProfil.jpg", UriKind.Relative));
            img_Image.Visibility = Visibility.Visible;

            label1.Visibility = Visibility.Visible;
            label1.Content = "B";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Visible;
            label2.Content = "b1";
            tb_2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Visible;
            label3.Content = "b2";
            tb_3.Visibility = Visibility.Visible;

            label4.Visibility = Visibility.Visible;
            label4.Content = "H";
            tb_4.Visibility = Visibility.Visible;

            label5.Visibility = Visibility.Visible;
            label5.Content = "h";
            tb_5.Visibility = Visibility.Visible;
        }

        //T-Profil
        private void it_TProfil_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_TProfil.Header;
            profilName.Visibility = Visibility.Visible;

            img_Image.Source = new BitmapImage(new Uri("Resources/img_TProfil.jpg", UriKind.Relative));
            img_Image.Visibility = Visibility.Visible;

            label1.Visibility = Visibility.Visible;
            label1.Content = "B";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Visible;
            label2.Content = "b1";
            tb_2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Visible;
            label3.Content = "b2";
            tb_3.Visibility = Visibility.Visible;

            label4.Visibility = Visibility.Visible;
            label4.Content = "H";
            tb_4.Visibility = Visibility.Visible;

            label5.Visibility = Visibility.Visible;
            label5.Content = "h";
            tb_5.Visibility = Visibility.Visible;
        }

        //Kreis
        private void it_Kreis_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_KeisProfil.Header;
            profilName.Visibility = Visibility.Visible;

            img_Image.Source = new BitmapImage(new Uri("Resources/img_Kreis.jpg", UriKind.Relative));
            img_Image.Visibility = Visibility.Visible;

            label1.Visibility = Visibility.Visible;
            label1.Content = "Durchmesser d";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Hidden;
            label2.Content = "";
            tb_2.Visibility = Visibility.Hidden;

            label3.Visibility = Visibility.Hidden;
            label3.Content = "";
            tb_3.Visibility = Visibility.Hidden;

            label4.Visibility = Visibility.Hidden;
            label4.Content = "";
            tb_4.Visibility = Visibility.Hidden;

            label5.Visibility = Visibility.Hidden;
            label5.Content = "";
            tb_5.Visibility = Visibility.Hidden;
        }

        //Kreis-Ring
        private void it_Kreisring_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_KreisringProfil.Header;
            profilName.Visibility = Visibility.Visible;

            img_Image.Source = new BitmapImage(new Uri("Resources/img_Kreisring.jpg", UriKind.Relative));
            img_Image.Visibility = Visibility.Visible;

            label1.Visibility = Visibility.Visible;
            label1.Content = "D außen";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Visible;
            label2.Content = "d innen";
            tb_2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Hidden;
            label3.Content = "";
            tb_3.Visibility = Visibility.Hidden;

            label4.Visibility = Visibility.Hidden;
            label4.Content = "";
            tb_4.Visibility = Visibility.Hidden;

            label5.Visibility = Visibility.Hidden;
            label5.Content = "";
            tb_5.Visibility = Visibility.Hidden;
        }

        //Dreieck
        private void it_Dreieck_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_Dreieck.Header;
            profilName.Visibility = Visibility.Visible;

            img_Image.Source = new BitmapImage(new Uri("Resources/img_Dreieck.jpg", UriKind.Relative));
            img_Image.Visibility = Visibility.Visible;

            label1.Visibility = Visibility.Visible;
            label1.Content = "Höhe h";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Visible;
            label2.Content = "Breite b";
            tb_2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Hidden;
            label3.Content = "";
            tb_3.Visibility = Visibility.Hidden;

            label4.Visibility = Visibility.Hidden;
            label4.Content = "";
            tb_4.Visibility = Visibility.Hidden;

            label5.Visibility = Visibility.Hidden;
            label5.Content = "";
            tb_5.Visibility = Visibility.Hidden;
        }
    }
}
