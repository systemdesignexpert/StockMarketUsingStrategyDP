// OrderPlacer.cs

using System;
using System.Collections.Generic;

public class OrderPlacer
{
    private IOrderStrategy orderStrategy;

    public OrderPlacer(IOrderStrategy strategy)
    {
        orderStrategy = strategy;
    }

    public void SetOrderStrategy(IOrderStrategy strategy)
    {
        orderStrategy = strategy;
    }

    public void PlaceOrder(List<double> stockPrices)
    {
        orderStrategy.PlaceOrder(stockPrices);
    }
}
