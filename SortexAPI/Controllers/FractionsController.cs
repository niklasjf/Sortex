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
    public class FractionsController : ControllerBase
    {
        private readonly SortexDBContext _context;

        public FractionsController(SortexDBContext context)
        {
            _context = context;
        }

        // GET: api/Fractions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fraction>>> GetFractions()
        {
            return await _context.Fractions.ToListAsync();
        }

        // GET: api/Fractions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fraction>> GetFraction(int id)
        {
            var fraction = await _context.Fractions.FindAsync(id);

            if (fraction == null)
            {
                return NotFound();
            }

            return fraction;
        }

        //// PUT: api/Fractions/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutFraction(int id, Fraction fraction)
        //{
        //    if (id != fraction.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(fraction).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FractionExists(id))
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

        //// POST: api/Fractions
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Fraction>> PostFraction(Fraction fraction)
        //{
        //    _context.Fractions.Add(fraction);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFraction", new { id = fraction.Id }, fraction);
        //}

        //// DELETE: api/Fractions/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteFraction(int id)
        //{
        //    var fraction = await _context.Fractions.FindAsync(id);
        //    if (fraction == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Fractions.Remove(fraction);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool FractionExists(int id)
        //{
        //    return _context.Fractions.Any(e => e.Id == id);
        //}
    }
}
