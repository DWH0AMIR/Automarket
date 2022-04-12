namespace Automarket.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> CreateAsync(T model);

        Task<T> Update(T model);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<bool> DeleteAsync(T model);
    }
}