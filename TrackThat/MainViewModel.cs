using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Windows;

namespace TrackThat
{
    public class MainViewModel
    {
        private string filename = @"..\..\TrackingNums.txt";
        private HttpClient httpClient { get; }
        private List<Shipment> shipments { get; set; }
        public ObservableCollection<ShipInfo> ShipInfoList { get; set; }

        public MainViewModel(HttpClient hc)
        {
            httpClient = hc;
            LoadFile();
        }

        public void FetchData()
        {
            if (ShipInfoList == null) ShipInfoList = new ObservableCollection<ShipInfo>();
            foreach (Shipment s in shipments)
            {
                AddShipment(s);
            }
        }

        public void LoadFile()
        {
            if (shipments == null) shipments = new List<Shipment>();
            if (File.Exists(filename))
            {
                try
                {
                    // Open the text file using a stream reader.
                    using (var sr = new StreamReader(filename))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] shipData = sr.ReadLine().Split(',');
                            Shipment s = new Shipment(shipData[0].Trim(), shipData[1].Trim());
                            shipments.Add(s);
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
            }

        }

        public bool AddShipment(Shipment s)
        {
            ShipInfo shipInfo = TrackPackage(s);
            if (shipInfo == null) return false;
            else
            {
                ShipInfoList.Add(shipInfo);
                return true;
            }
        }

        public ShipInfo TrackPackage(Shipment s)
        {
            HttpResponseMessage response = httpClient.GetAsync($"/v1/tracking?carrier_code={s.Courier}&tracking_number={s.TrackingNo}").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync();
                string info = result.Result;
                try
                {
                    ShipInfo shipInfo = JsonSerializer.Deserialize<ShipInfo>(info);
                    shipInfo.SetCarrier(s.Courier);
                    return shipInfo;
                }
                catch (Exception e) { MessageBox.Show($"Error: {e.Message}"); }
            }
            return null;
        }
    }
}
