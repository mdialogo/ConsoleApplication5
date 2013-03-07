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

        public void AddGuitar(string serialNumber
            , double price
            , CommonLib.Builder builder
            , string model
            , CommonLib.Type type
            , CommonLib.Wood backWood
            , CommonLib.Wood topWood)
        {
            Guitar guitar = new Guitar();

            guitar.SerialNumber = serialNumber;
            guitar.Price = price;
            guitar.Specs.Builder = builder;
            guitar.Model = model;
            guitar.Specs.Type = type;
            guitar.Specs.BackWood = backWood;
            guitar.Specs.TopWood = topWood;

            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber))
                    return guitar;
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec guitarSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (var guitr in guitars)
            {
                if (guitr.Specs.Builder == guitarSpec.Builder
                    || guitr.Model.Equals(guitarSpec.Model, StringComparison.OrdinalIgnoreCase)
                    || guitr.Specs.Type == guitarSpec.Type
                    || guitr.Specs.BackWood == guitarSpec.BackWood
                    || guitr.Specs.TopWood == guitarSpec.TopWood)
                    matchingGuitars.Add(guitr);
            }
            return matchingGuitars;
        }
    }
}
