using GC_Ventes.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Ventes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DashboardController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public DashboardController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/Dashboard/Ventes/2020
        [HttpGet("Ventes/{year}")]
        public async Task<ActionResult> GetVentes(int year)
        {
            try
            {
                string[] months = {
                    "-",
                    "Janvier",
                    "Février",
                    "Mars",
                    "Avril",
                    "Mai",
                    "Juin",
                    "Juillet",
                    "Août",
                    "Septembre",
                    "Octobre",
                    "Novembre",
                    "Décembre"
                };

                var Ventes = from x in _context._0110BonLivraisons
                             where x.DateBl.Value.Year == year
                             orderby x.DateBl.Value.Month
                             group x by new { x.DateBl.Value.Month }
                             into y
                             select new
                             {
                                 month = months[y.Key.Month],
                                 local = y.Sum(i => i.TypeVente == "Local" ? i.MontantDh : 0),
                                 export = y.Sum(j => j.TypeVente == "Export" ? j.MontantDh : 0)
                             };

                return Ok(Ventes);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        // GET: api/Dashboard/Livraisons/6-1-2021/6-30-2021
        [HttpGet("Livraisons/{start}/{end}")]
        public async Task<ActionResult> GetLivraisons(DateTime start, DateTime end)
        {
            try
            {
                var Livraisons = from x in _context._0110BonLivraisons
                             where x.DateBl >= start && x.DateBl <= end
                             group x by new { x.IdFacture }
                             into y
                             select new
                             {
                                 facture = y.Key.IdFacture == null ? "Non Facturé" : "Facturé",
                                 count = y.Count(),
                             };

                return Ok(Livraisons);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        // GET: api/Dashboard/TopDestinations/6-1-2021/6-30-2021
        [HttpGet("TopDestinations/{start}/{end}")]
        public async Task<ActionResult> GetTopDestinations(DateTime start, DateTime end)
        {
            try
            {
                var Livraisons = from x in _context._0110BonLivraisons
                                 where x.DateBl >= start && x.DateBl <= end
                                 group x by new { x.IdDestinationNavigation.IdVille, x.IdDestinationNavigation.Ville }
                                 into y
                                 orderby y.Count() descending
                                 select new
                                 {
                                     destination = y.Key.Ville,
                                     count = y.Count(),
                                 };

                return Ok(Livraisons);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        // GET: api/Dashboard/TopClients/6-1-2021/6-30-2021
        [HttpGet("TopClients/{start}/{end}")]
        public async Task<ActionResult> GetTopClients(DateTime start, DateTime end)
        {
            try
            {
                var Livraisons = from x in _context._0110BonLivraisons
                                 where x.DateBl >= start && x.DateBl <= end
                                 group x by new { x.CodeClientNavigation.CodeClient, x.CodeClientNavigation.RaisonSociale }
                                 into y
                                 orderby y.Count() descending
                                 select new
                                 {
                                     client = y.Key.RaisonSociale,
                                     count = y.Count(),
                                 };

                return Ok(Livraisons);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }



    }
}
