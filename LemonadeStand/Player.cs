using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        double wallet;
        public Player()
        {
            wallet = 20.00;
        }

        public void GetName()
        {
            Console.Clear();
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
        }
    }
}
