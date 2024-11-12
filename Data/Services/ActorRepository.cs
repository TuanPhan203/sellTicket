using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorRepository : IActorRepository
    {
        private readonly TicketContext _context;
        public ActorRepository(TicketContext context)
        {
            _context = context;
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task AddAsync(Actor actor)
        {
           var item = _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }

      

        public async Task DeleteAsync(int id)
        {
            var item = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            _context.Actors.Remove(item);
             await _context.SaveChangesAsync();
        }

    

        public async Task EditAsync(int id, Actor actor)
        {
            EntityEntry entityEntry = _context.Entry(actor);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> GetActorAsync(int id) {
            return await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<IEnumerable<Actor>> GetAllAsync() => await _context.Actors.ToListAsync();
    }
}
