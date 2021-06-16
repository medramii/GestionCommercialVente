using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GC_Ventes.Models;

namespace GC_Ventes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillesController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public VillesController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/Villes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<_0000Ville>>> Get_0000Villes()
        {
            return await _context._0000Villes.ToListAsync();
        }

        // GET: api/Villes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_0000Ville>> Get_0000Ville(int id)
        {
            var _0000Ville = await _context._0000Villes.FindAsync(id);

            if (_0000Ville == null)
            {
                return NotFound();
            }

            return _0000Ville;
        }

        // PUT: api/Villes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put_0000Ville(int id, _0000Ville _0000Ville)
        {
            if (id != _0000Ville.IdVille)
            {
                return BadRequest();
            }

            _context.Entry(_0000Ville).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_0000VilleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Villes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<_0000Ville>> Post_0000Ville(_0000Ville _0000Ville)
        {
            _context._0000Villes.Add(_0000Ville);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get_0000Ville", new { id = _0000Ville.IdVille }, _0000Ville);
        }

        // DELETE: api/Villes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete_0000Ville(int id)
        {
            var _0000Ville = await _context._0000Villes.FindAsync(id);
            if (_0000Ville == null)
            {
                return NotFound();
            }

            _context._0000Villes.Remove(_0000Ville);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool _0000VilleExists(int id)
        {
            return _context._0000Villes.Any(e => e.IdVille == id);
        }
    }
}
