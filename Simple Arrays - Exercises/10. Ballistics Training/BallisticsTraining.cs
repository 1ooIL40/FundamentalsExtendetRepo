﻿
namespace _10.Ballistics_Training
{
    using System;
    using System.Linq;

    public class BallisticsTraining
    {
        public static void Main()
        {

            var targetCoordinates = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var positionCoordinates = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            FireAtCoordinates(positionCoordinates, targetCoordinates);

        }

        static void FireAtCoordinates(string[] positionCoordinates, 
            double[] targetCoordinates)
        {
            var coordsLen = positionCoordinates.Length;

            double coordinatesX = targetCoordinates[0];
            double coordinatesY = targetCoordinates[1];
            double x = 0;
            double y = 0;

            for (int i = 0; i < coordsLen; i++)
            {
                if (positionCoordinates[i] == "up")
                {
                    y += double.Parse(positionCoordinates[i + 1]);
                }
                if (positionCoordinates[i] == "down")
                {
                    y -= double.Parse(positionCoordinates[i + 1]);
                }
                if(positionCoordinates[i] == "right")
                {
                    x += double.Parse(positionCoordinates[i + 1]);
                }
                if (positionCoordinates[i] == "left")
                {
                    x -= double.Parse(positionCoordinates[i + 1]);
                }
            }
            Console.WriteLine($"firing at [{x}, {y}]");
            if (x == coordinatesX && y == coordinatesY)
            {
                Console.WriteLine($"got 'em!");
            }
            else
            {
                Console.WriteLine($"better luck next time...");
            }
        }
    }
}
