using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using usta_videos.Data;

namespace usta_videos.Controllers
{
    public class CinemaController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CinemaController(ApplicationDbContext context)
        {

            _context = context;
            
        }

        public async Task<IActionResult> Index()
        {
            var items =await _context.Cinema.ToListAsync();
            return View(items);
        }
    }
}
