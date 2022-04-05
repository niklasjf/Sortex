using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SortexAPI.Models;

namespace SortexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendImageMMsController : ControllerBase
    {
        private readonly SortexDBContext _context;

        public TrendImageMMsController(SortexDBContext context)
        {
            _context = context;
        }

        // GET: api/TrendImageMMs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrendImageMM>>> GetTrendImageMMs()
        {
            return await _context.TrendImageMMs.ToListAsync();
        }

        // GET: api/TrendImageMMs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrendImageMM>> GetTrendImageMM(int id)
        {
            var trendImageMM = await _context.TrendImageMMs.FindAsync(id);

            if (trendImageMM == null)
            {
                return NotFound();
            }

            return trendImageMM;
        }

        //// PUT: api/TrendImageMMs/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTrendImageMM(int id, TrendImageMM trendImageMM)
        //{
        //    if (id != trendImageMM.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(trendImageMM).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TrendImageMMExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/TrendImageMMs
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<TrendImageMM>> PostTrendImageMM(TrendImageMM trendImageMM)
        //{
        //    _context.TrendImageMMs.Add(trendImageMM);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTrendImageMM", new { id = trendImageMM.Id }, trendImageMM);
        //}

        //// DELETE: api/TrendImageMMs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTrendImageMM(int id)
        //{
        //    var trendImageMM = await _context.TrendImageMMs.FindAsync(id);
        //    if (trendImageMM == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TrendImageMMs.Remove(trendImageMM);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool TrendImageMMExists(int id)
        //{
        //    return _context.TrendImageMMs.Any(e => e.Id == id);
        //}
    }
}
