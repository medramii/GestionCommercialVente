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
    public class WebPagesController : ControllerBase
    {
        private readonly VentesContext _context;

        public WebPagesController(VentesContext context)
        {
            _context = context;
        }

        // GET: api/WebPages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WebPage>>> GetWebPages()
        {
            return await _context.WebPages.ToListAsync();
        }

        // GET: api/WebPages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WebPage>> GetWebPage(int id)
        {
            var webPage = await _context.WebPages.FindAsync(id);

            if (webPage == null)
            {
                return NotFound();
            }

            return webPage;
        }

        // PUT: api/WebPages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebPage(int id, WebPage webPage)
        {
            if (id != webPage.Id)
            {
                return BadRequest();
            }

            _context.Entry(webPage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebPageExists(id))
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

        // POST: api/WebPages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WebPage>> PostWebPage(WebPage webPage)
        {
            _context.WebPages.Add(webPage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWebPage", new { id = webPage.Id }, webPage);
        }

        // DELETE: api/WebPages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebPage(int id)
        {
            var webPage = await _context.WebPages.FindAsync(id);
            if (webPage == null)
            {
                return NotFound();
            }

            _context.WebPages.Remove(webPage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WebPageExists(int id)
        {
            return _context.WebPages.Any(e => e.Id == id);
        }
    }
}
