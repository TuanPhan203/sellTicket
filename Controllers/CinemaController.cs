using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly TicketContext _context;
        public CinemaController(TicketContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var listCinema = await _context.Cinemas.ToListAsync();
            return View(listCinema);
        }
    }
}
