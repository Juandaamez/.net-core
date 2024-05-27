using Microsoft.AspNetCore.Mvc;
using ustaVideos.Data;

namespace ustaVideos.Controllers
{
    public class ActorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.Actors.ToList();
            return View();
        }
    }
}
