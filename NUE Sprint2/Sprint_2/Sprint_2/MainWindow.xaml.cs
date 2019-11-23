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

namespace Sprint_2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            I_Profil.Visibility = Visibility.Hidden;
            RechtteckProfil.Visibility = Visibility.Hidden;
            T_Profil.Visibility = Visibility.Hidden;
            Kreis_Profil.Visibility = Visibility.Hidden;
            Kreisring_Profil.Visibility = Visibility.Hidden;
        }

        private void tvi_I_Profil_Selected(object sender, RoutedEventArgs e)
        {
            I_Profil.Visibility = Visibility.Visible;
            RechtteckProfil.Visibility = Visibility.Hidden;
            T_Profil.Visibility = Visibility.Hidden;
            Kreis_Profil.Visibility = Visibility.Hidden;
            Kreisring_Profil.Visibility = Visibility.Hidden;
        }
        private void tvi_Rechteck_Profil_Selected(object sender, RoutedEventArgs e)
        {
            I_Profil.Visibility = Visibility.Hidden;
            RechtteckProfil.Visibility = Visibility.Visible;
            T_Profil.Visibility = Visibility.Hidden;
            Kreis_Profil.Visibility = Visibility.Hidden;
            Kreisring_Profil.Visibility = Visibility.Hidden;
        }

      

      
       

        private void tvi_T_Profil_Selected(object sender, RoutedEventArgs e)
        {
            I_Profil.Visibility = Visibility.Hidden;
            RechtteckProfil.Visibility = Visibility.Hidden;
            T_Profil.Visibility = Visibility.Visible;
            Kreis_Profil.Visibility = Visibility.Hidden;
            Kreisring_Profil.Visibility = Visibility.Hidden;
        }

        private void tvi_Kreisprofil_Selected(object sender, RoutedEventArgs e)
        {
            I_Profil.Visibility = Visibility.Hidden;
            RechtteckProfil.Visibility = Visibility.Hidden;
            T_Profil.Visibility = Visibility.Hidden;
            Kreis_Profil.Visibility = Visibility.Visible;
            Kreisring_Profil.Visibility = Visibility.Hidden;
        }

        private void tvi_Kreisringprofil_Selected(object sender, RoutedEventArgs e)
        {
            I_Profil.Visibility = Visibility.Hidden;
            RechtteckProfil.Visibility = Visibility.Hidden;
            T_Profil.Visibility = Visibility.Hidden;
            Kreis_Profil.Visibility = Visibility.Hidden;
            Kreisring_Profil.Visibility = Visibility.Visible;
        }
        private void btn_Rechne_Click(object sender, RoutedEventArgs e)
        {
           
                double hrp;
                double brp;
                double lrp;
                double dirp;

                brp = Convert.ToDouble(tb_b.Text);
                hrp = Convert.ToDouble(tb_h.Text);
                lrp = Convert.ToDouble(tb_l.Text);
                dirp = Convert.ToDouble(tb_Dichte.Text);
            if(brp<=0||hrp<=0||lrp<=0||dirp<=0)
            {
                MessageBoxResult msgAbfrage = MessageBox.Show("Bitte geben Sie positiv Einzahl!");

            }
            else {
                double Querschnittfläche;
                double Volumen;
                double Gewicht;
                double FTM_Z;
                double FTM_Y;

                Querschnittfläche = brp * hrp;
                tb_Querschnittfläche.Text = Convert.ToString(Querschnittfläche);
                Volumen = brp * hrp * lrp;
                tb_Volumen.Text = Convert.ToString(Volumen);
                Gewicht = brp * hrp * lrp * dirp;
                tb_Gewicht.Text = Convert.ToString(Gewicht);
                FTM_Y = (brp * Math.Pow(hrp, 3)) / 12;
                tb_FTM_Y.Text = Convert.ToString(FTM_Y);
                FTM_Z = (hrp * Math.Pow(brp, 3)) / 12;
                tb_FTM_Z.Text = Convert.ToString(FTM_Z);
            }

           

        }

        private void btn_Ende_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

       
    }
}
