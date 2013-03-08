using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicksInventorySearchTool
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec guitarSpecs)
        {
            Guitar guitar = new Guitar(guitarSpecs);
            guitar.SerialNumber = serialNumber;
            guitar.Price = price;

            this.guitars.Add(guitar);
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (var guitr in this.guitars)
            {
                if (guitr.Specs.Matches(searchSpec))
                    matchingGuitars.Add(guitr);
            }
            return matchingGuitars;
        }
    }
}
