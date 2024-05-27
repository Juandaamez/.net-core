using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using usta_videos.Data;

namespace usta_videos.Controllers
{
    public class ActorController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ActorController(ApplicationDbContext context)
        {

            _context = context;
            
        }

        public async Task<IActionResult> Index()
        {
            var items =await _context.Actor.ToListAsync();
            return View(items);
        }
    }
}
