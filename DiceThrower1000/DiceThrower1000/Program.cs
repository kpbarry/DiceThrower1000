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
            DiceThrower("3d20 10d6");
            DiceThrower("100d6");
            Console.ReadKey();
        }

        static void DiceThrower(string diceString)
        {
                string[] splitOnSp = diceString.Split(' ');
                for (int i = 0; i < splitOnSp.Count(); i++)
                {
                    string input = splitOnSp[i].ToString();
                    //Split into 2 separate lists of just numbers
                    string[] splitOnD = input.Split('d', 'D');
                    //First list is the number of rolls you want => index = 0
                    string listRolls = splitOnD[0];
                    //Second list is the number of sides you want => index = 1
                    string listSides = splitOnD[1];

                    //Convert to int for math
                    int numRolls = int.Parse(listRolls);
                    int numSides = int.Parse(listSides);
                    //Total for average
                    double total = 0;

                    //Lets you know when it's rolling
                    Console.WriteLine("Throwing: " + splitOnSp[i]);

                    //Rng for rolling
                    Random rng = new Random();

                    //Loop for rolling um to numRolls times
                    Console.Write("Results: ");
                    for (int j = 1; j <= numRolls; j++)
                    {
                        //Random number 1 => numSides + 1
                        int rollTracker = rng.Next(1, numSides + 1);
                        //Print out results
                        total += rollTracker;
                        Console.Write(rollTracker + " ");
                    }
                    Console.WriteLine("\nAverage roll: " + total / numRolls + "\n\n");
                }
            
        }
    }
}
