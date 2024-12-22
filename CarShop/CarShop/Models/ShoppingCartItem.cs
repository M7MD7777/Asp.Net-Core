using CarShop.Models;

public class ShoppingCartItem
{
    public int ShoppingCartItemId { get; set; }
    public Car Car { get; set; } = default!;
    public int Amount { get; set; } 
    public string? ShoppingCartId { get; set; }

    public List<ShoppingCartItem> ShoppingCartItems { get; set; }
}
