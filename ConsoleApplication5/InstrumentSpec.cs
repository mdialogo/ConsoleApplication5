using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksInventorySearchTool
{
    public abstract class InstrumentSpec
    {
        public CommonLib.Builder Builder { get; set; }
        public string Model { get; set; }
        public CommonLib.Type Type { get; set; }
        public CommonLib.Wood BackWood { get; set; }
        public CommonLib.Wood TopWood { get; set; }
        public double Weight { get; set; }
        public CommonLib.Status Status { get; set; }
        public string Freebie { get; set; }
    }
}
