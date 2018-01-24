using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory 
    {
        public int lemons;
        public int sugar;
        public int iceCubes;
        public Inventory()
        {
            lemons = 0;
            sugar = 0;
            iceCubes = 0;
        }
        public void DisplayInventory()
        {
            Console.Clear();
            Console.WriteLine("Your current inventory is:"+"\n");
            Console.WriteLine("Lemons:       " + lemons + "\r");
            Console.WriteLine("Sugar (cups): " + sugar + "\r");
            Console.WriteLine("Ice Cubes:    " + iceCubes + "\n" + "\n");
        }

       public void OneLineInventory()
        {
            Console.WriteLine("Your current inventory is: " + lemons + " lemons, " + sugar + " cups of sugar, and " + iceCubes + " ice cubes.");
        }
    }
}
