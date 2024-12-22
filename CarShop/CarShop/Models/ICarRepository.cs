namespace CarShop.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars {  get; }

        Car? GetCarById(int id);


        IEnumerable<Car> GetCheapCars { get; }

        IEnumerable<Car> SearchCars(string query);

    }
}
