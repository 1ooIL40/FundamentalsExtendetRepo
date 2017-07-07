namespace _05.Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static double CalcDistance(Point pointOne, Point pointTwo)
        {
            var sideA = pointOne.X - pointTwo.X;
            var sideB = pointOne.Y - pointTwo.Y;

            var sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return sideC;
        }
    }

    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }


        public static int CalculatePerimeter(int width, int height)
        {
            int result = (2 * width + 2 * height);

            return result;
        }

        public static int CalculateArea(int width, int height)
        {
            int result = (width * height);

            return result;
        }
    }

    public class Boxes
    {
        public static void Main()
        {
            List<Box> boxes = new List<Box>();

            string[] input = Console.ReadLine()
                .Split(" :|".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                Point upperLeft = new Point()
                {
                    X = int.Parse(input[0]),
                    Y = int.Parse(input[1])
                };

                Point upperRight = new Point()
                {
                    X = int.Parse(input[2]),
                    Y = int.Parse(input[3])
                };
                Point bottomLeft = new Point()
                {
                    X = int.Parse(input[4]),
                    Y = int.Parse(input[5])
                };
                Point bottomRight = new Point()
                {
                    X = int.Parse(input[6]),
                    Y = int.Parse(input[7])
                };

                Box newBox = new Box()
                {
                    UpperLeft = upperLeft,
                    UpperRight = upperRight,
                    BottomLeft = bottomLeft,
                    BottomRight = bottomRight
                };

                boxes.Add(newBox);

                input = Console.ReadLine()
                .Split(" :|".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);
            }


            foreach (var box in boxes)
            {
                int width = (int)Point.CalcDistance(box.UpperLeft, box.UpperRight);
                int height = (int)Point.CalcDistance(box.UpperLeft, box.BottomLeft);
                int perimeter = Box.CalculatePerimeter(width, height);
                int area = Box.CalculateArea(width, height);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
            }
        }
    }
}
