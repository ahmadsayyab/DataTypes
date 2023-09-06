using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataTypes
{
    internal class Exe_7
    {
        //7. Write a C# Sharp program that takes distance and time as input and
        //displays speed in kilometres per hour and miles per hour.


        public static void CalcSpeed()
        {
            Console.WriteLine("Input distance(meters)");
            int dist = int.Parse(Console.ReadLine());

            Console.WriteLine("Input time(hour)");
            int hr = int.Parse(Console.ReadLine());

            Console.WriteLine("Input time(minutes)");
            int mnts = int.Parse(Console.ReadLine());

            Console.WriteLine("Input time(seconds)");
            int sec = int.Parse(Console.ReadLine());

            //speed formula => Speed=  distance / time;

            // Convert all time values to seconds
            double meterPerSec = (hr * 3600) + (mnts * 60) + sec;

            // Calculate speed in meters per second
            double speedInmeterPerSec = dist / meterPerSec;

            

            // Calculate speed in kilometers per hour (km/h)
            double speedInkmPerHr =  (dist / 1000.0f) / (meterPerSec / 3600.0f);
            
            // Calculate speed in kilometers per hour (km/h)
            double speedInMilesPerHr = speedInkmPerHr / 1.609f;

            Console.WriteLine($"your Speed in meters/second: {speedInmeterPerSec}");
            Console.WriteLine($"your Speed in km/h: {speedInkmPerHr}");
            Console.WriteLine($"your Speed in miles/h: {speedInMilesPerHr}");





        }
    }
}
