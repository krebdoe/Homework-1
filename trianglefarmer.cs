//Written by Shashank
//Jan 31, 2025

using System;

namespace TheTriangleFarmer
{
    public class TheTriangleFarmer
    {
        public static void Main(string[] args)
        {
            //input for base and height
            Console.WriteLine("Enter the triangle's base: ");
            double base1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the triangle's height: ");
            double height1 = Convert.ToDouble(Console.ReadLine());

            //defining variable area and printing the area
            double area = (base1 * height1) / 2;
            Console.WriteLine("Area of Triangle: " + area + " units");

        }
    }
}