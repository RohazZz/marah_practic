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
    /// Логика взаимодействия для allCahrities.xaml
    /// </summary>
    public partial class allCahrities : Window
    {
        public allCahrities()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            DopInfo dopInfo = new DopInfo();
            dopInfo.Left = this.Left;
            dopInfo.Top = this.Top;
            dopInfo.Show();
            this.Close();
        }
    }
}
