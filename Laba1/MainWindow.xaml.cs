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
        public MainWindow()
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToInt32(tbA.Text); 
                double b = Convert.ToInt32(tbB.Text);
                double c = Convert.ToInt32(tbC.Text);
                if (a == 0)
                {
                    ErrorMessage();
                }
                else
                {
                    Discriminant(a, b, c);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage();
            }
        }

        private void Discriminant(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - (4 * a * c);
            if (d > 0)
            {
                Roots(a, b, d);
            }
            else if (d == 0)
            {
                Roots(a, b);
            }
            else
            {
                ShowResult();
            }
        }
        //Считает 2 корня
        private void Roots(double a, double b, double d)
        {
            double x1 = Math.Round((-b + Math.Sqrt(d)) / (2 * a), 2);
            double x2 = Math.Round((-b - Math.Sqrt(d)) / (2 * a), 2);
            ShowResult(x1, x2, d);
        }
        //Считает 1 корень
        private void Roots(double a, double b)
        {
            double x1 = Math.Round((-b)/(2 * a), 2);
            ShowResult(x1);
        }
        //ВЫводит результат с 2мя корнями
        private void ShowResult(double x1, double x2, double d)
        {
            MessageBox.Show("Первый корень равен " + x1 + " а второй корень равен " + x2);
        }
        //Выводит результат с 1м корнем
        private void ShowResult(double x1)
        {
            MessageBox.Show("Корень равен " + x1);
        }
        // Выводит результат при отсутствии корней
        private void ShowResult()
        {
            MessageBox.Show("Корней нет");
        }
        //Вывод при вводе некорректных данных , например буквы
        private void ErrorMessage()
        {
            MessageBox.Show("Некорректные данные :(");
        }
             
    }
}
