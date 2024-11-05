using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly TicketContext _context;
        public MovieController(TicketContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var listMovie = await _context.Movies
                        .Include(m=>m.Cinema)
                        .Include(m=>m.Producer)
                        .ToListAsync();
            return View(listMovie);
        }
    }
}
