using System;
using System.ComponentModel;

namespace TrackThat
{
    public class ShipInfo:INotifyPropertyChanged
    {
        public string tracking_number { get; set; }
        public string status_code { get; set; }
        public string status_description { get; set; }
        public string carrier_status_code { get; set; }
        public string carrier_status_description { get; set; }
        public DateTime ship_date { get; set; }
        public object estimated_delivery_date { get; set; }
        public DateTime actual_delivery_date { get; set; }
        public object exception_description { get; set; }
        public Event[] events { get; set; }

        public override string ToString()
        {
            return $"{tracking_number} status: {status_description} estimated delivery: {estimated_delivery_date}";
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

