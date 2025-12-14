namespace Lab3.Core.States
{
    public class PreparingState : IOrderState
    {
        public string GetStateName()
        {
            return "готовится";
        }
    }
}