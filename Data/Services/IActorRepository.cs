using eTickets.Models;
using Microsoft.Net.Http.Headers;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorRepository
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetActorAsync(int id);
        Task AddAsync(Actor actor); 
        Task DeleteAsync(int id);
        Task EditAsync(int id, Actor actor);
        Task SaveAsync();
    }
}
