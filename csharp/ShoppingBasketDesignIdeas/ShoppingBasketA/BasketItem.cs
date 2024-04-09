namespace ShoppingBasketA;

public class BasketItem
{
    private readonly string _name;
    private readonly decimal _price;

    public BasketItem(string name, decimal price)
    {
        _name = name;
        _price = price;
    }
}