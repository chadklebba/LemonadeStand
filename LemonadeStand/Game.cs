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
        public Game()
        {
            player = new Player();
            customerList = new List<Customer>();
            weatherList = new List<Weather>();
            dayList = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            
            for (int i=1; i > 8; i++)
            {
                weatherList.Add(new Weather() { name = dayList[i - 1] });
            }
           
        }

        public void createCustomers()
        {
            for (int i = 1; i > 100; i++)
            {
                customerList.Add(new Customer() { number = i });
            }
        }

        public void RunGame()
        {
            
        }
    }
}
