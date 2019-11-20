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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Ende_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_Rechne_Click(object sender, RoutedEventArgs e)
        {
            tb_b.Text = "asd";
        }

        private void funk_checkIfNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void tb_h(object sender, TextChangedEventArgs e)
        {

        }

        private void it_Rechteckprofil_Selected(object sender, RoutedEventArgs e)
        {
            // img_Actual.Visibility = Visibility.Hidden;

            img.Source = new BitmapImage(new Uri("Resources/img_IProfil.jpg"));

        }
    }
}
