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
    public class MagasinsController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public MagasinsController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/Magasin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<_0400Magasin>>> Get_0400Magasins()
        {
            return await _context._0400Magasins.ToListAsync();
        }

        // GET: api/Magasin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_0400Magasin>> Get_0400Magasin(string id)
        {
            var _0400Magasin = await _context._0400Magasins.FindAsync(id);

            if (_0400Magasin == null)
            {
                return NotFound();
            }

            return _0400Magasin;
        }

        // PUT: api/Magasin/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put_0400Magasin(string id, _0400Magasin _0400Magasin)
        {
            if (id != _0400Magasin.CodeMagasin)
            {
                return BadRequest();
            }

            _context.Entry(_0400Magasin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_0400MagasinExists(id))
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

        // POST: api/Magasin
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<_0400Magasin>> Post_0400Magasin(_0400Magasin _0400Magasin)
        {
            _context._0400Magasins.Add(_0400Magasin);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (_0400MagasinExists(_0400Magasin.CodeMagasin))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Get_0400Magasin", new { id = _0400Magasin.CodeMagasin }, _0400Magasin);
        }

        // DELETE: api/Magasin/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete_0400Magasin(string id)
        {
            var _0400Magasin = await _context._0400Magasins.FindAsync(id);
            if (_0400Magasin == null)
            {
                return NotFound();
            }

            _context._0400Magasins.Remove(_0400Magasin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool _0400MagasinExists(string id)
        {
            return _context._0400Magasins.Any(e => e.CodeMagasin == id);
        }
    }
}
