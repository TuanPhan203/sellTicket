using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public interface IGenericRepository<T> where T:class,IBaseEntity, new()
    {
        Task GetAllAsync();
        Task GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
