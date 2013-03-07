using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public string Model { get; set; }
        public GuitarSpec Specs { get; set; }

        public Guitar()
        {
            Specs = new GuitarSpec();
        }
    }
}
