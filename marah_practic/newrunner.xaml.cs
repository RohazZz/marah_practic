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
    /// Логика взаимодействия для newrunner.xaml
    /// </summary>
    public partial class newrunner : Window
    {
        public newrunner()
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

        private void registr_button_Click(object sender, RoutedEventArgs e)
        {
            registrationonma registrationonma = new registrationonma();
            registrationonma.Left = this.Left;
            registrationonma.Top = this.Top;
            registrationonma.Show();
            this.Close();
        }
    }
}
