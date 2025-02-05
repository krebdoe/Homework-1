//Written by Shashank 
//January 31, 2025

using System;

namespace TheDefenseOfConsolas
{
    public class TheDefenseOfConsolas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DEFENSE OF CONSOLAS");

            //Input from the user for the row and column
            Console.WriteLine("Enter the Target Row: ");
            int targetrow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Target Column: ");
            int targetcolumn = Convert.ToInt32(Console.ReadLine());

            //Checking and calculating the boxes around the target box and giving the coordinates
            int leftcolumn = targetcolumn - 1;
            int rightcolumn = targetcolumn + 1;
            int uprow = targetrow - 1;
            int downrow = targetrow + 1;

            //output for the results of the boxes that need to be attacked
            Console.WriteLine("DEPLOY TO: ");
            Console.WriteLine($"({targetrow}, {leftcolumn})");
            Console.WriteLine($"({uprow}, {targetcolumn})");
            Console.WriteLine($"({targetrow}, {rightcolumn})");
            Console.WriteLine($"({downrow}, {targetcolumn})");

            //As per the question's ask for beep
            Console.Beep();
        }
    }
}