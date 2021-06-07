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
    public class WebDroitUsersController : ControllerBase
    {
        private readonly VentesContext _context;

        public WebDroitUsersController(VentesContext context)
        {
            _context = context;
        }

        // GET: api/WebDroitUsers/UserPages
        [HttpGet("UserPages/{id}")]
        public async Task<IEnumerable<WebPage>> GetUserPages(int id)
        {
            //IEnumerable<WebPage> pages = await _context.WebPages.ToListAsync();
            
            //var query = from ps in _context.WebPages
            //            select ps;
            //IEnumerable<WebPage> pages = query.ToList();

            string query = "select pg.* " +
                "from MDI_Utilisateurs usr " +
                "inner join MDI_GroupeUtilisateurs grp " +
                "on usr.ID_GROUPE = grp.ID " +
                "and usr.ID = " + id +
                "inner join Web_DroitUser rgts " +
                "on grp.ID = rgts.idGoup " +
                "inner join Web_Pages pg " +
                "on  rgts.idPage = pg.id " +
                "and rgts.droit = 1";

            IEnumerable<WebPage> pages =  _context.WebPages.FromSqlRaw(query).ToList();

            return pages;
        }

        // GET: api/WebDroitUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WebDroitUser>>> GetWebDroitUsers()
        {
            return await _context.WebDroitUsers.ToListAsync();
        }

        // GET: api/WebDroitUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WebDroitUser>> GetWebDroitUser(int id)
        {
            var webDroitUser = await _context.WebDroitUsers.FindAsync(id);

            if (webDroitUser == null)
            {
                return NotFound();
            }

            return webDroitUser;
        }

        // PUT: api/WebDroitUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebDroitUser(int id, WebDroitUser webDroitUser)
        {
            if (id != webDroitUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(webDroitUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebDroitUserExists(id))
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

        // POST: api/WebDroitUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WebDroitUser>> PostWebDroitUser(WebDroitUser webDroitUser)
        {
            _context.WebDroitUsers.Add(webDroitUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWebDroitUser", new { id = webDroitUser.Id }, webDroitUser);
        }

        // DELETE: api/WebDroitUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebDroitUser(int id)
        {
            var webDroitUser = await _context.WebDroitUsers.FindAsync(id);
            if (webDroitUser == null)
            {
                return NotFound();
            }

            _context.WebDroitUsers.Remove(webDroitUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WebDroitUserExists(int id)
        {
            return _context.WebDroitUsers.Any(e => e.Id == id);
        }
    }
}
