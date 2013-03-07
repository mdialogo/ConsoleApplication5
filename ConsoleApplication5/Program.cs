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

            Guitar whatErinLikes = new Guitar();
            whatErinLikes.Model = "stratocastor";
            //whatErinLikes.Builder = CommonLib.Builder.FENDER;
            //whatErinLikes.Type = CommonLib.Type.ACOUSTIC;

            Guitar guitar = inventory.Search(whatErinLikes);
            if (guitar != null)
            {
                Console.WriteLine("Erin, you might like this {0} {1}", guitar.SerialNumber, guitar.Type);
            }
            else
            {
                Console.WriteLine("Sorry Erin, we have nothing for you.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("ABC123"
                , 1.50
                , CommonLib.Builder.FENDER
                , "Stratocastor"
                , CommonLib.Type.ELECTRIC
                , CommonLib.Wood.ALDER
                , CommonLib.Wood.ALDER);
        }
    }
}
