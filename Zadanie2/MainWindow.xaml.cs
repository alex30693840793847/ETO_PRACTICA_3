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

namespace Zadanie2
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
                int vod1 = Convert.ToInt32(VVOD1.Text);
                int vod2 = Convert.ToInt32(VVOD2.Text);
                int vod3 = Convert.ToInt32(VVOD3.Text);
                int polosh = 0;
                int otric = 0;

                if (vod1 > 0)
                    polosh++;
                else if (vod1 < 0)
                    otric++;
                if (vod2 > 0)
                    polosh++;
                else if (vod2 < 0)
                    otric++;
                if (vod3 > 0)
                    polosh++;
                else if (vod3 < 0)
                    otric++;

                OTV.Text = $"кол-во положительных числе: {polosh}" + $"\nкол-во отрицательных чисел: {otric}";
                
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
