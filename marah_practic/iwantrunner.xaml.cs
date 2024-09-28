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
    /// Логика взаимодействия для iwantrunner.xaml
    /// </summary>
    public partial class iwantrunner : Window
    {
        public iwantrunner()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Show();
            this.Close();
        }

        private void newRunner_button_Click(object sender, RoutedEventArgs e)
        {
            newrunner newrunner = new newrunner();
            newrunner.Left = this.Left;
            newrunner.Top = this.Top;
            newrunner.Show();
            this.Close();
        }

        private void oldRunner_button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Left = this.Left;
            login.Top = this.Top;
            login.Show();
            this.Close();
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Left = this.Left;
            login.Top = this.Top;
            login.Show();
            this.Close();
        }
    }
}
