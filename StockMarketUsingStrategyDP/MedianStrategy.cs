using System;

public class MedianStrategy : IOrderStrategy
{
    public MedianStrategy()
    {

    }
    public void PlaceOrder(List<double> stockPrices)
    {
        int count = stockPrices.Count;
        List<double> copyOfPrices = new List<double>(stockPrices);
        copyOfPrices.Sort();
        Console.WriteLine($"Placing order at average price: {copyOfPrices[count / 2]}");
    }
}

