using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksInventorySearchTool
{
    public class Mandolin : Instrument
    {
        public MandolinSpec Specs { get; set; }

        public Mandolin(MandolinSpec specs)
        {
            this.Specs = specs;
        }
    }
}
