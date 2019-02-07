using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            string imu = Console.ReadLine();
            string omu = Console.ReadLine();
            double result = 0;
            if (imu == "m")
            {
                if (omu == "mm")
                {
                    result = number * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (omu == "cm")
                {
                    result = number * 100;
                    Console.WriteLine(result + " cm");
                }
                if (omu == "mi")
                {
                    result = number * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (omu == "in")
                {
                    result = number * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (omu == "km")
                {
                    result = number * 0.001;
                    Console.WriteLine(result + " km");
                }
                if (omu == "ft")
                {
                    result = number * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (omu == "yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (omu=="m")
                {
                    result = number * 1;
                    Console.WriteLine(result+" m");
                }
            }
            if (imu == "mm")
            {
                number = number / 1000;
                if (omu == "m")
                {
                    result = number * 1;
                    Console.WriteLine(result + " m");
                }
                if (omu == "cm")
                {
                    result = number * 100;
                    Console.WriteLine(result + " cm");
                }
                if (omu == "mi")
                {
                    result = number * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (omu == "in")
                {
                    result = number * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (omu == "km")
                {
                    result = number * 0.001;
                    Console.WriteLine(result + " km");
                }
                if (omu == "ft")
                {
                    result = number * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (omu == "yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (omu=="mm")
                {
                    result = number * 1000;
                    Console.WriteLine(result + " mm");
                }
            }
            if (imu == "cm")
            {
                number = number / 100;
                if (omu == "mm")
                {
                    result = number * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (omu == "m")
                {
                    result = number * 1;
                    Console.WriteLine(result + " m");
                }
                if (omu == "mi")
                {
                    result = number * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (omu == "in")
                {
                    result = number * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (omu == "km")
                {
                    result = number * 0.001;
                    Console.WriteLine(result + " km");
                }
                if (omu == "ft")
                {
                    result = number * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (omu == "yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (omu=="cm")
                {
                    result = number * 100;
                    Console.WriteLine(result + " cm");
                }
            }
            if (imu == "mi")
            {
                number = number / 0.000621371192;
                if (omu == "mm")
                {
                    result = number * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (omu == "cm")
                {
                    result = number * 100;
                    Console.WriteLine(result + " cm");
                }
                if (omu == "m")
                {
                    result = number * 1;
                    Console.WriteLine(result + " m");
                }
                if (omu == "in")
                {
                    result = number * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (omu == "km")
                {
                    result = number * 0.001;
                    Console.WriteLine(result + " km");
                }
                if (omu == "ft")
                {
                    result = number * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (omu == "yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (omu=="mi")
                {
                    result = number * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
            }
            if (imu == "in")
            {
                number = number / 39.3700787;
                if (omu == "mm")
                {
                    result = number * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (omu == "cm")
                {
                    result = number * 100;
                    Console.WriteLine(result + " cm");
                }
                if (omu == "mi")
                {
                    result = number * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (omu == "m")
                {
                    result = number * 1;
                    Console.WriteLine(result + " m");
                }
                if (omu == "km")
                {
                    result = number * 0.001;
                    Console.WriteLine(result + " km");
                }
                if (omu == "ft")
                {
                    result = number * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (omu == "yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (omu=="in")
                {
                    result = number * 39.3700787;
                    Console.WriteLine(result + " in");
                }
            }
            if (imu == "km")
            {
                number = number / 0.001;
                if (omu == "mm")
                {
                    result = number * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (omu == "cm")
                {
                    result = number * 100;
                    Console.WriteLine(result + " cm");
                }
                if (omu == "mi")
                {
                    result = number * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (omu == "in")
                {
                    result = number * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (omu == "m")
                {
                    result = number * 1;
                    Console.WriteLine(result + " m");
                }
                if (omu == "ft")
                {
                    result = number * 3.2808399;
                    Console.WriteLine(result+" ft");
                }
                if (omu == "yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (omu=="km")
                {
                    result = number * 0.001;
                    Console.WriteLine(result + " km");
                }
            }
            if (imu == "ft")
            {
                number = number / 3.2808399;
                if (omu == "mm")
                {
                    result = number * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (omu == "cm")
                {
                    result = number * 100;
                    Console.WriteLine(result + " cm");
                }
                if (omu == "mi")
                {
                    result = number * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (omu == "in")
                {
                    result = number * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (omu == "km")
                {
                    result = number * 0.001;
                    Console.WriteLine(result + " km");
                }
                if (omu == "m")
                {
                    result = number * 1;
                    Console.WriteLine(result + " m");
                }
                if (omu == "yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (omu=="ft")
                {
                    result = number * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
            }
            if (imu == "yd")
            {
                number = number / 1.0936133;
                if (omu == "mm")
                {
                    result = number * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (omu == "cm")
                {
                    result = number * 100;
                    Console.WriteLine(result + " cm");
                }
                if (omu == "mi")
                {
                    result = number * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (omu == "in")
                {
                    result = number * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (omu == "km")
                {
                    result = number * 0.001;
                    Console.WriteLine(result + " km");
                }
                if (omu == "ft")
                {
                    result = number * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (omu == "m")
                {
                    result = number * 1;
                    Console.WriteLine(result + " m");
                }
                if (omu=="yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
            }
        }
    }
}