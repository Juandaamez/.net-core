using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto2Corte.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using proyecto2Corte.Models;

namespace proyecto2Corte.Controllers
{
    public class RespuestaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RespuestaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var respuestas = await _context.Respuesta
                .Include(r => r.Usuario)
                .Include(r => r.Peticion)
                .ToListAsync();
            return View(respuestas);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var respuesta = await _context.Respuesta
                .Include(r => r.Usuario)
                .Include(r => r.Peticion)
                .FirstOrDefaultAsync(m => m.IdRespuesta == id);
            if (respuesta == null)
            {
                return NotFound();
            }

            return View(respuesta);
        }

        public IActionResult Create()
        {
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Nombre");
            ViewData["IdPeticion"] = new SelectList(_context.Peticion, "IdPeticion", "Asunto");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FechaRespuesta,RespuestaTexto,IdUsuario,IdPeticion")] Respuesta respuesta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(respuesta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Nombre", respuesta.IdUsuario);
            ViewData["IdPeticion"] = new SelectList(_context.Peticion, "IdPeticion", "Asunto", respuesta.IdPeticion);
            return View(respuesta);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var respuesta = await _context.Respuesta
                .Include(r => r.Usuario)
                .Include(r => r.Peticion)
                .FirstOrDefaultAsync(m => m.IdRespuesta == id);
            if (respuesta == null)
            {
                return NotFound();
            }
            ViewData["IdUsuario"] = new SelectList(_context.Usuario, "IdUsuario", "Nombre", respuesta.IdUsuario);
            ViewData["IdPeticion"] = new SelectList(_context.Peticion, "IdPeticion", "Asunto", respuesta.IdPeticion);
            return View(respuesta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FechaRespuesta,RespuestaTexto,IdUsuario,IdPeticion")] Respuesta respuesta)
        {
            if (id != respuesta.IdRespuesta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(respuesta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(respuesta);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var respuesta = await _context.Respuesta
                .Include(r => r.Usuario)
                .Include(r => r.Peticion)
                .FirstOrDefaultAsync(m => m.IdRespuesta == id);
            if (respuesta == null)
            {
                return NotFound();
            }
            return View(respuesta);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var respuesta = await _context.Respuesta.FindAsync(id);
            _context.Respuesta.Remove(respuesta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
