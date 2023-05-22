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

namespace Zadanie7
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
                int ch = Convert.ToInt32(CHICLO.Text);
                if (ch >= 1 && ch <= 999)
                {
                    if (ch < 10)
                    {
                        MessageBox.Show("однозначное число");
                    }
                    else if (ch < 100)
                    {
                        if(ch % 2 == 0)
                        {
                            MessageBox.Show("четное двузначное число");
                        }
                        else 
                        {
                            MessageBox.Show("нечетное двузначное число");
                        }
                    }
                    else
                    {
                        if (ch % 2 == 0)
                        {
                            MessageBox.Show("четное трехзначное число");
                        }
                        else
                        {
                            MessageBox.Show("нечетное трехзначное число");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Число должно быть в диапазоне от 1 до 999");
                }
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
