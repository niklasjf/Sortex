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
    public class TrendImagesController : ControllerBase
    {
        private readonly SortexDBContext _context;

        public TrendImagesController(SortexDBContext context)
        {
            _context = context;
        }

        // GET: api/TrendImages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrendImage>>> GetTrendImages()
        {
            return await _context.TrendImages.ToListAsync();
        }

        // GET: api/TrendImages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrendImage>> GetTrendImage(int id)
        {
            var trendImage = await _context.TrendImages.FindAsync(id);

            if (trendImage == null)
            {
                return NotFound();
            }

            return trendImage;
        }

        //// PUT: api/TrendImages/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTrendImage(int id, TrendImage trendImage)
        //{
        //    if (id != trendImage.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(trendImage).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TrendImageExists(id))
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

        //// POST: api/TrendImages
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<TrendImage>> PostTrendImage(TrendImage trendImage)
        //{
        //    _context.TrendImages.Add(trendImage);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTrendImage", new { id = trendImage.Id }, trendImage);
        //}

        //// DELETE: api/TrendImages/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTrendImage(int id)
        //{
        //    var trendImage = await _context.TrendImages.FindAsync(id);
        //    if (trendImage == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TrendImages.Remove(trendImage);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool TrendImageExists(int id)
        //{
        //    return _context.TrendImages.Any(e => e.Id == id);
        //}
    }
}
