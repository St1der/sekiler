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

namespace sekiler
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            i14pro i14=new i14pro();
            i14.n1.Content = "ipone 14";
            i14.n2.Content = "ram6";
            i14.n3.Content = "ios15";
            i14.n4.Content = "2000";
            i14.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            i14pro i14 = new i14pro();
            i14.n1.Content = " s23";
            i14.n2.Content = "ram12";
            i14.n3.Content = "aous22";
            i14.n4.Content = "2000";
            i14.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            i14pro i14 = new i14pro();
            i14.n1.Content = " sony 1";
            i14.n2.Content = "ram12";
            i14.n3.Content = "aous22";
            i14.n4.Content = "5000";
            i14.Show();
        }
    }
}
