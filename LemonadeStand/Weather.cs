using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string name;
        public List<string> scrList;
        public List<string> hwcList;
        Random rndScr;
        Random rndHwc;
        public int customerCount;
        public string sun;
        public string temp;
        public Weather(Random random)
        {
            scrList = new List<string> { "Sunny", "Cloudy", "Raining" };
            hwcList = new List<string> { "Hot", "Warm", "Cool" };
            rndScr = random;
            rndHwc = random;
            ChooseWeather();
        }

        public void ChooseWeather()
        {
            sun = scrList[rndScr.Next(0, 3)];
            temp = hwcList[rndHwc.Next(0, 3)];
            if (sun == "Sunny" & temp == "Hot") { customerCount = 100; }
            if (sun == "Sunny" & temp == "Warm") { customerCount = 95; }
            if (sun == "Sunny" & temp == "Cool") { customerCount = 90; }
            if (sun == "Cloudy" & temp == "Hot") { customerCount = 80; }
            if (sun == "Cloudy" & temp == "Warm") { customerCount = 75; }
            if (sun == "Cloudy" & temp == "Cool") { customerCount = 60; }
            if (sun == "Raining" & temp == "Hot") { customerCount = 40; }
            if (sun == "Raining" & temp == "Warm") { customerCount = 35; }
            if (sun == "Raining" & temp == "Cool") { customerCount = 30; }
            
        }

    }
}
