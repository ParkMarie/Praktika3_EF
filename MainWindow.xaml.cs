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


namespace Praktika3_EF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookStoreEntities context = new BookStoreEntities();
        public MainWindow()
        {
            InitializeComponent();
            OrdersFullDataGrid.ItemsSource = context.OrderInfo.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OrdersFullDataGrid.Columns[0].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[1].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[2].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[6].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[7].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[8].Visibility = Visibility.Collapsed;
            OrdersFullDataGrid.Columns[11].Visibility = Visibility.Collapsed;
        }

       


    }


    
}
