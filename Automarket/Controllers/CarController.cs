﻿using Automarket.DAL.Interfaces;
using Automarket.Domain.Models;
using Automarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Automarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService) =>
            (_carService) = (carService);

        // GET
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var response = await _carService.GetCars();
            if (response.StatusCode == Domain.Enums.StatusCode.OK)
            {
                return View(response.Data);
            }

            return RedirectToAction("Error");
        }


    }
}
