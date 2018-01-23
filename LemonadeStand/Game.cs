using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LemonadeStand
{
    class Game
    {
        Player player;
        public List<Customer> customerList;
        public List<Weather> weatherList;
        public List<string> dayList;
        public Random random;
        public UserInterface userInterface;
        public Store store;
        public SQLConnection connection;
        public int currentDay;
        public int cupsOfLemonade;
        public int cupsPurchased;
        public double totalProfit;
        public Game()
        {
            player = new Player();
            random = new Random();
            connection = new SQLConnection();
            customerList = new List<Customer>();
            weatherList = new List<Weather>();
            dayList = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            store = new Store();
            currentDay = 1;
            totalProfit = 0;
            createWeather();
            userInterface = new UserInterface();
             
        }
        public void createWeather()
        {
            for (int i = 1; i <= 7; i++)
            {
                weatherList.Add(new Weather(random) { name = dayList[i - 1] });
            }
        }
        public void createCustomers(int count)
        {
            customerList.Clear();
            for (int i = 1; i <= count; i++)
            {
                customerList.Add(new Customer(random) { number = i });
            }
        }
        public void MakeLemonade()
        {
            Console.Clear();
            Console.WriteLine("The weather today is " + weatherList[currentDay - 1].sun + " and " + weatherList[currentDay - 1].temp + "\n");
            player.inventory.OneLineInventory();
            player.recipe.OneLineRecipe();
            Console.WriteLine("How many cups of lemonade would you like to make for today?");
            try
            {
                cupsOfLemonade = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please type in a number (ex. 30)");
            }
            if (((cupsOfLemonade * player.recipe.lemons) <= player.inventory.lemons) & ((cupsOfLemonade * player.recipe.sugar) <= player.inventory.sugar) & ((cupsOfLemonade * player.recipe.ice) <= player.inventory.iceCubes))
            {
                player.inventory.lemons = player.inventory.lemons - (cupsOfLemonade * player.recipe.lemons);
                player.inventory.sugar = player.inventory.sugar - (cupsOfLemonade * player.recipe.sugar);
                player.inventory.iceCubes = player.inventory.iceCubes - (cupsOfLemonade * player.recipe.ice);
            }
            else
            {
                Console.WriteLine("You don't have enought inventory to make that many cups of lemonade, please hit enter to try again");
                Console.ReadLine();
                MakeLemonade();
            }

        }

        public void DayStand()
        {
            cupsPurchased = 0;
            Console.Clear();
            foreach(Customer customer in customerList)
            {
                
                if (customer.maxPrice >= player.recipe.costPerCup)
                {
                    cupsPurchased += customer.count;
                } 
                if (cupsPurchased == cupsOfLemonade)
                {
                    break;
                }
            }
            Console.WriteLine("You sold " + cupsPurchased + " cups of lemonade today at " + player.recipe.costPerCup + " for a total of $" + (cupsPurchased*player.recipe.costPerCup));
            player.wallet.balance = player.wallet.balance + (cupsPurchased * player.recipe.costPerCup);
            Console.WriteLine("You had " + (cupsOfLemonade - cupsPurchased) + " left when you closed.");
            Console.ReadLine();
        }

        public void EndOfDay()
        {
            double moneySpent = (((cupsOfLemonade * player.recipe.lemons) * .05) + ((cupsOfLemonade * player.recipe.sugar) * .03) + ((cupsOfLemonade * player.recipe.ice) * .01));
            double moneyMade = (cupsPurchased * player.recipe.costPerCup);
            Console.Clear();
            string title = player.name + "'s " + weatherList[currentDay -1].name + " Financial Report";
            string title2 = weatherList[currentDay - 1].sun + ", " + weatherList[currentDay - 1].temp;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", title) + "\r");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title2.Length / 2)) + "}", title2) + "\n");
            Console.ResetColor();
            Console.WriteLine("Today's potential customers: " + weatherList[currentDay - 1].customerCount + "\n");
            Console.WriteLine("Money Spent");
            Console.WriteLine("-----------");
            Console.WriteLine("Cups made: " + cupsOfLemonade);
            Console.WriteLine((cupsOfLemonade * player.recipe.lemons) + " lemons at .05 = $" + ((cupsOfLemonade * player.recipe.lemons)* .05));
            Console.WriteLine((cupsOfLemonade * player.recipe.sugar) + " cups of sugar at .03 = $" + ((cupsOfLemonade * player.recipe.sugar) * .03));
            Console.WriteLine((cupsOfLemonade * player.recipe.ice) + " ice cubes at .01 = $" + ((cupsOfLemonade * player.recipe.ice) * .01));
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Total: $" + moneySpent+ "\n");
            Console.WriteLine("Money Made");
            Console.WriteLine("----------");
            Console.WriteLine("Cups of lemonade sold: " + cupsPurchased);
            Console.WriteLine("Price per cup of lemonade: $" + player.recipe.costPerCup);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Total: $" + moneyMade+ "\n");
            double profit = moneyMade - moneySpent;
            if(profit >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Total profit for the day is: $" + profit);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Total profit for the day is: $" + profit);
                Console.ResetColor();
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            cupsOfLemonade = 0;
            currentDay++;
            totalProfit = totalProfit + profit;

        }
        public void EndGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string title = player.name + "'s " + "End of Game Report";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", title) + "\n");
            Console.ResetColor();
            if (totalProfit >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Total profit for the game is: $" + totalProfit);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Total profit for the game is: $" + totalProfit);
                Console.ResetColor();
            }
            Console.ReadLine();
        }



        public void RunGame()
        {
            userInterface.DisplayInstructions();
            player.GetName();
            for (int i = 1; i <= 7; i++)
            {
                store.StringForecast(currentDay, weatherList);
                store.DisplayForecast(currentDay, weatherList);
                store.BuyLemons(player);
                store.BuySugar(player);
                store.BuyIceCubes(player);
                player.inventory.DisplayInventory();
                player.recipe.DisplayRecipe();
                player.recipe.QuestionRecipe();
                player.recipe.CostPerCup();
                MakeLemonade();
                createCustomers(weatherList[currentDay - 1].customerCount);
                DayStand();
                EndOfDay();
                
            }
            EndGame();
            connection.InsertHS(totalProfit, player.name);
            connection.DisplayHS();
        }
    }
}
