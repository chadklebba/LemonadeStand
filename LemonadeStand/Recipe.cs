using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public int lemons;
        public int sugar;
        public int ice;
        public int newLemons;
        public int newSugar;
        public int newIce;
        public double costPerCup;
        public Recipe()
        {
            lemons = 2;
            sugar = 1;
            ice = 3;
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("Your current recipe per cup is:" + "\r");
            Console.WriteLine("$.05 - Lemons       " + lemons + "\r");
            Console.WriteLine("$.03 - Sugar (cups) " + sugar + "\r");
            Console.WriteLine("$.01 - Ice cubes    " + ice + "\n");
            Console.WriteLine("That is $" + ((lemons*.05)+(sugar*.03)+(ice*.01)) + " per cup");
        }
        public void OneLineRecipe()
        {
            Console.WriteLine("Your current recipe is " + lemons + " lemons, " + sugar + " cups of sugar, and " + ice + " ice cubes per cup.");
        }
        public void QuestionRecipe()
        {
            Console.WriteLine("Would you like to change you recipe (y or n)?");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "y":
                    ChangeRecipe();
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine("You didn't type in a y or an n, please try again");
                    QuestionRecipe();
                    break;
            }
        }
        public void ChangeRecipe()
        {
            Console.WriteLine("How many lemons would you like to use per cup of lemonade?");
            try
            {
                newLemons = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You didn't type in an integer, please type in an integer" + "\n");
                ChangeRecipe();
            }
            lemons = newLemons;
            Console.WriteLine("How many cups of sugar would you like to use per cup of lemonade?");
            try
            {
                newSugar = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You didn't type in an integer, please type in an integer" + "\n");
                ChangeRecipe();
            }
            sugar = newSugar;
            Console.WriteLine("How many ice cubes would you like to use per cup of lemonade?");
            try
            {
                newIce = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You didn't type in an integer, please type in an integer" + "\n");
                ChangeRecipe();
            }
            ice = newIce;
            Console.WriteLine("\n");
            DisplayRecipe();
        }

        public void CostPerCup()
        {
            Console.WriteLine("How much would you like to charge per cup of lemonade? (ex. .20)");
            try
            {
                costPerCup = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You didn't type the price correctly, please try again (ex. .20)");
                CostPerCup();
            }
            

        }
    }
}
