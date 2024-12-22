using CarShop.Models;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarController : Controller
    {
      private readonly ICarRepository _carRepository;
      private readonly ICompanyRepository _companyRepository;

     
     public CarController(ICarRepository carRepository, ICompanyRepository companyRepository)
        {
            _carRepository = carRepository;
            _companyRepository = companyRepository;
        }

        public IActionResult List()
        {
            CarListViewModel carListViewModel = new CarListViewModel(_carRepository.GetAllCars, "Cars");
            return View(carListViewModel);
        }

        public IActionResult Details(int id) {
        
        var car = _carRepository.GetCarById(id);
            if (car == null) { return NotFound(); }
            return View(car);
        }

        public IActionResult Search() 
        {
            return View();
        }
    }
}
