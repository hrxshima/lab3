using System.Collections.Generic;
using Lab3.Core.Menu;

namespace Lab3.Core.Pricing
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice(List<MenuItem> items);
    }
}