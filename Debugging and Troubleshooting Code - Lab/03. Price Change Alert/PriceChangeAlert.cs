using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine()); //n
        double treshold = double.Parse(Console.ReadLine()); // granica
        double prices = double.Parse(Console.ReadLine()); // last

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double changes = double.Parse(Console.ReadLine());
            double difference = PercentChanges(prices, changes);
            bool isSignificantDifference = differenceOrNot(difference, treshold);

            string message = GetMessage(changes, prices, difference, isSignificantDifference);
            Console.WriteLine(message);

            prices = changes;
        }

    }

    static string GetMessage(double changes, double price, double differece, bool isSignificantDifference)
    {
        string outputMessage = "";
        if (differece == 0)
        {
            outputMessage = string.Format("NO CHANGE: {0}", changes);
        }
        else if (!isSignificantDifference)
        {
            outputMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, changes, differece * 100);
        }
        else if (isSignificantDifference && (differece > 0))
        {
            outputMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, changes, differece * 100);
        }
        else if (isSignificantDifference && (differece < 0))
        {
            outputMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, changes, differece * 100);
        }
        return outputMessage;
    }

    static bool differenceOrNot(double difference, double treshold)
    {
        if (Math.Abs(difference) >= treshold)
        {
            return true;
        }
        return false;
    }

    static double PercentChanges(double price, double changes)
    {
        double result = (changes - price) / price;
        return result;
    }
}
