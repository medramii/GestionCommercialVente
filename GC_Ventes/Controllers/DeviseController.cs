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
    public class DeviseController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public DeviseController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/Devise
        [HttpGet]
        public async Task<ActionResult<IEnumerable<_0200Devise>>> Get_0200Devises()
        {
            return await _context._0200Devises.ToListAsync();
        }

        // GET: api/Devise/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_0200Devise>> Get_0200Devise(int id)
        {
            var _0200Devise = await _context._0200Devises.FindAsync(id);

            if (_0200Devise == null)
            {
                return NotFound();
            }

            return _0200Devise;
        }

        // PUT: api/Devise/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put_0200Devise(int id, _0200Devise _0200Devise)
        {
            if (id != _0200Devise.Id)
            {
                return BadRequest();
            }

            _context.Entry(_0200Devise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_0200DeviseExists(id))
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

        // POST: api/Devise
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<_0200Devise>> Post_0200Devise(_0200Devise _0200Devise)
        {
            _context._0200Devises.Add(_0200Devise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get_0200Devise", new { id = _0200Devise.Id }, _0200Devise);
        }

        // DELETE: api/Devise/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete_0200Devise(int id)
        {
            var _0200Devise = await _context._0200Devises.FindAsync(id);
            if (_0200Devise == null)
            {
                return NotFound();
            }

            _context._0200Devises.Remove(_0200Devise);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool _0200DeviseExists(int id)
        {
            return _context._0200Devises.Any(e => e.Id == id);
        }
    }
}
