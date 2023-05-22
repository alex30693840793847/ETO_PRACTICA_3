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

namespace Zadanie3
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
                int sum = 0;
                if (vod1 <= vod2 && vod1 <= vod3)
                    OTV.Text = $"{vod2 + vod3}";
                else if (vod2 <= vod1 && vod2 <= vod3)
                    OTV.Text = $"{vod1 + vod3}";
                else if (vod3 <= vod1 && vod3 <= vod2)
                    OTV.Text = $"{vod1 + vod2}";
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
