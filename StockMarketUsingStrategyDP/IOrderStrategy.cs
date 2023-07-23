// IOrderStrategy.cs

using System.Collections.Generic;

public interface IOrderStrategy
{
    void PlaceOrder(List<double> stockPrices);
}
