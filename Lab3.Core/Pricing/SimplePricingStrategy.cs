using System.Collections.Generic;
using Lab3.Core.Menu;

namespace Lab3.Core.Pricing
{
    public class SimplePricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(List<MenuItem> items)
        {
            decimal total = 0;

            foreach (var item in items)
            {
                total += item.Price;
            }

            return total;
        }
    }
}