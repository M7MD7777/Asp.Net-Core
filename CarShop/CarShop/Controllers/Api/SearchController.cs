using CarShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CarShop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {

        private readonly ICarRepository _carRepository;

        public SearchController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allcars = _carRepository.GetAllCars;
            return Ok(allcars); 
            
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (!_carRepository.GetAllCars.Any(c => c.CarId == id))
            {
                return NotFound();
            }
            var car = _carRepository.GetCarById(id);
            return Ok(car);
        }
        [HttpPost]
        public IActionResult SearchCars([FromBody]string query)
        {
            IEnumerable<Car> cars=new List<Car>();

            if (!string.IsNullOrEmpty(query))
            {
                cars=_carRepository.SearchCars(query);
            }
            
            return new JsonResult(cars);
        }
    }
}
