using Automarket.Domain.Models;

namespace Automarket.DAL.Interfaces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Task<Car> GetByNameAsync(string name);

        Task<Car> Update(Car car);

        Task<bool> CreateAsync(Car car);

        Task<bool> DeleteAsync(Car car);

        Task<Car> GetByIdAsync(int id);

        Task<IEnumerable<Car>> GetAllAsync();

    }
}