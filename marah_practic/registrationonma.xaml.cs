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
    /// Логика взаимодействия для registrationonma.xaml
    /// </summary>
    public partial class registrationonma : Window
    {
        public registrationonma()
        {
            InitializeComponent();
        }

        private void registr_button_Click(object sender, RoutedEventArgs e)
        {
            endregistration endregistration = new endregistration();
            endregistration.Top = this.Top;
            endregistration.Left = this.Left;
            endregistration.Show();
            this.Close();
        }

        private void logout_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Show();
            this.Close();
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            menurunner menurunner = new menurunner();
            menurunner.Top = this.Top;
            menurunner.Left = this.Left;
            menurunner.Show();
            this.Close();
        }
    }
}
