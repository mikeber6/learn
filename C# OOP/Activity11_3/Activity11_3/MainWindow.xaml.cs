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

namespace Activity11_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            WideWorldImportersDataSet dsWWI = new WideWorldImportersDataSet();

            WideWorldImportersDataSetTableAdapters.OrdersTableAdapter taOrders = new WideWorldImportersDataSetTableAdapters.OrdersTableAdapter();
            WideWorldImportersDataSet.OrdersDataTable dtOrders = new WideWorldImportersDataSet.OrdersDataTable();
            taOrders.Fill(dtOrders);

            WideWorldImportersDataSetTableAdapters.CustomersTableAdapter taCustomers = new WideWorldImportersDataSetTableAdapters.CustomersTableAdapter();
            WideWorldImportersDataSet.CustomersDataTable dtCustomer = new WideWorldImportersDataSet.CustomersDataTable();
            taCustomers.Fill(dtCustomer);

            this.CustomerList.DataContext = dtCustomer;
            this.OrderGrid.DataContext = dtOrders;
        }
    }

       
}
