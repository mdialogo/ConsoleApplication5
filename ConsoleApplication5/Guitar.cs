﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksInventorySearchTool
{
    public class Guitar : Instrument
    {
        public GuitarSpec Specs { get; set; }

        public Guitar(GuitarSpec guitarSpecs)
        {
            Specs = guitarSpecs;
        }
    }
}
