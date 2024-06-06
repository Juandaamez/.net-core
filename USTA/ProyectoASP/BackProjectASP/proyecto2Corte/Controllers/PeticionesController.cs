using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto2Corte.Data;
using proyecto2Corte.Models;
using System.Threading.Tasks;

namespace proyecto2Corte.Controllers
{
    public class PeticionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeticionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Acción para listar las peticiones
        public async Task<IActionResult> Index()
        {
            var peticiones = await _context.Peticion.ToListAsync();
            return View(peticiones); // Asegúrate de que peticiones no sea null
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peticion = await _context.Peticion
                .FirstOrDefaultAsync(m => m.IdPeticion == id);
            if (peticion == null)
            {
                return NotFound();
            }

            return View(peticion);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FechaPeticion,Nombre,Documento,Correo,Asunto,Descripcion")] Peticion peticion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(peticion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(peticion);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var peticion = await _context.Peticion.FindAsync(id);
            if (peticion == null)
            {
                return NotFound();
            }
            return View(peticion);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPeticion,FechaPeticion,Nombre,Documento,Correo,Asunto,Descripcion")] Peticion peticion)
        {
            if (id != peticion.IdPeticion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(peticion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(peticion);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var peticion = await _context.Peticion.FindAsync(id);
            if (peticion == null)
            {
                return NotFound();
            }
            return View(peticion);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var peticion = await _context.Peticion.FindAsync(id);
            _context.Peticion.Remove(peticion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
