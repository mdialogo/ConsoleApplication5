using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksInventorySearchTool
{
    public abstract class Instrument
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
    }
}
