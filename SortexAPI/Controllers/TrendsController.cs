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
    public class TrendsController : ControllerBase
    {
        private readonly SortexDBContext _context;

        public TrendsController(SortexDBContext context)
        {
            _context = context;
        }

        // GET: api/Trends
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trend>>> GetTrends()
        {
            return await _context.Trends.ToListAsync();
        }

        // GET: api/Trends/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trend>> GetTrend(int id)
        {
            var trend = await _context.Trends.FindAsync(id);

            if (trend == null)
            {
                return NotFound();
            }

            return trend;
        }

        //// PUT: api/Trends/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTrend(int id, Trend trend)
        //{
        //    if (id != trend.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(trend).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TrendExists(id))
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

        //// POST: api/Trends
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Trend>> PostTrend(Trend trend)
        //{
        //    _context.Trends.Add(trend);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTrend", new { id = trend.Id }, trend);
        //}

        //// DELETE: api/Trends/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTrend(int id)
        //{
        //    var trend = await _context.Trends.FindAsync(id);
        //    if (trend == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Trends.Remove(trend);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool TrendExists(int id)
        //{
        //    return _context.Trends.Any(e => e.Id == id);
        //}
    }
}
