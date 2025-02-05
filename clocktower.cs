//Written by Shashank
//January 31, 2025

using System;

namespace TheClockTowerOfConsolas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //input from the user for the number
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //checking if the number is odd or even and displaying the output as per the question
            if(num % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
        
        }   

    }
}