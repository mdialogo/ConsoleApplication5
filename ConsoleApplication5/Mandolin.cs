using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksInventorySearchTool
{
    public class Mandolin : Instrument
    {
        public GuitarSpec Specs { get; set; }

        public Mandolin(GuitarSpec specs)
        {
            this.Specs = specs;
        }
    }
}
