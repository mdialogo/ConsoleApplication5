using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RicksInventorySearchTool
{
    class Program
    {
        static Inventory inventory;

        static void Main(string[] args)
        {
            inventory = new Inventory();

            InitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec();
            //whatErinLikes.Model = "stratocastor";
            //whatErinLikes.Builder = CommonLib.Builder.FENDER;
            //whatErinLikes.Type = CommonLib.Type.ACOUSTIC;
            //whatErinLikes.Weight = 1.0;
            whatErinLikes.Status = CommonLib.Status.BRANDNEW;

            List<Guitar> matchingGuitar = inventory.Search(whatErinLikes);
            if (matchingGuitar != null)
            {
                Console.WriteLine("Erin, you might like this guitar(s):");
                foreach (var guitar in matchingGuitar)
                {
                    Console.WriteLine("\tWe have a {0} {1} {2} {8} guitar:\n\t {3} back and sides {4} {6} strings {7} kgs.\n\tYou can have it for ${5}!\n"
                        , guitar.Specs.Builder.ToString()
                        , guitar.Specs.Model
                        , guitar.Specs.Type.ToString()
                        , guitar.Specs.BackWood.ToString()
                        , guitar.Specs.TopWood.ToString()
                        , guitar.Price
                        , guitar.Specs.NumberOfStrings
                        , String.Format("{0:N2}", guitar.Specs.Weight)
                        , guitar.Specs.Status.ToString());
                }
            }
            else
            {
                Console.WriteLine("Sorry Erin, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            AddNewGuitar("V95693"
                , 1499.95
                , CommonLib.Builder.FENDER
                , "Stratocastor"
                , CommonLib.Type.ELECTRIC
                , CommonLib.Wood.ALDER
                , CommonLib.Wood.ALDER
                , 6
                , 1.5
                , CommonLib.Status.BRANDNEW);

            AddNewGuitar("V9512"
                , 1599.95
                , CommonLib.Builder.FENDER
                , "Stratocastor"
                , CommonLib.Type.ELECTRIC
                , CommonLib.Wood.ALDER
                , CommonLib.Wood.ALDER
                , 6
                , 1.5
                , CommonLib.Status.SECONDHAND);

            AddNewGuitar("B9510"
                , 1099.95
                , CommonLib.Builder.FENDER
                , "Sentiment"
                , CommonLib.Type.ACOUSTIC
                , CommonLib.Wood.CEDAR
                , CommonLib.Wood.CEDAR
                , 6
                , 1.0
                , CommonLib.Status.REFURBISHED);
        }

        private static void AddNewGuitar(string serialNumber
            , double price
            , CommonLib.Builder builder
            , string Model
            , CommonLib.Type type
            , CommonLib.Wood backWood
            , CommonLib.Wood topWood
            , int numStrings
            , double weight
            , CommonLib.Status status)
        {
            GuitarSpec guitarSpecs = new GuitarSpec();
            guitarSpecs.Builder = builder;
            guitarSpecs.Model = Model;
            guitarSpecs.Type = type;
            guitarSpecs.BackWood = backWood;
            guitarSpecs.TopWood = topWood;
            guitarSpecs.NumberOfStrings = numStrings;
            guitarSpecs.Weight = weight;
            guitarSpecs.Status = status;

            inventory.AddGuitar(serialNumber
                , price
                , guitarSpecs);
        }

    }
}
