using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TrackThat
{
    public delegate bool SetKey(string key);
    //public delegate void FetchData();

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string _accessKey;
        private static HttpClient client;
        private static MainWindow window;
        private static MainViewModel viewModel;
        //private FetchData fetch;

        /// <summary>
        /// Resets access key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool SetAccessKey(string key)
        {
            client.DefaultRequestHeaders.Add("API-Key", key);
            HttpResponseMessage response = client.GetAsync("v1/tags").Result;
            if (response.IsSuccessStatusCode)
            {
                _accessKey = key;
                viewModel.FetchData();
                window = new MainWindow();
                window.DataContext = viewModel;
                window.uxShipmentList.ItemsSource = viewModel.ShipInfoList;
                window.Show();
                return true;
            }
            else
            {
                client.DefaultRequestHeaders.Remove("API-Key");
                _accessKey = "";
                return false;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api.shipengine.com");
            viewModel = new MainViewModel(client);
            //this.fetch = viewModel.FetchData;
            
            AccessKeyWindow access = new AccessKeyWindow(SetAccessKey);
            access.Show();
        }

        
    


    }
}
