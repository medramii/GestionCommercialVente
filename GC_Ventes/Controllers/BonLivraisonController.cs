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
    public class BonLivraisonController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public BonLivraisonController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/BonLivraison/NextBl
        [HttpGet("NextBl")]
        public async Task<ActionResult> GetNextBl()
        {
            try
            {
                var lastBl = _context._0110BonLivraisons.OrderBy(x=>x.Id).Last();
                int num = 1;
                if (lastBl != null)
                {
                    num = int.Parse(lastBl.NumBl.Substring(3)) + 1;
                }

                return Ok("BL-"+num);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // GET: api/BonLivraison
        [HttpGet]
        public async Task<ActionResult> Get_0110BonLivraisons()
        {
            try
            {
                var BLs = _context._0110BonLivraisons
                .Include(x => x.CodeClientNavigation)
                .Include(y => y.IdDestinationNavigation)
                .Include(z => z._0110LigneBonLivraisons)
                .ThenInclude(j => j.CodeArticleNavigation)
                .Include(k => k._0110LigneBonLivraisons)
                .ThenInclude(l => l.CodeMagasinNavigation);

                return Ok(BLs);
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }

        // GET: api/BonLivraison/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_0110BonLivraison>> Get_0110BonLivraison(int id)
        {
            var _0110BonLivraison = await _context._0110BonLivraisons.FindAsync(id);

            if (_0110BonLivraison == null)
            {
                return NotFound();
            }

            return _0110BonLivraison;
        }

        // PUT: api/BonLivraison/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put_0110BonLivraison(int id, _0110BonLivraison _0110BonLivraison)
        {
            if (id != _0110BonLivraison.Id)
            {
                return BadRequest();
            }

            _context.Entry(_0110BonLivraison).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_0110BonLivraisonExists(id))
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

        // POST: api/BonLivraison
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<_0110BonLivraison>> Post_0110BonLivraison(_0110BonLivraison _0110BonLivraison)
        {
            _context._0110BonLivraisons.Add(_0110BonLivraison);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get_0110BonLivraison", new { id = _0110BonLivraison.Id }, _0110BonLivraison);
        }

        // DELETE: api/BonLivraison/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete_0110BonLivraison(int id)
        {
            var _0110BonLivraison = await _context._0110BonLivraisons.FindAsync(id);
            if (_0110BonLivraison == null)
            {
                return NotFound();
            }

            _context._0110BonLivraisons.Remove(_0110BonLivraison);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool _0110BonLivraisonExists(int id)
        {
            return _context._0110BonLivraisons.Any(e => e.Id == id);
        }
    }
}
