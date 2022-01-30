using Automarket.DAL.Interfaces;
using Automarket.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Automarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository) =>
            (_carRepository) = (carRepository);

        // GET
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var response = await _carRepository.Select();
            var response1 = await _carRepository.GetByName("Tesla");
            var response2 = await _carRepository.Get(4);

            var car = new Car()
            {
                Name = "VAZ 2114",
                Model = "VAZ",
                Speed = 140,
                Price = 150_000,
                Description = "Ваз",
                DateOfCreation = DateTime.Now
            };

            await _carRepository.CreateAsync(car);
            await _carRepository.Delete(car);

            return View(response);
        }


    }
}
