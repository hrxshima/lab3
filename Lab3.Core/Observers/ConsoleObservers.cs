using System;
using Lab3.Core.Menu;

namespace Lab3.Core.Observers
{
    public class ConsoleObserver : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine($"состояние заказа: {order.State.GetStateName()}");
        }
    }
}