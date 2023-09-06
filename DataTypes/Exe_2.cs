using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Exe_2
    {
        //2. Write a C# Sharp program that takes
        //a number and a width also a number. It then displays
        //a triangle of that width using that number.

        public static void PrintTriangle()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your desired length");
            int len = int.Parse(Console.ReadLine());

            for (int i = 1; i <= len; i++)
            {
                for (int j = i; j <= len; j++)
                {
                    Console.Write(num);
                    
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
