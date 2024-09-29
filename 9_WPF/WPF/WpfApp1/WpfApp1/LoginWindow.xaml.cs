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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txb_username.Text;
            string password = txb_password.Password;

            if(!(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password)))
            {
                if(username =="admin" && password == "admin")
                {
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Enter the correct username or password", "Login Failed", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Enter the above credentials", "Login Failed", MessageBoxButton.OK);
            }
        }
    }
}
