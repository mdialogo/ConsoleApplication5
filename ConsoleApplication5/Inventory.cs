using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
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

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in this.guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber))
                    return guitar;
            }
            return null;
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
