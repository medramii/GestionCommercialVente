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
    public class ModeReglementController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public ModeReglementController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/ModeReglement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<_1000ModeReglement>>> Get_1000ModeReglements()
        {
            return await _context._1000ModeReglements.ToListAsync();
        }

        // GET: api/ModeReglement/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_1000ModeReglement>> Get_1000ModeReglement(string id)
        {
            var _1000ModeReglement = await _context._1000ModeReglements.FindAsync(id);

            if (_1000ModeReglement == null)
            {
                return NotFound();
            }

            return _1000ModeReglement;
        }

        // PUT: api/ModeReglement/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put_1000ModeReglement(string id, _1000ModeReglement _1000ModeReglement)
        {
            if (id != _1000ModeReglement.CodeModeReg)
            {
                return BadRequest();
            }

            _context.Entry(_1000ModeReglement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_1000ModeReglementExists(id))
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

        // POST: api/ModeReglement
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<_1000ModeReglement>> Post_1000ModeReglement(_1000ModeReglement _1000ModeReglement)
        {
            _context._1000ModeReglements.Add(_1000ModeReglement);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (_1000ModeReglementExists(_1000ModeReglement.CodeModeReg))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Get_1000ModeReglement", new { id = _1000ModeReglement.CodeModeReg }, _1000ModeReglement);
        }

        // DELETE: api/ModeReglement/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete_1000ModeReglement(string id)
        {
            var _1000ModeReglement = await _context._1000ModeReglements.FindAsync(id);
            if (_1000ModeReglement == null)
            {
                return NotFound();
            }

            _context._1000ModeReglements.Remove(_1000ModeReglement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool _1000ModeReglementExists(string id)
        {
            return _context._1000ModeReglements.Any(e => e.CodeModeReg == id);
        }
    }
}
