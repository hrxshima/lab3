using System.Collections.Generic;
using Lab3.Core.Menu;

namespace Lab3.Core.Observers
{
    public class OrderStatusNotifier
    {
        private readonly List<IOrderObserver> observers = new List<IOrderObserver>();

        public void Attach(IOrderObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IOrderObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(Order order)
        {
            foreach (var observer in observers)
            {
                observer.Update(order);
            }
        }
    }
}