using System.Collections.Generic;
using Lab3.Core.States;
using Lab3.Core.Observers;

namespace Lab3.Core.Menu
{
    public class Order
    {
        public List<MenuItem> Items { get; } = new List<MenuItem>();
        public IOrderState State { get; private set; }

        public OrderStatusNotifier Notifier { get; } = new OrderStatusNotifier();

        public Order()
        {
            State = new PreparingState();
        }

        public void ChangeState(IOrderState newState)
        {
            State = newState;
            Notifier.Notify(this);
        }
    }
}