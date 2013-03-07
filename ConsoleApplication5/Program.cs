using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec();
            //whatErinLikes.Model = "stratocastor";
            whatErinLikes.Builder = CommonLib.Builder.FENDER;
            //whatErinLikes.Type = CommonLib.Type.ACOUSTIC;

            List<Guitar> matchingGuitar = inventory.Search(whatErinLikes);
            if (matchingGuitar != null)
            {
                Console.WriteLine("Erin, you might like this guitar(s):");
                foreach (var guitar in matchingGuitar)
                {
                    Console.WriteLine("\tWe have a {0} {1} guitar:\n\t\t {3} back and sides {4}\n\tYou can have it for {5}"
                        , guitar.Specs.Builder.ToString()
                        , guitar.Model
                        , guitar.Specs.Type.ToString()
                        , guitar.Specs.BackWood.ToString()
                        , guitar.Specs.TopWood.ToString()
                        , guitar.Price);
                }
            }
            else
            {
                Console.WriteLine("Sorry Erin, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("V95693"
                , 1499.95
                , CommonLib.Builder.FENDER
                , "Stratocastor"
                , CommonLib.Type.ELECTRIC
                , CommonLib.Wood.ALDER
                , CommonLib.Wood.ALDER);
            inventory.AddGuitar("V9512"
                , 1599.95
                , CommonLib.Builder.FENDER
                , "Stratocastor"
                , CommonLib.Type.ELECTRIC
                , CommonLib.Wood.ALDER
                , CommonLib.Wood.ALDER);
            inventory.AddGuitar("B9510"
                , 1099.95
                , CommonLib.Builder.GIBSON
                , "Senti"
                , CommonLib.Type.ACOUSTIC
                , CommonLib.Wood.CEDAR
                , CommonLib.Wood.CEDAR);
        }
    }
}
