﻿using System.Diagnostics.Tracing;
using System.Reflection;

namespace Topic_3._Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomNumber = 29;
            double price = 2.99;
            string learning = "learning a bit about computer science!";


            Console.WriteLine("This is room #" + roomNumber);
            Console.WriteLine("The price is " + price);
            Console.WriteLine("I am " + learning);

            string name = "Nate Barnes";
            int gradYear = 2026;

            Console.WriteLine();
            Console.WriteLine("My name is " + name + " and I'll graduate in " + gradYear + ".");
            Console.WriteLine();
            int radius = 2;
            double area = 12.57;
            Console.WriteLine("Area of a circle is the radius squared times PI.");
            Console.WriteLine("The area of a circle with a radius of 2 is " + (area = Math.PI) * radius * 2);
            Console.WriteLine();
            //Finding the area of a sphere.
            int diameter = 4;
            double PI = 3.14159265359;

            Console.WriteLine("To find the area of a sphere, the formula is 4 * PI * diameter");
            Console.WriteLine("The area of a sphere with a diameter of four is " + 4 * PI * 4);




        }
    }
}
