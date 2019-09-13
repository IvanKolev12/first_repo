using System;

namespace UnitConverter
{
    class StartUp
    {
        static void Main(string[] args)
        {
            UnitConverter();
        }

        private static void Input(out double number, out string imu, out string omu)
        {
            number = double.Parse(Console.ReadLine());
            imu = Console.ReadLine();
            omu = Console.ReadLine();
        }

        private static void CalculateMetersAndMilimeters(ref double number, string imu, string omu, ref double result)
        {
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

                if (omu == "m")
                {
                    result = number * 1;
                    Console.WriteLine(result + " m");
                }

            }

            if (imu == "mm")
            {
                number /= 1000;

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

                if (omu == "mm")
                {
                    result = number * 1000;
                    Console.WriteLine(result + " mm");
                }

            }
        }

        private static void CalculateCentimetersAndMilimeters(ref double number, string imu, string omu, ref double result)
        {
            if (imu == "cm")
            {
                number /= 100;

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

                if (omu == "cm")
                {
                    result = number * 100;
                    Console.WriteLine(result + " cm");
                }

            }

            if (imu == "mi")
            {
                number /= 0.000621371192;

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

                if (omu == "mi")
                {
                    result = number * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }

            }
        }

        private static void CalculateInchesAndKilometers(ref double number, string imu, string omu, ref double result)
        {
            if (imu == "in")
            {
                number /= 39.3700787;

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

                if (omu == "in")
                {
                    result = number * 39.3700787;
                    Console.WriteLine(result + " in");
                }

            }

            if (imu == "km")
            {
                number /= 0.001;

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
                    Console.WriteLine(result + " ft");
                }

                if (omu == "yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }

                if (omu == "km")
                {
                    result = number * 0.001;
                    Console.WriteLine(result + " km");
                }

            }
        }

        private static void CalculateFootsAndYards(ref double number, string imu, string omu, ref double result)
        {
            if (imu == "ft")
            {
                number /= 3.2808399;

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

                if (omu == "ft")
                {
                    result = number * 3.2808399;
                    Console.WriteLine(result + " ft");
                }

            }

            if (imu == "yd")
            {
                number /= 1.0936133;

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

                if (omu == "yd")
                {
                    result = number * 1.0936133;
                    Console.WriteLine(result + " yd");
                }

            }
        }

        private static void UnitConverter()
        {
            Input(out double number, out string imu, out string omu);
            number = ConvertUnits(number, imu, omu);
        }

        private static double ConvertUnits(double number, string imu, string omu)
        {
            double result = 0;
            CalculateMetersAndMilimeters(ref number, imu, omu, ref result);
            CalculateCentimetersAndMilimeters(ref number, imu, omu, ref result);
            CalculateInchesAndKilometers(ref number, imu, omu, ref result);
            CalculateFootsAndYards(ref number, imu, omu, ref result);
            return number;
        }

    }
}