using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Exe_1
    {

        //Write a C# Sharp program that takes three letters and displays them in reverse order.

        public static void ReverseCharsOrder()
        {
            Console.WriteLine("Enter letter 1");
            char char1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter letter 2");
            char char2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter letter 3");
            char char3 = char.Parse(Console.ReadLine());

            string result = char3 + " " + char2 +" " + char1;

            Console.WriteLine(result);


        }
    }
}
