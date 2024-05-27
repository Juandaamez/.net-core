using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test01.Data;

namespace usta_videos.Controllers
{
    public class PaymentController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PaymentController(ApplicationDbContext context)
        {

            _context = context;
            
        }

        public async Task<IActionResult> Index()
        {
            var items =await _context.Payment.ToListAsync();
            return View(items);
        }
    }
}
