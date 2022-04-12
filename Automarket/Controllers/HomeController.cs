using Automarket.DAL.Interfaces;
using Automarket.Domain.Models;
using Automarket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Automarket.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) =>
        (_logger) = (logger);


    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
