using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Exe_8
    {
        //8. Write a C# Sharp program that takes the radius of a sphere as input
        //and calculates and displays the surface and volume of the sphere.

        public static void CalcSphereAeraAndVol()
        {
            Console.WriteLine("Enter radiud of a sphere");
            int radius = int.Parse(Console.ReadLine());

            double pi = 3.14;

            //Volume of a sphere formula => V = 4/3*pi*r*r*r
            double volOfSphere = (4/3 * pi * (Math.Pow(radius, 3)));
            Console.WriteLine($"Volume of a Sphere: {volOfSphere}");

            //Surface area of a sphere => A=4πr*r
            double surfaceAreaOfSphere = 4 * pi * (Math.Pow(radius, 2));
            Console.WriteLine($"Surface Area of a Sphere: {surfaceAreaOfSphere}");



        }
    }
}
