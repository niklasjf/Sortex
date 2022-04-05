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
    public class BrandImagesController : ControllerBase
    {
        private readonly SortexDBContext _context;

        public BrandImagesController(SortexDBContext context)
        {
            _context = context;
        }

        // GET: api/BrandImages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BrandImage>>> GetBrandImages()
        {
            return await _context.BrandImages.ToListAsync();
        }

        // GET: api/BrandImages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BrandImage>> GetBrandImage(int id)
        {
            var brandImage = await _context.BrandImages.FindAsync(id);

            if (brandImage == null)
            {
                return NotFound();
            }

            return brandImage;
        }

        //// PUT: api/BrandImages/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutBrandImage(int id, BrandImage brandImage)
        //{
        //    if (id != brandImage.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(brandImage).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!BrandImageExists(id))
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

        //// POST: api/BrandImages
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<BrandImage>> PostBrandImage(BrandImage brandImage)
        //{
        //    _context.BrandImages.Add(brandImage);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetBrandImage", new { id = brandImage.Id }, brandImage);
        //}

        //// DELETE: api/BrandImages/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteBrandImage(int id)
        //{
        //    var brandImage = await _context.BrandImages.FindAsync(id);
        //    if (brandImage == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.BrandImages.Remove(brandImage);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool BrandImageExists(int id)
        //{
        //    return _context.BrandImages.Any(e => e.Id == id);
        //}
    }
}
