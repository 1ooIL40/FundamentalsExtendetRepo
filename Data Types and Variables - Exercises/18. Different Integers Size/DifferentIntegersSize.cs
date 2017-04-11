
namespace _18.Different_Integers_Size
{
    using System;

    public class DifferentIntegersSize
    {
        public static void Main()
        {
            //sbyte<byte<short<ushort<int<uint<long
            string number = Console.ReadLine();

            try
            {
                long maxSize = long.Parse(number);
                Console.WriteLine($"{maxSize} can fit in:");
                try
                {
                    sbyte n = sbyte.Parse(number);
                    Console.WriteLine("* sbyte");
                }
                catch (Exception)
                {
                }
                try
                {
                    byte n = byte.Parse(number);
                    Console.WriteLine("* byte");
                }
                catch (Exception)
                {
                }
                try
                {
                    short n = short.Parse(number);
                    Console.WriteLine("* short");
                }
                catch (Exception)
                {
                }
                try
                {
                    ushort n = ushort.Parse(number);
                    Console.WriteLine("* ushort");
                }
                catch (Exception)
                {
                }
                try
                {
                    int n = int.Parse(number);
                    Console.WriteLine("* int");
                }
                catch (Exception)
                {
                }
                try
                {
                    uint n = uint.Parse(number);
                    Console.WriteLine("* uint");
                }
                catch (Exception)
                {
                }
                Console.WriteLine("* long");
            }
            catch (Exception)
            {

                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
