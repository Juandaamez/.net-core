using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test01.Data;

namespace usta_videos.Controllers
{
    public class OfficeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public OfficeController(ApplicationDbContext context)
        {

            _context = context;
            
        }

        public async Task<IActionResult> Index()
        {
            var items =await _context.Office.ToListAsync();
            return View(items);
        }
    }
}
