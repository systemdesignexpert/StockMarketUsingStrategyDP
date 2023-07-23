// MaxStrategy.cs

using System;
using System.Collections.Generic;
using System.Linq;

public class MaxStrategy : IOrderStrategy
{
    public void PlaceOrder(List<double> stockPrices)
    {
        double maxPrice = stockPrices.Max();
        Console.WriteLine($"Placing order at maximum price: {maxPrice}");
        // Place order logic based on the maximum price...
    }
}
