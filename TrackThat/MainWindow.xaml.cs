using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TrackThat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.shipengine.com");
            client.DefaultRequestHeaders.Add("API-Key", "TEST_r5FAr8Bd0C87Y47f3AtqwqaO/FdLeQiGIXMpJJktmKE");
            //client.DefaultRequestHeaders.Accept.Add(
              // new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("/v1/tracking?carrier_code=ups&tracking_number=1Z46W9E10333593245").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync();
                string info = result.Result;
                ShipInfo shipInfo = JsonSerializer.Deserialize<ShipInfo>(info);
                /*
                var employees = response.Content.ReadAsAsync<IEnumerable<Employee>>().Result;
                grdEmployee.ItemsSource = employees;
                */
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}
