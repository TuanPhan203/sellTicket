using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public interface IGenericRepository<T> where T: class,IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
