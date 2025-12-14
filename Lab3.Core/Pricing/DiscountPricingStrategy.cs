using System.Collections.Generic;
using Lab3.Core.Menu;

namespace Lab3.Core.Pricing
{
    public class DiscountPricingStrategy : IPricingStrategy
    {
        private readonly decimal discountPercent;

        public DiscountPricingStrategy(decimal discountPercent)
        {
            this.discountPercent = discountPercent;
        }

        public decimal CalculatePrice(List<MenuItem> items)
        {
            decimal total = 0;

            foreach (var item in items)
            {
                total += item.Price;
            }

            total -= total * discountPercent / 100;
            return total;
        }
    }
}
