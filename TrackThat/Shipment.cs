﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackThat
{
    public struct Shipment
    {
        public string Courier { get; }
        public string TrackingNo { get; }

        public Shipment(string c, string t)
        {
            Courier = c;
            TrackingNo = t;
        }
    }
}
