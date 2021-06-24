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
    public class FactureController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public FactureController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/Facture
        [HttpGet]
        public async Task<ActionResult> Get_0110FactureComercials()
        {
            try
            {
                var factures = _context._0110FactureComercials
                    .Select(x => new
                    {
                        x.Id,
                        x.NumFac,
                        x.DateFac,
                        x.DateEcheance,
                        Client = x.CodeClientNavigation,
                        ModeReg = x.CodeModeRegNavigation,
                        Devise = x.IdDeviseNavigation,
                        x.TauxDeChange,
                        x.MontantDevise,
                        x.MontantDh,
                        x.Observation,
                        Bls = x._0110BonLivraisons
                            .Select(x => new
                            {
                                x.Id,
                                x.NumBl,
                                Destination = x.IdDestinationNavigation != null ? x.IdDestinationNavigation.Ville : "",
                                x.DateBl,
                                x.MontantDh,
                                x.TypeVente,
                                x.Observation
                            })
                        });

                return Ok(factures);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: api/Facture/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_0110FactureComercial>> Get_0110FactureComercial(int id)
        {
            var _0110FactureComercial = await _context._0110FactureComercials.FindAsync(id);

            if (_0110FactureComercial == null)
            {
                return NotFound();
            }

            return _0110FactureComercial;
        }

        // PUT: api/Facture/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put_0110FactureComercial(int id, _0110FactureComercial _0110FactureComercial)
        {
            if (id != _0110FactureComercial.Id)
            {
                return BadRequest();
            }

            _context.Entry(_0110FactureComercial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_0110FactureComercialExists(id))
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

        // POST: api/Facture
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<_0110FactureComercial>> Post_0110FactureComercial(_0110FactureComercial _0110FactureComercial)
        {
            _context._0110FactureComercials.Add(_0110FactureComercial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get_0110FactureComercial", new { id = _0110FactureComercial.Id }, _0110FactureComercial);
        }

        // DELETE: api/Facture/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete_0110FactureComercial(int id)
        {
            var _0110FactureComercial = await _context._0110FactureComercials.FindAsync(id);
            if (_0110FactureComercial == null)
            {
                return NotFound();
            }

            _context._0110FactureComercials.Remove(_0110FactureComercial);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool _0110FactureComercialExists(int id)
        {
            return _context._0110FactureComercials.Any(e => e.Id == id);
        }
    }
}
