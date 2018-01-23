using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LemonadeStand
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
        }
    }
}
