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

using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.ObjectModel;

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;


namespace StockServiceClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient httpClient;
        public MainWindow()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:43716/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            GetStock();
        }

        private async void GetStock()
        {
            var response = await httpClient.GetAsync("Activity14_2/stock");
            if (response.IsSuccessStatusCode)
            {
                var stockJSON = await response.Content.ReadAsStringAsync();                
                var stockArray =  JArray.Parse(stockJSON);
                ObservableCollection<Stock> stockCollection = new ObservableCollection<Stock>();
                foreach (JObject iS in stockArray)
                {
                    Stock s = new Stock();
                    s.StockID = iS.GetValue("StockItemID").ToString();
                    s.Name = iS.GetValue("StockItemName").ToString();
                    s.Price = Convert.ToDouble(iS.GetValue("UnitPrice").ToString());
                    s.SearchDetails = iS.GetValue("SearchDetails").ToString();

                    s.StockID = iS.ToString();
                    stockCollection.Add(s);

                }
                this.StockView.DataContext = stockCollection;
            }

        }
    }
}
