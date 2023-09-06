using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Exe_10
    {
        //10. Write a C# Sharp program that takes two numbers as input and
        //returns true or false when both numbers are even or odd.

        public static void CheckInput()
        {
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());

            bool result;

            if((num1 % 2 == 0 && num2 % 2 == 0) || (num1 % 2 != 0 && num2 % 2 != 0))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Console.WriteLine(result);
        }
    }
}
