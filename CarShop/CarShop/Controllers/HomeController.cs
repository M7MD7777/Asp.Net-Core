using CarShop.Models;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            CarListViewModel carListViewModel = new CarListViewModel(_carRepository.GetCheapCars, "Cars");
            return View(carListViewModel);
        }
    }
}
