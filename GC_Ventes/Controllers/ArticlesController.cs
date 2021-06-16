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
    public class ArticlesController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public ArticlesController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/Article
        [HttpGet]
        public async Task<ActionResult<IEnumerable<_0400Article>>> Get_0400Articles()
        {
            return await _context._0400Articles.ToListAsync();
        }

        // GET: api/Article/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_0400Article>> Get_0400Article(int id)
        {
            var _0400Article = await _context._0400Articles.FindAsync(id);

            if (_0400Article == null)
            {
                return NotFound();
            }

            return _0400Article;
        }

        // PUT: api/Article/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put_0400Article(int id, _0400Article _0400Article)
        {
            if (id != _0400Article.Id)
            {
                return BadRequest();
            }

            _context.Entry(_0400Article).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_0400ArticleExists(id))
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

        // POST: api/Article
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<_0400Article>> Post_0400Article(_0400Article _0400Article)
        {
            _context._0400Articles.Add(_0400Article);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get_0400Article", new { id = _0400Article.Id }, _0400Article);
        }

        // DELETE: api/Article/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete_0400Article(int id)
        {
            var _0400Article = await _context._0400Articles.FindAsync(id);
            if (_0400Article == null)
            {
                return NotFound();
            }

            _context._0400Articles.Remove(_0400Article);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool _0400ArticleExists(int id)
        {
            return _context._0400Articles.Any(e => e.Id == id);
        }
    }
}
