namespace Lab3.Core.States
{
    public class DeliveringState : IOrderState
    {
        public string GetStateName()
        {
            return "доставляется";
        }
    }
}