using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Exe_3
    {
        //3. Write a C# Sharp program
        //that takes userid and password as input (string type).
        //After 3 unsuccessful attempts, the user will be rejected.

        public static void TryLogin()
        {
            string userid = "19";
            string userPass = "abcd19";

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter your id");
                string id = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string pass = Console.ReadLine();

                if (id == userid && pass == userPass)
                {
                    Console.WriteLine("Logged in successfull");
                    break;
                }

                if (i == 3 && id != userid && pass != userPass)
                {
                    Console.WriteLine("Logged in rejected");
                }

                else
                {
                    Console.WriteLine($"try again for {i+1} time ");
                }

                

            }
            


        }
    }
}
