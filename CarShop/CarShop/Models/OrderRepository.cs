namespace CarShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly CarShopDbContext _context;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(CarShopDbContext context, IShoppingCart shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderDetails = new List<OrderDetail>(); // Ensure OrderDetails is initialized

            // Ensure shoppingCartItems is initialized and not null
            List<ShoppingCartItem> shoppingCartItems = _shoppingCart.GetShoppingCartItems();
            order.OrderTotal = _shoppingCart.GetTotalPrice();

            foreach (ShoppingCartItem shoppingCartItem in shoppingCartItems)
            {
                // Ensure shoppingCartItem and its properties are not null
                if (shoppingCartItem?.Car != null)
                {
                    var orderDetail = new OrderDetail
                    {
                        Amount = shoppingCartItem.Amount,
                        CarId = shoppingCartItem.Car.CarId,
                        Price = shoppingCartItem.Car.Price,
                    };

                    order.OrderDetails.Add(orderDetail);
                }
            }

            // Check if OrderDetails has items before adding the order
            if (order.OrderDetails.Count > 0)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Cannot create order without order details.");
            }
        }

    }
}
