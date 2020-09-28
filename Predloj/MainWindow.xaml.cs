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

namespace Predloj
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

        private void No1_MouseEnter(object sender, MouseEventArgs e)
        {
            No1.Visibility = Visibility.Hidden;
            No2.Visibility = Visibility.Visible;
        }

        private void No2_MouseEnter(object sender, MouseEventArgs e)
        {
            No2.Visibility = Visibility.Hidden;
            No3.Visibility = Visibility.Visible;
        }

        private void No3_MouseEnter(object sender, MouseEventArgs e)
        {
            No3.Visibility = Visibility.Hidden;
            No4.Visibility = Visibility.Visible;
        }

        private void No4_MouseEnter(object sender, MouseEventArgs e)
        {
            No4.Visibility = Visibility.Hidden;
            No5.Visibility = Visibility.Visible;
        }

        private void No5_MouseEnter(object sender, MouseEventArgs e)
        {
            No5.Visibility = Visibility.Hidden;
            No6.Visibility = Visibility.Visible;
        }

        private void No6_MouseEnter(object sender, MouseEventArgs e)
        {
            No6.Visibility = Visibility.Hidden;
            No7.Visibility = Visibility.Visible;
        }

        private void No7_MouseEnter(object sender, MouseEventArgs e)
        {
            No7.Visibility = Visibility.Hidden;
            No8.Visibility = Visibility.Visible;
        }

        private void No8_MouseEnter(object sender, MouseEventArgs e)
        {
            No8.Visibility = Visibility.Hidden;
            No9.Visibility = Visibility.Visible;
        }

        private void No9_MouseEnter(object sender, MouseEventArgs e)
        {
            No9.Visibility = Visibility.Hidden;
            No10.Visibility = Visibility.Visible;
        }

        private void No10_MouseEnter(object sender, MouseEventArgs e)
        {
            No10.Visibility = Visibility.Hidden;
            Yes.Content = "Ну ладно, уговорил! )";
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            Vopros vopros = new Vopros();
            vopros.ShowDialog();
        }
    }
}
