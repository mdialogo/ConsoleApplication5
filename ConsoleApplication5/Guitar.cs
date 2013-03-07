using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Guitar
    {
        public Guitar() {
        }
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public CommonLib.Builder Builder { get; set; }
        public string Model { get; set; }
        public CommonLib.Type Type { get; set; }
        public CommonLib.Wood BackWood { get; set; }
        public CommonLib.Wood TopWood { get; set; }

    }
}
