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
    public class StockController : ControllerBase
    {
        private readonly WEB_GC_Context _context;

        public StockController(WEB_GC_Context context)
        {
            _context = context;
        }

        // GET: api/Stock
        [HttpGet]
        public async Task<ActionResult> Get_0400Articles()
        {
            try
            {
                //string query = "SELECT DISTINCT " +
                //"art.id, " +
                //"stk.CodeArticle, " +
                //"stk.CodeMagasin, " +
                //"stk.Qte_Entree, " +
                //"stk.Qte_Livraison, " +
                //"stk.Qte_StockFinal " +
                //"FROM [0400_Article] art, " +
                //"[FunctionStockArticleAu]('20210626', '-', '-', '-') stk";

                string query = "SELECT " +
                "art.id, " +
                "art.designation, " +
                "art.description1, " +
                "art.stockAlerte, " +
                "art.nbrULivParUAchat, " +
                "art.modeStock, " +
                "stk.* " +
                "FROM [0400_Article] art " +
                "INNER JOIN " +
                "[FunctionStockArticleAu]('20210626', 'AC-1', '-', '-') stk " +
                "ON art.codeArticle = stk.CodeArticle";



                var stock = _context._0400Articles.FromSqlRaw(query).ToList();

                return Ok(stock);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: api/Stock/5
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

        // PUT: api/Stock/5
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

        // POST: api/Stock
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<_0400Article>> Post_0400Article(_0400Article _0400Article)
        {
            _context._0400Articles.Add(_0400Article);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get_0400Article", new { id = _0400Article.Id }, _0400Article);
        }

        // DELETE: api/Stock/5
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
