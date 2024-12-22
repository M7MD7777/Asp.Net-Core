namespace CarShop.Models
{
    public interface IShoppingCart
    {
        void AddToCart(Car car);

        int RemoveFromCart(Car car);

        List<ShoppingCartItem> GetShoppingCartItems();

        void ClearCart();
        

        decimal GetTotalPrice();

        List<ShoppingCartItem> ShoppingCartItems { get; set; }




    }
}
