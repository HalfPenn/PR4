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

namespace Pizza
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btZakaz_Click(object sender, RoutedEventArgs e)
        {
            bord.Visibility = Visibility.Visible;
            windows.Window1 f = new windows.Window1();
            f.ShowDialog();
            this.Hide();

            windows.Window2 c = new windows.Window2();
            c.Show();
        }
    }
}
