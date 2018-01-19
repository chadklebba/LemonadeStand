using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public int number;
        int count;
        double maxPrice;
        List<double> maxPriceList;
        Random purchaseCount;
        Random purchasePrice;
        public Customer(Random random)
        {
            purchaseCount = random;
            purchasePrice = random;
            maxPriceList = new List<double> { .20, .25, .30, .35 };
            PickPurchaseCount();
            maxPrice = PickPriceMax();
        }

        public void PickPurchaseCount()
        {
            count = (purchaseCount.Next(1, 3));
            
        }
        public double PickPriceMax()
        {
            double maximum = maxPriceList[(purchasePrice.Next(0, 4))];
            return maximum;
        }
    }
}
