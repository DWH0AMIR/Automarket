using Automarket.DAL.Interfaces;
using Automarket.Domain.Models;
using Automarket.Domain.Enums;
using Automarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Automarket.Domain.ViewModels.Car;

namespace Automarket.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
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
            return View(response.Data.ToList());
        }

        return RedirectToAction("Error");
    }

    [HttpGet]
    public async Task<IActionResult> GetCarById(int id)
    {
        var response = await _carService.GetCarById(id);
        if (response.StatusCode == Domain.Enums.StatusCode.OK)
        {
            return View(response.Data);
        }

        return RedirectToAction("Error");
    }

    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteById(int id)
    {
        var response = await _carService.DeleteById(id);
        if (response.StatusCode == Domain.Enums.StatusCode.OK)
        {
            return View(response.Data);
        }

        return RedirectToAction("Error");
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Save(int id)
    {
        if (id is 0)
        {
            return View();
        }

        var response = await _carService.GetCarById(id);
        if (response.StatusCode == Domain.Enums.StatusCode.OK)
        {
            return View(response.Data);
        }

        return RedirectToAction("Error");
    }


    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Save(CarViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (model.Id is 0)
            {
                await _carService.CreateCar(model);
            }
            else
            {
                await _carService.Edit(model.Id, model);
            } 
        }

        return RedirectToAction("GetCars");
    }

}
