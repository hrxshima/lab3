namespace Lab3.Core.States
{
    public class CompletedState : IOrderState
    {
        public string GetStateName()
        {
            return "завершён";
        }
    }
}