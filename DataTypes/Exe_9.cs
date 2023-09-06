using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataTypes
{
    internal class Exe_9
    {
        //9. Write a C# Sharp program that takes a character as input
        //and checks if it is a vowel, a digit, or any other symbol.
        
        public static void CheckInput()
        {
            Console.WriteLine("Enter a character");
            char input = char.Parse(Console.ReadLine());

            if(input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
               
                Console.WriteLine($"Your input is a vowel:  {input}");
            }
            else if(input >= '0' &&  input <= '9')
            {
                Console.WriteLine($"Your input is a digit:  {input}");
            }
            else
            {
                Console.WriteLine($"your input: {input}");
            }
        }

    }
}
