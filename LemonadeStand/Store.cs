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
        public int i;
        public Store(List<Weather> weatherList)
        {

        }

        public void StringForecast(int currentDay, List<Weather> weatherList)
        {
            for (int i = (currentDay-1); i<=6; i++)
            {
                forecastString += weatherList[i].name + " - " + weatherList[i].sun + ", " + weatherList[i].temp + "\n"; 
            }
            
            
        }
        public void DisplayStore()
        {
            string store = "Chad's Grocery Store";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (store.Length / 2)) + "}", store) + "\n");
            Console.ResetColor();
            Console.WriteLine("Forecast:");
            Console.WriteLine(forecastString);
            Console.ReadLine();
        }
    }
}
