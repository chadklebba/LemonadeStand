using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        public UserInterface()
        {

        }

        public void DisplayInstructions()
        {
            string ls = "Lemonade Stand";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ls.Length / 2)) + "}", ls) + "\n");
            Console.ResetColor();
            Console.WriteLine("Instructions:" + "\n");
            Console.WriteLine("You have 7 days to make as much money as possible, and you have decided to open up a lemonade stand in Florida." + "\r");
            Console.WriteLine("You will have control over your business, including pricing, inventory control and purchasing supplies.  Buy your " + "\r");
            Console.WriteLine("ingredients, set your recipe and start selling." + "\r" );
            Console.WriteLine("The first thing you’ll have to worry about is your recipe. At first, go with the default recipe, but try to " + "\r");
            Console.WriteLine("experiment a little bit and see if you can find a better one. Make sure you buy enough of all your ingredients, " + "\r");
            Console.WriteLine("or you won’t be able to sell!" + "\r");
            Console.WriteLine("You’ll also have to deal with the weather, which will play a big part when customers are deciding whether or not " + "\r");
            Console.WriteLine("to buy your lemonade. Read the weather report every day! When the temperature drops, or the weather turns bad " + "\r");
            Console.WriteLine("(cloudy, rain), don’t expect them to buy nearly as much as they would on a hot, sunny day, so buy accordingly." + "\r");
            Console.WriteLine("Feel free to set your prices higher on those hot, sunny days too, as you’ll make more profit, even if you sell " + "\r");
            Console.WriteLine("a bit less lemonade." + "\r");
            Console.WriteLine("At the end of 7 days, you’ll see how much money you made. Play again, and try to beat your high score!" + "\n");
            Console.WriteLine("Please press Enter to continue");
            Console.ReadLine();
        }

        
    }
}
