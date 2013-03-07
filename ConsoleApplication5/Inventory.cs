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
            guitar.Builder = builder;
            guitar.Model = model;
            guitar.Type = type;
            guitar.BackWood = backWood;
            guitar.TopWood = topWood;

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

        public Guitar Search(Guitar guitar)
        {
            foreach (var guitr in guitars)
            {
                if (guitr.Builder == guitar.Builder
                    || guitr.Model.Equals(guitar.Model, StringComparison.OrdinalIgnoreCase)
                    || guitr.Type == guitar.Type
                    || guitr.BackWood == guitar.BackWood
                    || guitr.TopWood == guitar.TopWood)
                    return guitr;
            }
            return null;
        }
    }
}
