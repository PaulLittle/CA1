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

namespace CA1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const short NO_ROOMS = 20;

        private ObservableCollection<Room> _hotel = new ObservableCollection<Room>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < NO_ROOMS; i++)
            {
                _hotel.Add(new Room(i+1));
                System.Threading.Thread.Sleep(350);
            }
            lbxRooms.ItemsSource = _hotel;
            updateStats();
        }

        private void updateStats()
        {
            int noGuests = 0, noBeforeNoon = 0;
            foreach (var rm in _hotel)
            {
                if (!String.IsNullOrEmpty(rm.Guest))
                {
                    noGuests++;
                    if (rm.CheckIn.Hour > 0 && rm.CheckIn.Hour < 12) noBeforeNoon++;
                }
            }
            tbkOccupancy.Text = String.Format("{0:P1}", (double)noGuests / _hotel.Count);
            tbkBeforeNoon.Text = String.Format("{0:P1}", (double)noBeforeNoon / _hotel.Count);
        }

        private void btnAddRoom_Click(object sender, RoutedEventArgs e)
        {
            _hotel.Add(new Room(_hotel.Count+1));
            updateStats();
        }
    }
}
