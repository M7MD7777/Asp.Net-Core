using CarShop.Models;

namespace CarShop.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> Cars { get; }
        public string CompanyName { get; }

        public CarListViewModel(IEnumerable<Car> cars, string companyName)
        {
            Cars = cars;
            CompanyName = companyName;
        }

    }
}
