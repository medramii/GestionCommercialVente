using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GC_Ventes.Models;
using Microsoft.AspNetCore.Authorization;

namespace GC_Ventes.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class MdiUtilisateursController : ControllerBase
    {
        private readonly VentesContext _context;

        public MdiUtilisateursController(VentesContext context)
        {
            _context = context;
        }

        // GET: api/getUsers
        [Authorize]
        [HttpGet("getUsers")]
        public async Task<ActionResult<IEnumerable<MdiUtilisateur>>> GetMdiUtilisateurs()
        {
            return await _context.MdiUtilisateurs.ToListAsync();
        }

        // GET: api/getUser/5
        [Authorize]
        [HttpGet("getUser/{id}")]
        public async Task<ActionResult<MdiUtilisateur>> GetMdiUtilisateur(int id)
        {
            var mdiUtilisateur = await _context.MdiUtilisateurs.FindAsync(id);

            if (mdiUtilisateur == null)
            {
                return NotFound();
            }

            return mdiUtilisateur;
        }

        // PUT: api/MdiUtilisateurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMdiUtilisateur(int id, MdiUtilisateur mdiUtilisateur)
        {
            if (id != mdiUtilisateur.Id)
            {
                return BadRequest();
            }

            _context.Entry(mdiUtilisateur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MdiUtilisateurExists(id))
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

        // POST: api/MdiUtilisateurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MdiUtilisateur>> PostMdiUtilisateur(MdiUtilisateur mdiUtilisateur)
        {
            _context.MdiUtilisateurs.Add(mdiUtilisateur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMdiUtilisateur", new { id = mdiUtilisateur.Id }, mdiUtilisateur);
        }

        // DELETE: api/MdiUtilisateurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMdiUtilisateur(int id)
        {
            var mdiUtilisateur = await _context.MdiUtilisateurs.FindAsync(id);
            if (mdiUtilisateur == null)
            {
                return NotFound();
            }

            _context.MdiUtilisateurs.Remove(mdiUtilisateur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MdiUtilisateurExists(int id)
        {
            return _context.MdiUtilisateurs.Any(e => e.Id == id);
        }
    }
}
