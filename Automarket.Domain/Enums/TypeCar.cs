using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Domain.Enums;

public enum TypeCar
{
    [Display(Name = "Легковой автомобиль")]
    PassengerCar = 0,

    [Display(Name = "Седан")]
    Sedan,

    [Display(Name = "Хэтчбек")]
    HatchBack,

    [Display(Name = "Минивэн")]
    Minivan,

    [Display(Name = "Спортивная машина")]
    SportsCar,

    [Display(Name = "Внедорожник")]
    Suv
}
