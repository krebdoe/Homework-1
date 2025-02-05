//Written by Shashank
//Jan 31, 2025

using System;

namespace TheDominionOfKings
{
    public class TheDominionOfKings
    {
        public static void Main(string[] args)
        {
            //input for provinces, duchies, estates from the user
            Console.WriteLine("Enter the number of provinces with you: ");
            int provinces = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of duchies with you: ");
            int duchies = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of estates with you: ");
            int estates = Convert.ToInt32(Console.ReadLine());

            //calculating for the total score and printing the output
            int total = (provinces *6) + (duchies *3) + (estates *1);

            Console.WriteLine("The total score for your kingdom is " + total + " points.");


        }
    }
}