using System.Collections.Generic;
using Lab3.Core.Menu;

namespace Lab3.Core.Pricing
{
    public class DeliveryFeeDecorator : IPricingStrategy
    {
        private readonly IPricingStrategy baseStrategy;
        private readonly decimal deliveryFee;

        public DeliveryFeeDecorator(IPricingStrategy baseStrategy, decimal deliveryFee)
        {
            this.baseStrategy = baseStrategy;
            this.deliveryFee = deliveryFee;
        }

        public decimal CalculatePrice(List <MenuItem> items)
        {
            return baseStrategy.CalculatePrice(items) + deliveryFee;
        }
    }
}