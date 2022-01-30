namespace Automarket.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> CreateAsync(T model);

        Task<T> Get(int id);

        Task<IEnumerable<T>> Select();

        Task<bool> Delete(T model);
    }
}