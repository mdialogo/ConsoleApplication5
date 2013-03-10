using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksInventorySearchTool
{
    public class GuitarSpec
    {
        public CommonLib.Builder Builder { get; set; }
        public string Model { get; set; }
        public CommonLib.Type Type { get; set; }
        public CommonLib.Wood BackWood { get; set; }
        public CommonLib.Wood TopWood { get; set; }
        public int NumberOfStrings { get; set; }
        public double Weight { get; set; }
        public CommonLib.Status Status { get; set; }
        public string Freebie { get; set; }

        public bool Matches(GuitarSpec searchSpecs)
        {
            return this.Builder == searchSpecs.Builder
                    || this.Model.Equals(searchSpecs.Model, StringComparison.OrdinalIgnoreCase)
                    || this.Type == searchSpecs.Type
                    || this.BackWood == searchSpecs.BackWood
                    || this.TopWood == searchSpecs.TopWood
                    || this.NumberOfStrings == searchSpecs.NumberOfStrings
                    || this.Weight == searchSpecs.Weight
                    || this.Status == searchSpecs.Status
                    || this.Freebie.IndexOf(searchSpecs.Freebie,StringComparison.OrdinalIgnoreCase) >=0 ;
        }
    }
}
