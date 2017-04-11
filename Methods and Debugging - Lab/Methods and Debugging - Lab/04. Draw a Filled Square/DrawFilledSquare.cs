
namespace _04.Draw_a_Filled_Square
{
    using System;

    public class DrawFilledSquare
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            DrowTheSqare(number);
        }

        static void DrowTheSqare(int number)
        {
            Contours(number);

            for (int i = 0; i < number - 2; i++)
            {
                BodyPart(number);
            }

            Contours(number);
        }

        static void BodyPart(int num)
        {
            var body = num - 1;
            Console.Write('-');

            for (int i = 0; i < body; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }

        static void Contours(int num)
        {
            var drow = num * 2;
            Console.WriteLine(new String ('-',drow));
        }
    }
}
