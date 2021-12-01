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

namespace Practice_10
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

        List<int> array = new List<int>(10);

        private void FindQuantity_Click(object sender, RoutedEventArgs e)
        {
           evenNumbers.Text = array.Where(x => x % 2 == 0).Count().ToString();
           oddNumbers.Text = array.Where(x => x % 2 != 0).Count().ToString();
        }

        private void FillList_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array.Add(random.Next(-100, 100));
                allElements.Items.Add(array[i]);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            evenNumbers.Clear();
            oddNumbers.Clear();
            allElements.Items.Clear();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Золотарев М. А.\n Группа: ИСП-34\n Вариант №13", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
