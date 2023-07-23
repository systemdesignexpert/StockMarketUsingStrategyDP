// MinStrategy.cs

using System;
using System.Collections.Generic;
using System.Linq;

public class MinStrategy : IOrderStrategy
{
    public void PlaceOrder(List<double> stockPrices)
    {
        double minPrice = stockPrices.Min();
        Console.WriteLine($"Placing order at minimum price: {minPrice}");
        // Place order logic based on the minimum price...
    }
}
