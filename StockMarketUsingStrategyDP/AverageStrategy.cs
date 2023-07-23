// AverageStrategy.cs

using System;
using System.Collections.Generic;
using System.Linq;

public class AverageStrategy : IOrderStrategy
{
    public void PlaceOrder(List<double> stockPrices)
    {
        double averagePrice = stockPrices.Average();
        Console.WriteLine($"Placing order at average price: {averagePrice}");
        // Place order logic based on the average price...
    }
}
