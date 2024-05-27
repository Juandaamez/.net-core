using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test01.Data;

namespace usta_videos.Controllers
{
    public class ProductLineController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductLineController(ApplicationDbContext context)
        {

            _context = context;
            
        }

        public async Task<IActionResult> Index()
        {
            var items =await _context.ProductLine.ToListAsync();
            return View(items);
        }
    }
}
