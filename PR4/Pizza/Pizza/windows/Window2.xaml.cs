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

namespace Pizza.windows
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }


        private void btOpl_Click_1(object sender, RoutedEventArgs e)
        {
            tcMenu.Visibility = Visibility.Hidden;
            tbOplata.Visibility = Visibility.Visible;
        }
        int summ;

        private void bt4Cheese_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Пицца 4 сыра\t\t\t499руб.");
            summ += 499;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Пицца Пеперони\t\t599руб.");
            summ += 599;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btDiablo_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Пицца Диабло\t\t\t699руб.");
            summ += 699;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btAnanas_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Пицца Гавайская\t\t599руб.");
            summ += 599;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btFanta_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Fanta\t\t\t\t69руб.");
            summ += 69;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btKola_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Coca-Cola\t\t\t69руб.");
            summ += 69;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btSprite_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Sprite\t\t\t\t69руб.");
            summ += 69;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btMors_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Клюквенный морс\t\t39руб.");
            summ += 39;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btDer_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Картофель по-деревенски\t79руб.");
            summ += 79;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btFri_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Картофель фри\t\t\t79руб.");
            summ += 79;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btLuk_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Луковые кольца\t\t99руб.");
            summ += 99;
            tbItog.Text = "Итог:" + summ.ToString();
        }

        private void btSir_Click(object sender, RoutedEventArgs e)
        {
            tbOplata.AppendText(Environment.NewLine + "Сырные палочки\t\t119руб.");
            summ += 119;
            tbItog.Text = "Итог:" + summ.ToString();
        }
       
    }
}
