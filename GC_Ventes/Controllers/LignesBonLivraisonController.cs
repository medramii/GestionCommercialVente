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
    public class LignesBonLivraisonController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public LignesBonLivraisonController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/LignesBonLivraison
        [HttpGet]
        public async Task<ActionResult<IEnumerable<_0110LigneBonLivraison>>> Get_0110LigneBonLivraisons()
        {
            return await _context._0110LigneBonLivraisons.ToListAsync();
        }

        // GET: api/LignesBonLivraison/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_0110LigneBonLivraison>> Get_0110LigneBonLivraison(int id)
        {
            var _0110LigneBonLivraison = await _context._0110LigneBonLivraisons.FindAsync(id);

            if (_0110LigneBonLivraison == null)
            {
                return NotFound();
            }

            return _0110LigneBonLivraison;
        }

        // PUT: api/LignesBonLivraison/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put_0110LigneBonLivraison(int id, _0110LigneBonLivraison _0110LigneBonLivraison)
        {
            if (id != _0110LigneBonLivraison.Id)
            {
                return BadRequest();
            }

            _context.Entry(_0110LigneBonLivraison).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_0110LigneBonLivraisonExists(id))
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

        // POST: api/LignesBonLivraison
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<_0110LigneBonLivraison>> Post_0110LigneBonLivraison(_0110LigneBonLivraison _0110LigneBonLivraison)
        {
            _context._0110LigneBonLivraisons.Add(_0110LigneBonLivraison);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get_0110LigneBonLivraison", new { id = _0110LigneBonLivraison.Id }, _0110LigneBonLivraison);
        }

        // DELETE: api/LignesBonLivraison/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete_0110LigneBonLivraison(int id)
        {
            var _0110LigneBonLivraison = await _context._0110LigneBonLivraisons.FindAsync(id);
            if (_0110LigneBonLivraison == null)
            {
                return NotFound();
            }

            _context._0110LigneBonLivraisons.Remove(_0110LigneBonLivraison);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool _0110LigneBonLivraisonExists(int id)
        {
            return _context._0110LigneBonLivraisons.Any(e => e.Id == id);
        }
    }
}
