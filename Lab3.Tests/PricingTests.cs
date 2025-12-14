using Xunit;
using System.Collections.Generic;
using Lab3.Core.Pricing;
using Lab3.Core.Menu;

namespace Lab3.Tests
{
    public class PricingTests
    {
        [Fact]
        public void SimplePricing_ReturnsCorrectSum()
        {
            var items = new List<MenuItem>
            {
                new MenuItem("Burger", 100),
                new MenuItem("Fries", 50)
            };

            IPricingStrategy strategy = new SimplePricingStrategy();

            decimal result = strategy.CalculatePrice(items);

            Assert.Equal(150, result);
        }
    }
}
