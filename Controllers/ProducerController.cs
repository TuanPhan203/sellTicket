using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly TicketContext _context;
        public ProducerController(TicketContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var listProducer = await _context.Producers.ToListAsync();
            return View(listProducer);
        }
    }
}
