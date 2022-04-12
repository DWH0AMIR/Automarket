using Automarket.Domain.Models;
using Automarket.Domain.Responses;
using Automarket.Domain.ViewModels.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Service.Interfaces;

public interface ICarService
{
    Task<IBaseResponse<IEnumerable<Car>>> GetCars();

    Task<IBaseResponse<CarViewModel>> CreateCar(CarViewModel carViewModel);

    Task<IBaseResponse<Car>> GetCarByName(string name);

    Task<IBaseResponse<Car>> GetCarById(int id);

    Task<IBaseResponse<bool>> DeleteById(int id);

    Task<IBaseResponse<Car>> Edit(int id, CarViewModel model);
}
