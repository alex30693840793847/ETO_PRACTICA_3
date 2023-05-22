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

namespace Zadanie5
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
                double x = Convert.ToInt32(TBX.Text);
                double y = Convert.ToInt32(TBY.Text);
                if ((y < x) && (((x * x) + (y * y)) < 144))
                {
                    MessageBox.Show("Точка попала в заштрихованную область");
                }
                else if ((y == x) && (((x * x) + (y * y)) == 144))
                {
                    MessageBox.Show("Точка на границе заштрихованной области");
                }
                else
                {
                    MessageBox.Show("Точка не попала в заштрихованную область");
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
        
    

