using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public string forecastString;
        public Store()
        {

        }

        public void StringForecast(int currentDay, List<Weather> weatherList)
        {
            for (int i = (currentDay); i <= 6; i++)
            {
                forecastString += weatherList[i].name + " - " + weatherList[i].sun + ", " + weatherList[i].temp + "\n";
            }


        }
        public void DisplayForecast(int currentDay, List<Weather> weatherList)
        {
            Console.Clear();
            string store = "Chad's Grocery Store";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (store.Length / 2)) + "}", store) + "\n");
            Console.ResetColor();
            Console.WriteLine("Forecast:");
            Console.WriteLine(forecastString + "\n");
            Console.WriteLine("Today is " + weatherList[currentDay - 1].name + " and it is " + weatherList[currentDay - 1].sun + " and " + weatherList[currentDay - 1].temp + "\n");

        }

        public void BuyLemons(Player player)
        {
            int newLemons = 0;
            Console.WriteLine("You currently have $" + player.wallet.balance + " in your wallet" + "\r");
            Console.WriteLine("Lemons cost .05 each, you currenty have " + player.inventory.lemons + ". How many would you like to buy?");
            try
            {
                newLemons = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You didn't type in an integer, please type in an integer" + "\n");
                BuyLemons(player);
            }
            player.inventory.lemons = player.inventory.lemons + newLemons;
            player.wallet.balance = player.wallet.balance - (newLemons * .05);
        }

        public void BuySugar(Player player)
        {
            int newSugar = 0;
            Console.WriteLine("You currently have $" + player.wallet.balance + " in your wallet" + "\r");
            Console.WriteLine("Sugar costs .03 per cup, you currenty have " + player.inventory.sugar + " cups." + " How many cups would you like to buy?");
            try
            {
                newSugar = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You didn't type in an integer, please type in an integer" + "\n");
                BuySugar(player);
            }
            player.inventory.sugar = player.inventory.sugar + newSugar;
            player.wallet.balance = player.wallet.balance - (newSugar * .03);
            
        }

        public void BuyIceCubes(Player player)
        {
            int newIceCubes = 0;
            Console.WriteLine("You currently have $" + player.wallet.balance + " in your wallet" + "\r");
            Console.WriteLine("Ice cubes costs .01 per cube, you currenty have " + player.inventory.iceCubes + " cubes." + " How many cubes would you like to buy?");
            try
            {
                newIceCubes = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You didn't type in an integer, please type in an integer" + "\n");
                BuyIceCubes(player);
            }
            player.inventory.iceCubes = player.inventory.iceCubes + newIceCubes;
            player.wallet.balance = player.wallet.balance - (newIceCubes * .01);
            
        }
    }
}
