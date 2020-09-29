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

namespace Predloj
{
    /// <summary>
    /// Логика взаимодействия для SamoPred.xaml
    /// </summary>
    public partial class SamoPred : Window
    {
        public SamoPred()
        {
            InitializeComponent();
        }

        private void YES_Click(object sender, RoutedEventArgs e)
        {
            Predlojenie pred = new Predlojenie();
            pred.Show();
            this.Close();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Hidden;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (b1.Visibility == Visibility.Hidden)
            {
                b2.Visibility = Visibility.Hidden;
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (b2.Visibility == Visibility.Hidden)
            {
                b3.Visibility = Visibility.Hidden;
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (b3.Visibility == Visibility.Hidden)
            {
                b4.Visibility = Visibility.Hidden;
            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (b4.Visibility == Visibility.Hidden)
            {
                b5.Visibility = Visibility.Hidden;
            }
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (b5.Visibility == Visibility.Hidden)
            {
                b6.Visibility = Visibility.Hidden;
            }
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (b6.Visibility == Visibility.Hidden)
            {
                b7.Visibility = Visibility.Hidden;
            }
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (b7.Visibility == Visibility.Hidden)
            {
                b8.Visibility = Visibility.Hidden;
            }
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (b8.Visibility == Visibility.Hidden)
            {
                b9.Visibility = Visibility.Hidden;
            }
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {
            if (b9.Visibility == Visibility.Hidden)
            {
                b10.Visibility = Visibility.Hidden;
            }
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            if (b10.Visibility == Visibility.Hidden)
            {
                b11.Visibility = Visibility.Hidden;
                YES.Visibility = Visibility.Visible;
                NO.Visibility = Visibility.Visible;
            }
        }
    }
}
