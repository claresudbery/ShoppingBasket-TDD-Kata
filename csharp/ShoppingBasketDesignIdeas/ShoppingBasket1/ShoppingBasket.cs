namespace ShoppingBasket1;

public class ShoppingBasket
{
    public List<Tuple<BasketItem, int>> Items { get; } = new List<Tuple<BasketItem, int>>();

    public void Add(BasketItem item, int quantity)
    {
        Items.Add(new Tuple<BasketItem, int>(item, quantity));
    }

    public double GetQuantity(String itemName)
    {
        return 0;
    }

    public decimal CalculateTotal()
    {
        return 0.0m;
    }
}