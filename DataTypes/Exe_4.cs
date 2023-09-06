using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Exe_4
    {
        //4. Write a C# Sharp program that
        //takes two numbers as input and performs an operation (+,-,*,x,/) on them
        //and displays the result of that operation.

        public static void PerformOprOnInputs()
        {
            int result=0;
            Console.WriteLine("Enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator (+,-,*,x,/) which you want to perform on the above two nums");
            char opr = char.Parse(Console.ReadLine());

            if(opr == '+')
            {
                result = num1 + num2;
                
            }
            else if(opr == '-')
            {
                result = num1 - num2;
            }
            else if(opr == '*')
            {
                result = num1 * num2;
            }
            else if(opr == '/')
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("invalid input");
            }

            Console.WriteLine(result);
        }
    }


}
