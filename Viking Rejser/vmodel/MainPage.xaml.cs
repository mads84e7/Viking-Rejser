using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Viking_Rejser.vmodel
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        Viking_Rejser1Entities1 db = new Viking_Rejser1Entities1();
        public MainPage()
        {
            InitializeComponent();

            InitializeDataGrid();
        }

        void Clear()
        {

        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Clear();
        }
        // help from William
        private void kunder_lt_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        void InitializeDataGrid()
        {
            ObservableCollection<Kunder> orders_list = new ObservableCollection<Kunder>(db.Kunder.ToList());
            kunder_lt.ItemsSource = orders_list;
        }


        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (inputname.Text != "" && inputaddress.Text != "" && inputtelephone.Text != "")
            {
                Kunder kunder = new Kunder
                {
                    Name = inputname.Text.Trim(),
                    Address = inputaddress.Text.Trim(),
                    Telephone = inputtelephone.Text.Trim()
                };
                db.Kunder.Add(kunder);
                db.SaveChanges();

                System.Windows.MessageBox.Show("Success");
                Clear();
            }

            else
            {
                Clear();
                System.Windows.MessageBox.Show("Fejl");
            }

        }
        
    }

}
