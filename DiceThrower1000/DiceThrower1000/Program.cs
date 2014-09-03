using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceThrower("10d6");
            DiceThrower("3d20");
            DiceThrower("100d6");
            Console.ReadKey();
        }

        static void DiceThrower(string diceString)
        {
            //Split into 2 separate lists of just numbers
            string[] splitOnD = diceString.Split('d');
            //First list is the number of rolls you want => index = 0
            string listRolls = splitOnD[0];
            //Second list is the number of sides you want => index = 1
            string listSides = splitOnD[1];

            //Convert to int for math
            int numRolls = int.Parse(listRolls);
            int numSides = int.Parse(listSides);

            //Lets you know when it's rolling
            Console.WriteLine("\n-----ROLLING-----");
            Console.WriteLine("Throwing: " + diceString);

            //Rng for rolling
            Random rng = new Random();
            
            //Loop for rolling um to numRolls times
            for (int i = 1; i <= numRolls; i++)
            {
                //Random number 1 => numSides + 1
                int rollTracker = rng.Next(1, numSides + 1);
                //Print out results
                Console.Write(rollTracker + " ");
            }
        }
    }
}
