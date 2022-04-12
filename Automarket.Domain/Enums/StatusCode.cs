using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Domain.Enums
{
    public enum StatusCode
    {
        CarNotFound = 10,
        OK = 200,
        NotFound = 404,
        InternalServerError = 500
    }
}
