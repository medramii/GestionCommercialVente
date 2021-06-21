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

    }
}
