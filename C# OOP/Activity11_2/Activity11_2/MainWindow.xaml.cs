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

namespace Activity11_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        WideWorldImportersDataSet _dsWWI;
        WideWorldImportersDataSetTableAdapters.PeopleTableAdapter _taPeople;
        WideWorldImportersDataSet.PeopleDataTable _dtPeople;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {
            _dsWWI = new WideWorldImportersDataSet();
            _taPeople = new WideWorldImportersDataSetTableAdapters.PeopleTableAdapter();
            _dtPeople = new WideWorldImportersDataSet.PeopleDataTable();
            _taPeople.Fill(_dtPeople);
            dgPeople.DataContext = _dtPeople;
        }

        private void btnSaveData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _taPeople.Update(_dtPeople);
                MessageBox.Show("Data Saved.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save data!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
