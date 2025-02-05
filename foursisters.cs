//Written by Shashank
//January 31, 2025

using System;

namespace TheFourSistersAndTheDuckBear
{
    public class TheFourSistersAndTheDuckBear
    {
        public static void Main(string[] args)
        {
            //taking the input for total number of eggs from user
            Console.WriteLine("Enter the number of chocolate eggs gathered: ");
            int eggs = Convert.ToInt32(Console.ReadLine());

            //implementing formulas and assigning variables
            int eggsforsisters = eggs / 4;

            int eggsforDuckBear = eggs % 4;

            //output for how much each sister gets and the duck bear gets
            Console.WriteLine("Each sister gets " + eggsforsisters + " eggs.");
            Console.WriteLine("Duck Bear gets " + eggsforDuckBear + " eggs.");
        }
    }
}
