using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using usta_videos.Data;

namespace usta_videos.Controllers
{
    public class DirectorController : Controller
    {

        private readonly ApplicationDbContext _context;

        public DirectorController(ApplicationDbContext context)
        {

            _context = context;
            
        }

        public async Task<IActionResult> Index()
        {
            var items =await _context.Director.ToListAsync();
            return View(items);
        }
    }
}
