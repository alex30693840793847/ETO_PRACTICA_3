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
using static System.Math;

namespace Zadanie4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToInt32(TBA.Text);
                double b = Convert.ToInt32(TBB.Text);
                double x = Convert.ToInt32(TBX.Text);
                double y = 0;
                if (x > PI)
                {
                    y = 1 - Exp(-a * x) * Sin(a * x + b);
                }
                else if (x >= -PI && x <= PI)
                {
                    y = 1 - Exp(-a * x) * (a * x + b);
                }
                else
                {
                    y = 1 - (Exp(-a * x) + Exp(-b * x));
                }
                OTV.Text = $"y = {y}";
            }

            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
