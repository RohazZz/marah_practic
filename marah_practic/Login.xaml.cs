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

namespace marah_practic
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            DebugPage.Visibility = Visibility.Hidden;
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Show();
            this.Close();
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Show();
            this.Close();
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            DebugPage.Visibility = Visibility.Visible;
        }

        private void runner_button_Click(object sender, RoutedEventArgs e)
        {
            menurunner menurunner = new menurunner();
            menurunner.Top = this.Top;
            menurunner.Left = this.Left;
            menurunner.Show();
            this.Close();
        }

        private void coordinator_button_Click(object sender, RoutedEventArgs e)
        {
            menukoordinator menukoordinator = new menukoordinator();
            menukoordinator.Top = this.Top;
            menukoordinator.Left = this.Left;  
            menukoordinator.Show();
            this.Close();
        }

        private void admin_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void closeDebug_button_Click(object sender, RoutedEventArgs e)
        {
            DebugPage.Visibility = Visibility.Hidden;
        }
    }
}
