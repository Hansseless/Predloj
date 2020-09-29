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
    /// Логика взаимодействия для Predlojenie.xaml
    /// </summary>
    public partial class Predlojenie : Window
    {
        public Predlojenie()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Посмотри на меня, родная!", "");
        }

        private void NO_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ты уверена?","");
        }
    }
}
