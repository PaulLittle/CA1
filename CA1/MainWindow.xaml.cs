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

namespace CA1._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Room> hotel = new ObservableCollection<Room>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                hotel.Add(new Room());
                System.Threading.Thread.Sleep(350);
            }
            lbxRooms.ItemsSource = hotel;
            upDateStats();
        }        
        
        private void upDateStats()
        {
            int noGuests = 0, beforeNoon = 0;
            foreach (var rm in hotel)
            {
                if (!String.IsNullOrEmpty(rm.Guest))
                {
                    noGuests++;
                    if (rm.CheckIn.Hour > 0 && rm.CheckIn.Hour < 12) beforeNoon++;
                }
            }

            tbkOccupancy.Text = String.Format("{0:P1}",(double) noGuests / hotel.Count);
            tbkBeforeNoon.Text = String.Format("{0:P1}",(double) beforeNoon / hotel.Count);
        }

        private void btnAddRoom_Click(object sender, RoutedEventArgs e)
        {
            hotel.Add(new Room());
            upDateStats();
        }
    }
}
