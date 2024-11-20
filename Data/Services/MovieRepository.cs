using eTickets.Data.Base;
using eTickets.Models;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(TicketContext context) : base(context) 
        {
        }
        public async Task AddNewMovieAsync()
        {

        }
    }
}
