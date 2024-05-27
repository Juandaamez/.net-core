using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test01.Data;

namespace usta_videos.Controllers
{
    public class OrderController : Controller
    {

        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {

            _context = context;
            
        }

        public async Task<IActionResult> Index()
        {
            var items =await _context.Order.ToListAsync();
            return View(items);
        }
    }
}
