using Automarket.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Domain.Models;

public class Car
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Model { get; set; }
    
    public float Speed { get; set; }

    public decimal Price { get; set; }

    public DateTime DateOfCreation { get; set; }

    public TypeCar TypeOfCar { get; set; }
}
