using Microsoft.EntityFrameworkCore;

namespace Automarket.DAL
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) 
            : base(options)
        {

        }
    }
}