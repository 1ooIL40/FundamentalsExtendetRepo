
namespace _09.Altitude
{
    using System;
    using System.Linq;

    public class Altitude
    {
        public static void Main()
        {
            var altitudeArray = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var len = altitudeArray.Length;
            AltitudeOfAirplane(altitudeArray, len);
        }

        private static void AltitudeOfAirplane(string[] altitudeArray, int len)
        {
            var initialAltitude = double.Parse(altitudeArray[0]);
            double number = 0;
            var result = initialAltitude;

            for (int i = 1; i < len; i++)
            {
                if (i % 2 == 0)
                {
                    if (altitudeArray[i - 1] == "up")
                    {
                        number = double.Parse(altitudeArray[i]);
                        result += number;
                    }
                    if (altitudeArray[i - 1] == "down")
                    {
                        number = double.Parse(altitudeArray[i]);
                        result -= number;
                    }
                    if (result <= 0)
                    {
                        Console.WriteLine("crashed");
                        break;
                    }
                }
            }
            if (result > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {result}m");
            }
        }
    }
}
