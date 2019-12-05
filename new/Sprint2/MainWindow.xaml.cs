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

using System.Windows.Forms; //für den Exit-Fenster
using MessageBox = System.Windows.MessageBox;
using TextBox = System.Windows.Controls.TextBox;

namespace Sprint2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Programm wird beendet
        private void btn_Ende_Click(object sender, RoutedEventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show(
                "Wollen Sie das Programm wirklich beenden?",
                "Programmende",
                 MessageBoxButtons.YesNo);

            // Schießt das Programm, wenn result==true
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Berechne alles, je nachdem was gerade ausgewählt ist
        private void btn_Rechne_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)tw_profilAuswahl.SelectedItem;
            string currentItemName = (string)item.Name; //name des aktuell ausgewählten Profils

            
            if (currentItemName == "it_Rechteckprofil")
            {
                rechne_Rechteck();
            }
            else if (currentItemName == "it_IProfil")
            {
                rechne_IProfil();
            }
            else if (currentItemName == "it_TProfil")
            {
                rechne_TProfil();
            }
            else if (currentItemName == "it_Dreieck")
            {
                rechne_Dreieck();
            }
            else if (currentItemName == "it_KeisProfil")
            {
                rechne_Kreis();
            }
            else if (currentItemName == "it_KreisringProfil")
            {
                rechne_Kreisring();
            }

        }

        //Berechne Volumen ist für alle Profile gleich
        private void rechne_VolumentUndMasse()
        {

            double vol;
            vol = Convert.ToDouble(tb_Flaeche.Text) * Convert.ToDouble(tb_Laenge.Text);
            tb_Volumen.Text = Convert.ToString(Math.Round(vol,6));

            double mas;
            mas = Convert.ToDouble(tb_Volumen.Text) * Convert.ToDouble(tb_Dichte.Text);
            tb_Masse.Text = Convert.ToString(Math.Round(mas, 6));
        }

        //BERECHNE RECHTECK
      private void rechne_Rechteck()
        {
            double b = Convert.ToDouble(tb_1.Text);
            double h = Convert.ToDouble(tb_2.Text);
            
            

            //FLÄCHE
            tb_Flaeche.Text = Convert.ToString(Math.Round(
                b*h,
                6));

            //VOLUMEN und MASSE
            rechne_VolumentUndMasse();

            //TRÄGHEIT
            double Iy, Iz;
            Iy = b * Math.Pow(h,3) / 12;
            Iz = h * Math.Pow(b, 3) / 12;

            tb_out1.Text = Convert.ToString(Math.Round(Iy,6));
            tb_out2.Text = Convert.ToString(Math.Round(Iz, 6));
        }

        //BERECHNE  I-PROFIL
        private void rechne_IProfil()
        {
            double H = Convert.ToDouble(tb_1.Text);
            double h = Convert.ToDouble(tb_2.Text);
            double B = Convert.ToDouble(tb_3.Text);
            double b = Convert.ToDouble(tb_4.Text);
            

            if (B < b)
            {
                MessageBoxResult msgAbfrage = MessageBox.Show("B muss größer als b sein!");
                return;
            }
            else if (H < h)
            {
                MessageBoxResult msgAbfrage = MessageBox.Show("H muss größer als h sein!");
                return;
            }

            //FLÄCHE
            tb_Flaeche.Text = Convert.ToString(Math.Round(
                B*H-h*(B-b),
                6));

            //VOLUMEN und MASSE
            rechne_VolumentUndMasse();

            //TRÄGHEIT
            double Iy;
            Iy = (B * Math.Pow(H, 3) - (B-b)* Math.Pow(h, 3)) / 12;
            
            tb_out1.Text = Convert.ToString(Math.Round(Iy, 6));
           
        }

        //BERECHNE  T-PROFIL
        private void rechne_TProfil()
        {
            double H = Convert.ToDouble(tb_1.Text);
            double h = Convert.ToDouble(tb_2.Text);
            double B = Convert.ToDouble(tb_3.Text);
            double b = Convert.ToDouble(tb_4.Text);
            
            if (B < b)
            {
                MessageBoxResult msgAbfrage = MessageBox.Show("B muss größer als b sein!");
                return;
            }
            else if (H < h)
            {
                MessageBoxResult msgAbfrage = MessageBox.Show("H muss größer als h sein!");
                return;
            }

            //FLÄCHE
            tb_Flaeche.Text = Convert.ToString(Math.Round(
                B*(H-h)+h*b,
                6));
            //VOLUMEN und MASSE
            rechne_VolumentUndMasse();
            //TRÄGHEIT
            double Iy;
            Iy = (B * Math.Pow(H, 3) + (B-b) * Math.Pow(h, 3)) / 12;
            
            tb_out1.Text = Convert.ToString(Math.Round(Iy, 6));

        }

        //BERECHNE DREIECK
        private void rechne_Dreieck()
        {
            double h = Convert.ToDouble(tb_1.Text);
            double b = Convert.ToDouble(tb_2.Text);

            


            //FLÄCHE
            tb_Flaeche.Text = Convert.ToString(Math.Round(
                (h*b)/2,
                6));
            //VOLUMEN und MASSE
            rechne_VolumentUndMasse();
            //TRÄGHEIT
            double Iy; double Iz;
            Iy = (b*Math.Pow(h,3))/36;
            Iz = (h * Math.Pow(b, 3)) / 48;

            tb_out1.Text = Convert.ToString(Math.Round(Iy, 6));
            tb_out2.Text = Convert.ToString(Math.Round(Iz, 6));
        }

        //BERECHNE KREIS
        private void rechne_Kreis()
        {
            double d = Convert.ToDouble(tb_1.Text);

            //FLÄCHE
            tb_Flaeche.Text = Convert.ToString(Math.Round(
                Math.PI*Math.Pow(d,2)/4,
                6));
            //VOLUMEN und MASSE

            rechne_VolumentUndMasse();

            //TRÄGHEIT
            double I;
            I = (Math.PI*Math.Pow(d,4)) / 64;

            tb_out1.Text = Convert.ToString(Math.Round(I, 6));

        }

        //BERECHNE KREISRING
        private void rechne_Kreisring()
        {
            double D = Convert.ToDouble(tb_1.Text);
            double d = Convert.ToDouble(tb_2.Text);
            
            if (D < d)
            {
                MessageBoxResult msgAbfrage = MessageBox.Show("D muss größer als d sein!");
                return;
            }
          

            //FLÄCHE
            tb_Flaeche.Text = Convert.ToString(Math.Round(
                Math.PI * (Math.Pow(D, 2)- Math.Pow(d, 2)) / 4,
                6));

            //VOLUMEN und MASSE
            rechne_VolumentUndMasse();

            //TRÄGHEIT
            double I;
            I = (Math.PI * (Math.Pow(D, 4)- Math.Pow(d, 4))) / 64;

            tb_out1.Text = Convert.ToString(Math.Round(I, 6));

        }


        //-----------------------------------


        //Einlesen der Zahlen
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }


        private void testIfNumeric(object sender, TextChangedEventArgs e)
        {
            TextBox tb = (TextBox)e.Source;
            string neu = "";
            bool punktVorhanden = false;

            for (int i = 0; i < tb.Text.Length; i++)
            {
                char c = tb.Text[i];
                if (char.IsDigit(c) || (c == '-' && i == 0))
                {
                    neu += c;
                }
                else if (c == ',' && !punktVorhanden)
                {
                    neu += c;
                    punktVorhanden = true;
                }
            }

            tb.Text = neu;
        }
            //Zeige dem Profil entsprechendes Bild
            private void zeigeBild(string location)
        {
            img_Image.Source = new BitmapImage(new Uri(location, UriKind.Relative));
            img_Image.Visibility = Visibility.Visible;
        }

        //-----------------------------------

        //WILLKOMMEN
        private void it_Willkommen_Selected(object sender, RoutedEventArgs e)
        {
            lb_Willkommen.Visibility = Visibility.Visible;

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

            lb_Dichte.Visibility = Visibility.Hidden;
            tb_Dichte.Visibility = Visibility.Hidden;

            lb_Laenge.Visibility = Visibility.Hidden;
            tb_Laenge.Visibility = Visibility.Hidden;

            lb_Masse.Visibility = Visibility.Hidden;
            tb_Masse.Visibility = Visibility.Hidden;

            btn_Rechne.IsEnabled = false;

            lb_Flaeche.Visibility = Visibility.Hidden;
            tb_Flaeche.Visibility = Visibility.Hidden;
            lb_Volumen.Visibility = Visibility.Hidden;
            tb_Volumen.Visibility = Visibility.Hidden;

            lb_out1.Visibility = Visibility.Hidden;
            lb_out2.Visibility = Visibility.Hidden;

            tb_out1.Visibility = Visibility.Hidden;
            tb_out2.Visibility = Visibility.Hidden;
        }


        //EIN PROFIL WURDE AUSGEWÄHLT
        private void it_Profil_Selected(object sender, RoutedEventArgs e)
        {
            lb_Willkommen.Visibility = Visibility.Hidden;

            lb_Dichte.Visibility = Visibility.Visible;
            tb_Dichte.Visibility = Visibility.Visible;
            lb_Dichte.Content = "Dichte [kg/mm^3]";


            lb_Laenge.Visibility = Visibility.Visible;
            tb_Laenge.Visibility = Visibility.Visible;
            lb_Laenge.Content = "Länge [mm]";

            btn_Rechne.IsEnabled = true;

            lb_Volumen.Content = "Volumen [mm^3]";
            lb_Flaeche.Content = "Flaeche [mm^2]";
            lb_Masse.Content = "Masse [kg]";

            lb_Flaeche.Visibility = Visibility.Visible;
            tb_Flaeche.Visibility = Visibility.Visible;

            lb_Volumen.Visibility = Visibility.Visible;
            tb_Volumen.Visibility = Visibility.Visible;

            lb_Masse.Visibility = Visibility.Visible;
            tb_Masse.Visibility = Visibility.Visible;

            
            tb_1.Text = ""; tb_2.Text = ""; tb_3.Text = ""; tb_4.Text = "";
            tb_Flaeche.Text = ""; tb_Masse.Text = "";tb_Volumen.Text = ""; tb_out1.Text = ""; tb_out2.Text = "";

        }

        //RECHTECKT
        private void it_Rechteckprofil_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_Rechteckprofil.Header;
            profilName.Visibility = Visibility.Visible;

            zeigeBild("Resources/img_Rechteck.jpg");

            label1.Visibility = Visibility.Visible;
            label1.Content = "b [mm]";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Visible;
            label2.Content = "h [mm]";
            tb_2.Visibility = Visibility.Visible;

            lb_out1.Content = "Iy [mm^4]";
            lb_out2.Content = "Iz [mm^4]";

            lb_out1.Visibility = Visibility.Visible;
            lb_out2.Visibility = Visibility.Visible;

            tb_out1.Visibility = Visibility.Visible;
            tb_out2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Hidden;
            tb_3.Visibility = Visibility.Hidden;

            label4.Visibility = Visibility.Hidden;
            tb_4.Visibility = Visibility.Hidden;

        }

        //I-Profil
        private void it_IProfil_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content =  it_IProfil.Header;
            profilName.Visibility = Visibility.Visible;

            zeigeBild("Resources/img_IProfil.jpg");

            lb_out1.Visibility = Visibility.Visible;
            tb_out1.Visibility = Visibility.Visible;

            lb_out1.Content = "Iy [mm^4]";
            lb_out2.Content = "";

            lb_out2.Visibility = Visibility.Hidden;
            tb_out2.Visibility = Visibility.Hidden;

            label1.Visibility = Visibility.Visible;
            label1.Content = "H [mm]";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Visible;
            label2.Content = "h [mm]";
            tb_2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Visible;
            label3.Content = "B [mm]";
            tb_3.Visibility = Visibility.Visible;

            label4.Visibility = Visibility.Visible;
            label4.Content = "b [mm]";
            tb_4.Visibility = Visibility.Visible;

        }

        //T-Profil
        private void it_TProfil_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_TProfil.Header;
            profilName.Visibility = Visibility.Visible;

            zeigeBild("Resources/img_TProfil.jpg");

            lb_out1.Visibility = Visibility.Visible;
            tb_out1.Visibility = Visibility.Visible;

            lb_out1.Content = "Iy [mm^4]";
            lb_out2.Content = "";

            lb_out2.Visibility = Visibility.Hidden;
            tb_out2.Visibility = Visibility.Hidden;

            label1.Visibility = Visibility.Visible;
            label1.Content = "H [mm]";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Visible;
            label2.Content = "h [mm]";
            tb_2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Visible;
            label3.Content = "B [mm]";
            tb_3.Visibility = Visibility.Visible;

            label4.Visibility = Visibility.Visible;
            label4.Content = "b [mm]";
            tb_4.Visibility = Visibility.Visible;

        }

        //Kreis
        private void it_Kreis_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_KeisProfil.Header;
            profilName.Visibility = Visibility.Visible;

            zeigeBild("Resources/img_Kreis.jpg");

            lb_out1.Visibility = Visibility.Visible;
            tb_out1.Visibility = Visibility.Visible;

            lb_out1.Content = "I [mm^4]";
            lb_out2.Content = "";

            lb_out2.Visibility = Visibility.Hidden;
            tb_out2.Visibility = Visibility.Hidden;

            label1.Visibility = Visibility.Visible;
            label1.Content = "d [mm]";
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

        }

        //Kreis-Ring
        private void it_Kreisring_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_KreisringProfil.Header;
            profilName.Visibility = Visibility.Visible;

            zeigeBild("Resources/img_Kreisring.jpg");

          
            lb_out1.Visibility = Visibility.Visible;
            tb_out1.Visibility = Visibility.Visible;
            
            lb_out1.Content = "I [mm^4]";
            lb_out2.Content = "";

            lb_out2.Visibility = Visibility.Hidden;
            tb_out2.Visibility = Visibility.Hidden;

            label1.Visibility = Visibility.Visible;
            label1.Content = "D [mm]";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Visible;
            label2.Content = "d [mm]";
            tb_2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Hidden;
            label3.Content = "";
            tb_3.Visibility = Visibility.Hidden;

            label4.Visibility = Visibility.Hidden;
            label4.Content = "";
            tb_4.Visibility = Visibility.Hidden;

        }

        //Dreieck
        private void it_Dreieck_Selected(object sender, RoutedEventArgs e)
        {
            profilName.Content = it_Dreieck.Header;
            profilName.Visibility = Visibility.Visible;

            zeigeBild("Resources/img_Dreieck.jpg");

            lb_out1.Content = "Iy [mm^4]";
            lb_out2.Content = "Iz [mm^4]";

            lb_out1.Visibility = Visibility.Visible;
            tb_out1.Visibility = Visibility.Visible;

            lb_out2.Visibility = Visibility.Visible;
            tb_out2.Visibility = Visibility.Visible;

            label1.Visibility = Visibility.Visible;
            label1.Content = "h [mm]";
            tb_1.Visibility = Visibility.Visible;

            label2.Visibility = Visibility.Visible;
            label2.Content = "b [mm]";
            tb_2.Visibility = Visibility.Visible;

            label3.Visibility = Visibility.Hidden;
            label3.Content = "";
            tb_3.Visibility = Visibility.Hidden;

            label4.Visibility = Visibility.Hidden;
            label4.Content = "";
            tb_4.Visibility = Visibility.Hidden;

        }


    }
}
