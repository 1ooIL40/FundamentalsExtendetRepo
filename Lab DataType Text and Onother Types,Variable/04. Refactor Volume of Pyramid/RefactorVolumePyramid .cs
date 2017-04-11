
namespace _04.Refactor_Volume_of_Pyramid
{
    using System;

    public class RefactorVolumePyramid
    {
        public static void Main()
        {
            //double dul, sh, V = 0;
            //Console.Write("Lenght: ");
            //dul = double.Parse(Console.ReadLine());
            //Console.Write("Width: ");
            //sh = double.Parse(Console.ReadLine());
            //Console.Write("Height: ");
            //V = double.Parse(Console.ReadLine());
            //V = (dul + sh + V) / 3;
            //Console.WriteLine("Pyramid Volume: {0:F2}", V);

            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width  = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());
            var result = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {result:f2}");
        }
    }
}
