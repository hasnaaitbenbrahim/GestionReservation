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
using System.Windows.Shapes;

namespace GestionReservation
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
           
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new HomeControl();
        }

        private void dash_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new DashboardControl();
        }

        private void client_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ClientControl();
        }

        private void room_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new RoomControl();
        }

        private void reservation_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ReservationControl();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
                        MessageBoxResult result = MessageBox.Show(
                  "Are you sure you want to log out?", // Message
                  "Logout Confirmation",              // Title
                  MessageBoxButton.YesNo,             // Buttons
                  MessageBoxImage.Question           // Icon
              );
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();  
            }
            else
            {
                return;
            }
        }
    }
}
