using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntityBase, new()
    {
        private readonly TicketContext _context;
        public GenericRepository(TicketContext context) {
            _context = context;
        }
        public async Task CreateAsync(T entity)
        {
             _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();

        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
            {
                // Bạn có thể ném ra một exception tùy chỉnh hoặc trả về null nếu không tìm thấy
                // Ví dụ: throw new KeyNotFoundException($"Không tìm thấy đối tượng với id {id}");
                throw new KeyNotFoundException($"Không tìm thấy đối tượng với id {id}");
            }

            return entity;
        }

        public async Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, IncludeProperty) => current.Include(IncludeProperty));
            return await query.FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry(entity);
            entityEntry.State = EntityState.Modified;
            /*_context.Update(entity);*/
            await _context.SaveChangesAsync();

        }

       
    }
}
