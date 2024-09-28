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
    /// Логика взаимодействия для sponsor.xaml
    /// </summary>
    public partial class sponsor : Window
    {
        public sponsor()
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

        private void pay_button_Click(object sender, RoutedEventArgs e)
        {
            thanksSponsor thanksSponsor = new thanksSponsor();
            thanksSponsor.Left = this.Left;
            thanksSponsor.Top = this.Top;
            thanksSponsor.Show();
            this.Close();
        }
    }
}
