namespace Lab3.Core.Menu
{
    public class MenuItem
    {
        public string Name { get; }
        public decimal Price { get; }

        public MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}