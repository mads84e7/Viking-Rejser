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
using Viking_Rejser.model;
using Viking_Rejser.vmodel;

namespace Viking_Rejser
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainPage();
        }

        private void mainPage_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainPage();
        }

        private void rejser_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new RejserPage();
        }

        private void Transportører_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Transpor();
        }
    }

}
