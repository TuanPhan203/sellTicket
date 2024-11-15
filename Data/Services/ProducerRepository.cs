using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class ProducerRepository : GenericRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(TicketContext context) :base (context) {
        
        }
    }
}
