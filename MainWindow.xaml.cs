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

namespace ThirdTimesTheCharm
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
        private int count = 0;
        private void btnTeller_Click(object sender, RoutedEventArgs e)
        {
            count++;
            lblTeller.Content = count.ToString();
        }

        private void btnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            lblHelloWorld.Content = "Hello World!";
        }
    }
}
