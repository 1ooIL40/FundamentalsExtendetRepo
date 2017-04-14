namespace _06.Notifications
{
    using System;

    public class Notifications
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                var operation = Console.ReadLine();
                if (operation == "success")
                {
                    var userOperation = Console.ReadLine();
                    var userMessage = Console.ReadLine();
                    result = ShowSuccess(userOperation, userMessage);
                }
                else if (operation == "error")
                {
                    var userOperation = Console.ReadLine();
                    var userCode = int.Parse(Console.ReadLine());
                    result = ShowError(userOperation, userCode);
                }
                Console.WriteLine(result);
            }

        }
        static string ShowSuccess(string operation, string message)
        {
            var outputUserOperation = $"Successfully executed {operation}.";
            var divider = $"==============================";
            var otputUserMessage = $"Message: {message}.";

            var finalOutput = $"{outputUserOperation}\n{divider}\n{otputUserMessage}";

            return finalOutput;
        }

        static string ShowError(string operation, int code)
        {
            var outputUserOperation = $"Error: Failed to execute {operation}.";
            var divider = $"==============================";
            var errorCode = $"Error Code: {code}.";

            var result = string.Empty;
            if(code >= 0)
            {
                result = $"Invalid Client Data";
            }
            else
            {
                result = $"Internal System Failure";
            }
            var reason = $"Reason: {result}.";

            var finalOutput = $"{outputUserOperation}\n{divider}\n{errorCode}\n{reason}";
            return finalOutput;
        }

    }
}
