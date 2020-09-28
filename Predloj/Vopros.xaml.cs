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
    /// Логика взаимодействия для Vopros.xaml
    /// </summary>
    public partial class Vopros : Window
    {
        int[] days = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
        int[] months = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] years = new int[] {1980, 1981, 1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

        public Vopros()
        {
            InitializeComponent();
            Combo();
        }

        void Combo()
        {
            Day.ItemsSource = days;
            Month.ItemsSource = months;
            Year.ItemsSource = years;
            Day.SelectedIndex = 0;
            Month.SelectedIndex = 0;
            Year.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Day.SelectedItem}, {Month.SelectedItem}, {Year.SelectedItem}");
            if (FirstName.Text == "Карина" & LastName.Text == "Павлова" & MiddleName.Text == "Андреевна" & Day.SelectedIndex == 17 & Month.SelectedIndex == 4 & Year.SelectedIndex == 16)
            {
                MessageBox.Show("true");
            }
            else if (FirstName.Text == "Ангелина" & LastName.Text == "Павлова" & MiddleName.Text == "Евгеньевна")
            {
                MessageBox.Show("Ангелина Евгеньевна, пожалуйста, передайте Карине, что это для неё )");
            }
            else if (FirstName.Text == "Татьяна" & LastName.Text == "Михнина" & MiddleName.Text == "Александровна")
            {
                MessageBox.Show("Мам, это для Карины, потом всё расскажу )");
            }
            else if (FirstName.Text == "Юрий" & LastName.Text == "Михнин" & MiddleName.Text == "Николаевич")
            {
                MessageBox.Show("Пап, я тут такое щас замучу, но это для Карины =Ъ");
            }
            else
            {
                MessageBox.Show("Извините, с такими Алексей Юрьевич не знаком, или не общается. Прощайте.");
            }
        }
    }
}
