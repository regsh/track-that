using System;

namespace TrackThat
{
    public class Event
    {
        public DateTime occurred_at { get; set; }
        public DateTime carrier_occurred_at { get; set; }
        public string description { get; set; }
        public string city_locality { get; set; }
        public string state_province { get; set; }
        public string postal_code { get; set; }
        public string country_code { get; set; }
        public object company_name { get; set; }
        public string signer { get; set; }
        public string event_code { get; set; }
        public float? latitude { get; set; }
        public float? longitude { get; set; }
    }
}
