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
    /// Логика взаимодействия для runnerProfileRedact.xaml
    /// </summary>
    public partial class runnerProfileRedact : Window
    {
        public runnerProfileRedact()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            //Здесь редактирование и сохранение в базу, проверка еще сначало кста
            menurunner menurunner = new menurunner();
            menurunner.Left = this.Left;
            menurunner.Top = this.Top;
            menurunner.Show();
            this.Close();
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            menurunner menurunner = new menurunner();
            menurunner.Left = this.Left;
            menurunner.Top = this.Top;
            menurunner.Show();
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
    }
}
