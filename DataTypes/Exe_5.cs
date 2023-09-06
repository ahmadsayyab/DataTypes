using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Exe_5
    {
        //5. Write a C# Sharp program that takes the radius of a circle as input
        //and calculates the perimeter and area of the circle.


        public static void AreaOfCircle()
        {
            Console.WriteLine("Enter radius of a circle");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 'p' if you want to find perimeter of a cirle " +
                "OR Enter 'a' to find Area of a circle");
            string input = Console.ReadLine().ToLower();

            double pi = 3.14;
            //formula of Area of a circle => Area = πr2
            if(input == "a")
            {

                double area = pi * (radius * radius);
                Console.WriteLine($"Area of a Circle: {area}");
            }


            //formula to find perimtter of a cirlce => C = 2πr
            else if (input == "p")
            {
                double perimeter = 2*pi*radius;
                Console.WriteLine($"Perimeter of Circle: {perimeter}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
