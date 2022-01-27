namespace Automarket.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(T model);

        T Get(int id);

        Task<IEnumerable<T>> Select();

        bool Delete(T model);
    }
}