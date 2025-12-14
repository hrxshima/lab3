using Xunit;
using Lab3.Core.States;
using Lab3.Core.Menu;

namespace Lab3.Tests
{
    public class OrderTests
    {
        [Fact]
        public void Order_ChangesStateCorrectly()
        {
            var order = OrderFactory.Create();

            order.ChangeState(new DeliveringState());

            Assert.IsType<DeliveringState>(order.State);
        }
    }
}
