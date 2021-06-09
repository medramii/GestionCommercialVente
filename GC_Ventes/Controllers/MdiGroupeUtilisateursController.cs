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
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MdiGroupeUtilisateursController : ControllerBase
    {
        private readonly VentesContext _context;

        public MdiGroupeUtilisateursController(VentesContext context)
        {
            _context = context;
        }

        // GET: api/MdiGroupeUtilisateurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MdiGroupeUtilisateur>>> GetMdiGroupeUtilisateurs()
        {
            return await _context.MdiGroupeUtilisateurs.ToListAsync();
        }

        // GET: api/MdiGroupeUtilisateurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MdiGroupeUtilisateur>> GetMdiGroupeUtilisateur(int id)
        {
            var mdiGroupeUtilisateur = await _context.MdiGroupeUtilisateurs.FindAsync(id);

            if (mdiGroupeUtilisateur == null)
            {
                return NotFound();
            }

            return mdiGroupeUtilisateur;
        }

        // PUT: api/MdiGroupeUtilisateurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMdiGroupeUtilisateur(int id, MdiGroupeUtilisateur mdiGroupeUtilisateur)
        {
            if (id != mdiGroupeUtilisateur.Id)
            {
                return BadRequest();
            }

            _context.Entry(mdiGroupeUtilisateur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MdiGroupeUtilisateurExists(id))
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

        // POST: api/MdiGroupeUtilisateurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MdiGroupeUtilisateur>> PostMdiGroupeUtilisateur(MdiGroupeUtilisateur mdiGroupeUtilisateur)
        {
            _context.MdiGroupeUtilisateurs.Add(mdiGroupeUtilisateur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMdiGroupeUtilisateur", new { id = mdiGroupeUtilisateur.Id }, mdiGroupeUtilisateur);
        }

        // DELETE: api/MdiGroupeUtilisateurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMdiGroupeUtilisateur(int id)
        {
            var mdiGroupeUtilisateur = await _context.MdiGroupeUtilisateurs.FindAsync(id);
            if (mdiGroupeUtilisateur == null)
            {
                return NotFound();
            }

            _context.MdiGroupeUtilisateurs.Remove(mdiGroupeUtilisateur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MdiGroupeUtilisateurExists(int id)
        {
            return _context.MdiGroupeUtilisateurs.Any(e => e.Id == id);
        }
    }
}
