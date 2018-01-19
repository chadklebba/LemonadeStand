using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int currentDay;
        public Game()
        {
            player = new Player();
            random = new Random();
            customerList = new List<Customer>();
            weatherList = new List<Weather>();
            dayList = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            store = new Store(weatherList);
            currentDay = 1;
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
        public void createCustomers()
        {
            for (int i = 1; i <= 100; i++)
            {
                customerList.Add(new Customer(random) { number = i });
            }
        }

        public void RunGame()
        {
            userInterface.DisplayInstructions();
            player.GetName();
            store.StringForecast(currentDay, weatherList);
            store.DisplayStore();
        }
    }
}
