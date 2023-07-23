// Program.cs

using System;
using System.Collections.Generic;

public static class Program
{
    public static void Main()
    {
        List<double> stockPrices = new List<double> { 100.5, 102.0, 98.5, 105.0, 101.0 };

        OrderPlacer orderPlacer = new OrderPlacer(new AverageStrategy());
        orderPlacer.PlaceOrder(stockPrices); // Places order at average price

        orderPlacer.SetOrderStrategy(new MinStrategy());
        orderPlacer.PlaceOrder(stockPrices); // Places order at minimum price

        orderPlacer.SetOrderStrategy(new MaxStrategy());
        orderPlacer.PlaceOrder(stockPrices); // Places order at maximum price

        orderPlacer.SetOrderStrategy(new MedianStrategy());
        orderPlacer.PlaceOrder(stockPrices); // Places order at maximum price
    }
}
