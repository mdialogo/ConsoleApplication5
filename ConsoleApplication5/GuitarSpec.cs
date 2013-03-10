using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksInventorySearchTool
{
    public class GuitarSpec : InstrumentSpec
    {
        public int NumberOfStrings { get; set; }
        
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
