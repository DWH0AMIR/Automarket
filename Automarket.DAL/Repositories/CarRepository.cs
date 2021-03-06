using Automarket.DAL.Interfaces;
using Automarket.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Automarket.DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _db;

        public CarRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> CreateAsync(Car model)
        {
            if (model is not null)
            {
                await _db.Cars.AddAsync(model);
                await _db.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> DeleteAsync(Car model)
        {
            if (model is not null)
            {
                _db.Cars.Remove(model);
                await _db.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _db.Cars
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Car> GetByNameAsync(string name)
        {
            return await _db.Cars
                .FirstOrDefaultAsync(c => c.Name == name);
        }

        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            return await _db.Cars.ToListAsync();
        }

        public async Task<Car> Update(Car model)
        {
            _db.Cars.Update(model);
            await _db.SaveChangesAsync();

            return model;
        }
    }
}