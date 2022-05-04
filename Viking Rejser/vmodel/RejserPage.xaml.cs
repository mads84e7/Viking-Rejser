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
    /// Interaction logic for RejserPage.xaml
    /// </summary>
    public partial class RejserPage : Page
    {
        Viking_Rejser1Entities1 db = new Viking_Rejser1Entities1();
        public RejserPage()
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
        private void rejser_lt_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        void InitializeDataGrid()
        {
            ObservableCollection<Rejsearrangement> orders_list = new ObservableCollection<Rejsearrangement>(db.Rejsearrangement.ToList());
            rejser_lt.ItemsSource = orders_list;
        }

        private void Opter_rejse_Click(object sender, RoutedEventArgs e)
        {
            if (inputTitle.Text != "" && inputTown.Text != "" && inputStart_date.Text != "" && inputEnd_date.Text != "" && inputPrice.Text != "" && inputMax_number.Text != "" && inputDescription.Text != "")
            {
                Rejsearrangement rejser = new Rejsearrangement
                {
                    Title = inputTitle.Text.Trim(),
                    Town = inputTown.Text.Trim(),
                    Start_date = inputStart_date.Text.Trim(),
                    End_date = inputEnd_date.Text.Trim(),
                    Price_per_participant = inputPrice.Text.Trim(),
                    Max_participants = inputMax_number.Text.Trim(),
                    Description = inputDescription.Text.Trim()
                };
                db.Rejsearrangement.Add(rejser);
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
