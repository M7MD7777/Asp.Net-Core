
using Microsoft.EntityFrameworkCore;

namespace CarShop.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly CarShopDbContext _context;

        public CarRepository(CarShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAllCars => _context.Cars.Include(c => c.Company);

        public IEnumerable<Car> GetCheapCars => _context.Cars.Where(c => c.Price < 30000);

        public Car? GetCarById(int id)
        {
            return _context.Cars.FirstOrDefault(c=>c.CarId == id);
        }

        public IEnumerable<Car> SearchCars(string query)
        {
            return _context.Cars.Where(c => c.Name.ToUpper().Contains(query.ToUpper()));
        }
    }
}
