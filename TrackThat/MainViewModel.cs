using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackThat
{
    public class MainViewModel
    {
        string filename = @"C:\Users\18284\source\repos\TrackThat\TrackThat\TrackingNums.txt";
        List<Shipment> shipments;

        public MainViewModel()
        {
            LoadShipments();
        }

        public void LoadShipments()
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
                            Shipment s = new Shipment(shipData[0], shipData[1]);
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
        

    }
}
