using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class CommonLib
    {
        public enum Type
        {
            NONE,
            ACOUSTIC, 
            ELECTRIC
        }

        public enum Builder
        {
            NONE,
            FENDER,
            MARTIN,
            GIBSON,
            COLLINGS,
            OLSON,
            RYAN,
            PRS,
            ANY
        }

        public enum Wood
        {
            NONE,
            INDIAN_ROSEWOOD,
            BRAZILLIAN_ROSEWOOD,
            MAHOGANY,
            MAPLE,
            COOBOLO,
            CEDAR,
            ADIRONDACK,
            ALDER,
            SITKA
        }
    }
}
