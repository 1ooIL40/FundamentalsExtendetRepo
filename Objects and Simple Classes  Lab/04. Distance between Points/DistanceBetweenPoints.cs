namespace _04.Distance_between_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            

            var pointOne = GetPointPosition();
            var pointTwo = GetPointPosition();

            var result = CalcDistance(pointOne, pointTwo);

            Console.WriteLine($"{result:F3}");

        }

        static  double CalcDistance(Point pointOne, Point pointTwo)
        {
            var sideA = pointOne.X - pointTwo.X;
            var sideB = pointOne.Y - pointTwo.Y;

            var sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return sideC;
        }

        static Point GetPointPosition()
        {
            var input = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();

            return new Point
            {
                X = input[0],
                Y = input[1]
            };
        }
    }
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

    }
}
