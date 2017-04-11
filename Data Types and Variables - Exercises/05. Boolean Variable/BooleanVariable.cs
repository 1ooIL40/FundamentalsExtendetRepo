
namespace _05.Boolean_Variable
{
    using System;

    public class BooleanVariable
    {
        public static void Main()
        {
            string boolVariable = Console.ReadLine();

            var isTrue = Convert.ToBoolean(boolVariable);

            if (isTrue == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
