using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Exe_6
    {
        //6. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1
        //(using integer numbers for y, ranging from -5 to +5).

        public static void CalcXvalue()
        {

            Console.WriteLine("Formula Used: x = y2 + 2y + 1");


            int y = -5;
            while (y == -5 || y <= 5)
            {
                int x = (y * y) + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
                y++;


            }
        }
    }
}
