    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GC_Ventes.Models;
using GC_Ventes.Models.VueModels;

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

        // GET: api/Facture/NextFacture
        [HttpGet("NextFacture")]
        public async Task<ActionResult> GetNextFacture()
        {
            try
            {
                int num = 1;
                var count = _context._0110FactureComercials.Count();

                if (_context._0110FactureComercials.Any())
                {
                    var lastFac = _context._0110FactureComercials.OrderBy(x => x.Id).Last();
                    num = int.Parse(lastFac.NumFac.Substring(3)) + 1;
                }

                return Ok("FC-" + num);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
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

        // GET: api/Facture/Livraisons/5
        [HttpGet("Livraisons/{idFacture}/{codeClient}/{dateFacture}")]
        public async Task<ActionResult> GetLivraisons(int idFacture, string codeClient, DateTime dateFacture)
        {
            try
            {
                var livraisons = _context._0110BonLivraisons
                    .Where(y => 
                        y.CodeClient == codeClient
                        && (
                            y.IdFacture == idFacture
                            ||
                            (y.IdFacture == null && y.DateBl <= dateFacture)
                        )
                    )
                    .Select(x => new
                    {
                        x.Id,
                        x.NumBl,
                        Destination = x.IdDestinationNavigation != null ? x.IdDestinationNavigation.Ville : "",
                        x.DateBl,
                        x.MontantDh,
                        x.Observation,
                        facture = x.IdFacture == idFacture,
                        Client = x.CodeClientNavigation,
                        LignesBl = x._0110LigneBonLivraisons.Select(y => new
                        {
                            y.Id,
                            y.CodeArticle,
                            y.CodeMagasin,
                            y.Qte,
                            y.Prix,
                            y.Montant,
                            Article = y.CodeArticleNavigation,
                            Magasin = y.CodeMagasinNavigation,
                        }),
                    });
                    

                return Ok(livraisons);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // GET: api/Facture/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_0110FactureComercial>> Get_0110FactureComercial(int id)
        {
            var facture = _context._0110FactureComercials
                    .Where(y=>y.Id==id)
                    .Select(x => new
                    {
                        x.Id,
                        x.CodeClient,
                        x.NumFac,
                        DateFacture = x.DateFac,
                        x.DateEcheance,
                        ModeReglement = x.CodeModeReg,
                        Devise = x.IdDevise,
                        x.TauxDeChange,
                        x.MontantDevise,
                        x.MontantDh,
                        x.Observation,
                        NomClient = x.CodeClientNavigation.RaisonSociale,
                        AddressClient = x.CodeClientNavigation.Adresse,
                        DeviseDetails = x.IdDeviseNavigation,
                        ModeReglementDetails = x.CodeModeRegNavigation,
                        LignesFacture = x._0110BonLivraisons.Select(i => new {
                            Livraison = i.NumBl,
                            Date = i.DateBl,
                            Destination = i.IdDestinationNavigation.Ville,
                            TypeDeVente = i.TypeVente,
                            i.MontantDh,
                            Articles = i._0110LigneBonLivraisons.Select(j => new {
                                article = j.CodeArticleNavigation.Designation,
                                j.Qte,
                                j.Prix,
                                j.Montant
                            }),
                        })
                    });

            if (facture == null)
            {
                return NotFound();
            }

            return Ok(facture);
        }

        // PUT: api/Facture/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put_0110FactureComercial(int id, FactureCreds FactureData)
        {
            var facture = FactureData.facture;

            if (id != facture.Id)
            {
                return BadRequest();
            }

            var lvrs = _context._0110BonLivraisons.Where(x => x.IdFacture == id).ToList();
            lvrs.ForEach(e => e.IdFacture = null);

            foreach (int i in FactureData.livraisons)
            {
                var lvr = _context._0110BonLivraisons.Where(x => x.Id == i).FirstOrDefault();
                lvr.IdFacture = id;
            }

            _context.Entry(facture).State = EntityState.Modified;

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
        public async Task<ActionResult<_0110FactureComercial>> Post_0110FactureComercial(FactureCreds FactureData)
        {
            var facture = FactureData.facture;
            
            _context._0110FactureComercials.Add(facture);
            await _context.SaveChangesAsync();
            
            var id = facture.Id;

            foreach (int i in FactureData.livraisons)
            {
                var lvr = _context._0110BonLivraisons.Where(x => x.Id == i).FirstOrDefault();
                lvr.IdFacture = id;
                _context.SaveChanges();
            }

            return CreatedAtAction("Get_0110FactureComercial", new { id = facture.Id }, facture);
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

            var lvrs = _context._0110BonLivraisons.Where(x => x.IdFacture == id).ToList();
            lvrs.ForEach(e => e.IdFacture = null);

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
