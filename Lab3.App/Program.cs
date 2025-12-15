using System;
using Lab3.Core.Menu;
using Lab3.Core.Observers;
using Lab3.Core.Pricing;
using Lab3.Core.States;

class Program
{
    static void Main()
    {
        var order = OrderFactory.Create();

        order.Items.Add(new MenuItem("бургер", 100));
        order.Items.Add(new MenuItem("картошка фри", 50));

        IPricingStrategy baseStrategy = new SimplePricingStrategy();

        IPricingStrategy pricingWithDelivery =
             new DeliveryFeeDecorator(baseStrategy, 30);

        var total = pricingWithDelivery.CalculatePrice(order.Items);
        Console.WriteLine(total);

        order.ChangeState(new DeliveringState());
        order.ChangeState(new CompletedState());
    }
}