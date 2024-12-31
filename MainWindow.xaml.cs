using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionReservation
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string usernameInput = username.Text; // TextBox for username
            string passwordInput = password.Password; // PasswordBox for password

            // Example validation
            if (usernameInput == "admin" && passwordInput == "123") // Replace with actual validation logic
            {
                // Open the new window (e.g., Home)
                Home HM = new Home();
                HM.Show();
                this.Close();
            }
            else
            {
                // Show an error message
                MessageBox.Show("Invalid username or password. Please try again.",
                                "Login Failed",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }
    }
}