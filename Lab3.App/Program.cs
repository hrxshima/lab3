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

        IPricingStrategy strategy = new SimplePricingStrategy();
        Console.WriteLine(strategy.CalculatePrice(order.Items));

        var observer = new ConsoleObserver();
        order.Notifier.Attach(observer);

        order.ChangeState(new DeliveringState());
        order.ChangeState(new CompletedState());
    }
}