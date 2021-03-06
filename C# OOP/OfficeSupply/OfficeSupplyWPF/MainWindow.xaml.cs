﻿using System;
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

using System.Data;
using OfficeSupplyBLL;
using System.Collections.ObjectModel;

namespace OfficeSupplyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet _dsProdCat;
        Employee _employee;
        Order _order;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProductCatalog prodCat = new ProductCatalog();
            _dsProdCat = prodCat.GetProductInfo();
            this.DataContext = _dsProdCat.Tables["Category"];
            
            _order = new Order();
            _employee = new Employee();
            this.orderListView.ItemsSource = _order.OrderItemList;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginDialog dlg = new LoginDialog();
            dlg.Owner = this;
            dlg.ShowDialog();

            if(dlg.DialogResult == true)
            {
                _employee.LoginName = dlg.nameTextBox.Text;
                _employee.Password = dlg.passwordTextBox.Password;

                if (_employee.LogIn())
                {
                    this.statusTextBlock.Text = "You are logged in as employee number " + _employee.EmployeeID.ToString();
                }
                else
                {
                    MessageBox.Show("You could not be verified.  Please try again.");
                }
            }

        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            OrderItemDialog orderItemDialog = new OrderItemDialog();

            DataRowView selectedRow = (DataRowView)this.ProductsDataGrid.SelectedItems[0];

            orderItemDialog.productIdTextBox.Text = selectedRow.Row.ItemArray[0].ToString();
            orderItemDialog.unitPriceTextBox.Text = selectedRow.Row.ItemArray[4].ToString();
            orderItemDialog.Owner = this;
            orderItemDialog.ShowDialog();

            if(orderItemDialog.DialogResult == true)
            {
                string productId = orderItemDialog.productIdTextBox.Text;
                double unitPrice = Convert.ToDouble(orderItemDialog.unitPriceTextBox.Text);
                int quantity = Convert.ToInt32(orderItemDialog.quantityTextBox.Text);
                _order.AddItem(new OrderItem(productId, unitPrice, quantity));
            }

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.orderListView.SelectedItem != null)
            {
                var selectedOrderItem = this.orderListView.SelectedItem as OrderItem;
                _order.RemoveItem(selectedOrderItem.ProdID);
            }
        }

        private void placeOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if(_employee.LoggedIn)
            {
                int orderID = _order.PlaceOrder(_employee.EmployeeID);
                MessageBox.Show("Your order has been placed.  Your order id is " + orderID.ToString());
            }
            else
            {
                MessageBox.Show("You must be logged in to place an order.");
            }
        }
    }
}
