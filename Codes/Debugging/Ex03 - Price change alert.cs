using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double bounds = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currenPrice = double.Parse(Console.ReadLine());
            double diff = CalculatePrice(lastPrice, currenPrice);
            bool isSignificantDifference = CheckDifference(diff, bounds);
            string message = GetPrice(currenPrice, lastPrice, diff, isSignificantDifference);

            Console.WriteLine(message);

            lastPrice = currenPrice;
        }
    }

    private static string GetPrice(double price, double lastPrice, double difference, bool checks)
    {
        string convertion = "";
        if (difference == 0)
        {
            convertion = string.Format("NO CHANGE: {0}", price);
        }
        else if (!checks )
        {
            convertion = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, price, difference );
        }
        else if (checks && (difference > 0))
        {
            convertion = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, price, difference );
        }
        else if (checks && (difference < 0))
        {
            convertion = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, price, difference );
        }
        return convertion;
    }
    private static bool CheckDifference(double bounds, double checkDifference)
    {
        if (bounds >= checkDifference)
        {
            return true;
        }
        return false;
    }

    private static double CalculatePrice(double previousPrice, double newPrice)
    {
        double priceDifference = (newPrice - previousPrice) / previousPrice;
        return priceDifference;
    }

}
