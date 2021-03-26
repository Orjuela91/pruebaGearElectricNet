using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AsistentesController : ControllerBase
    {
        private readonly DbContexto _context;

        public AsistentesController(DbContexto context)
        {
            _context = context;
        }

        // GET: api/Asistentes/GetAsistentes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asistente>>> GetAsistentes()
        {
            return await _context.Asistente.ToListAsync();
        }

        // POST: api/Asistentes/NewAsistente
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Asistente>> NewAsistente(Asistente asistente)
        {
            _context.Asistente.Add(asistente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsistente", new { id = asistente.Id }, asistente);
        }

    }
}
