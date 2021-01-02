using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackThat
{
    struct Shipment
    {
        public string Courier { get; }
        public string TrackingNo;

        public Shipment(string c, string t)
        {
            Courier = c;
            TrackingNo = t;
        }
    }
}
