using CarShop.Models;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly IShoppingCart  _shoppingCart;
        

        public ShoppingCartController(ICarRepository carRepository, IShoppingCart shoppingCart)
        {
            _carRepository = carRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;


            var shoppingCartViewModel = new ShoppingCartViewModel(_shoppingCart, _shoppingCart.GetTotalPrice());

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int carId)
        {
            var selectedCar = _carRepository.GetAllCars.FirstOrDefault(c => c.CarId == carId);

            if (selectedCar != null)
            {
                _shoppingCart.AddToCart(selectedCar);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int carId)
        {
            var selectedCar = _carRepository.GetAllCars.FirstOrDefault(c => c.CarId == carId);

            if (selectedCar != null)
            {
                _shoppingCart.RemoveFromCart(selectedCar);
            }
            return RedirectToAction("Index");
        }


    }
}
