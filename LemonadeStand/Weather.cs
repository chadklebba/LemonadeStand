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
        int customerCount;
        public Weather()
        {
            scrList = new List<string> { "Sunny", "Cloudy", "Raining" };
            hwcList = new List<string> { "Hot", "Warm", "Cool" };
            rndScr = new Random();
            rndHwc = new Random();
            ChooseWeather();
        }

        public void ChooseWeather()
        {
            string sun;
            string temp;
            sun = scrList[rndScr.Next(0, 3)];
            temp = hwcList[rndHwc.Next(0, 3)];
            if (sun == "Sunny" & temp == "Hot") { customerCount = 100; }
            if (sun == "Sunny" & temp == "Warm") { customerCount = 90; }
            if (sun == "Sunny" & temp == "Cool") { customerCount = 80; }
            if (sun == "Cloudy" & temp == "Hot") { customerCount = 70; }
            if (sun == "Cloudy" & temp == "Warm") { customerCount = 60; }
            if (sun == "Cloudy" & temp == "Cool") { customerCount = 50; }
            if (sun == "Raining" & temp == "Hot") { customerCount = 40; }
            if (sun == "Raining" & temp == "Warm") { customerCount = 30; }
            if (sun == "Raining" & temp == "Cool") { customerCount = 20; }
        }

    }
}
