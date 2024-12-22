namespace CarShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
