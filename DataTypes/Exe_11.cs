using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataTypes
{
    internal class Exe_11
    {
        //11. Write a C# Sharp program that takes a decimal number as input
        //and displays its equivalent in binary form.


        public static void DecimalToBinary()
        {

            

            Console.WriteLine("Enter a decimal number to convert it to binary");
            decimal decimalNumber = decimal.Parse(Console.ReadLine());

            string binaryRepresentation = Convert.ToString((long)decimalNumber, 2);

            Console.WriteLine($"Binary representation: {binaryRepresentation}");

        }

    }
}
