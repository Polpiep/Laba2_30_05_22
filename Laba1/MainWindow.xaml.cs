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

namespace Laba1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public MainWindow()
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tbA.Text);
                int b = Convert.ToInt32(tbB.Text);
                int c = Convert.ToInt32(tbC.Text);
                Discriminant(a, b, c);
            }
            catch (Exception ex)
            {
                ErrorMessage();
            }
        }

        private void Discriminant(int a, int b, int c)
        {
            double d = Math.Pow(b, 2) - (4 * a * c);
            if (d >= 0)
            {
                Roots(a, b, d);
            }
            else
            {
                ShowResult();
            }
        }

        private void Roots(int a, int b, double d)
        {
            double x1 = Math.Round((-b + Math.Sqrt(d)) / (2 * a), 2);
            double x2 = Math.Round((-b - Math.Sqrt(d)) / (2 * a), 2);
            ShowResult(x1, x2, d);
        }

        private void ShowResult(double x1, double x2, double d)
        {
            if (d > 0)
            {
                MessageBox.Show("Первый корень равен " + x1 + " а второй корень равен " + x2);
            }
            else if (d == 0)
            {
                MessageBox.Show("Корень равен " + x1);
            }

        }
        private void ShowResult()
        {
            MessageBox.Show("Корней нет");
        }

        private void ErrorMessage()
        {
            MessageBox.Show("Некорректные данные(");
        }
             
    }
}
