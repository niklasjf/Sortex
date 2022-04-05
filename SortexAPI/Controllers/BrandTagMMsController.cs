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
    public class BrandTagMMsController : ControllerBase
    {
        private readonly SortexDBContext _context;

        public BrandTagMMsController(SortexDBContext context)
        {
            _context = context;
        }

        // GET: api/BrandTagMMs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BrandTagMM>>> GetBrandTagMMs()
        {
            return await _context.BrandTagMMs.ToListAsync();
        }

        // GET: api/BrandTagMMs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BrandTagMM>> GetBrandTagMM(int id)
        {
            var brandTagMM = await _context.BrandTagMMs.FindAsync(id);

            if (brandTagMM == null)
            {
                return NotFound();
            }

            return brandTagMM;
        }

        //// PUT: api/BrandTagMMs/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutBrandTagMM(int id, BrandTagMM brandTagMM)
        //{
        //    if (id != brandTagMM.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(brandTagMM).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!BrandTagMMExists(id))
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

        //// POST: api/BrandTagMMs
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<BrandTagMM>> PostBrandTagMM(BrandTagMM brandTagMM)
        //{
        //    _context.BrandTagMMs.Add(brandTagMM);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetBrandTagMM", new { id = brandTagMM.Id }, brandTagMM);
        //}

        //// DELETE: api/BrandTagMMs/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteBrandTagMM(int id)
        //{
        //    var brandTagMM = await _context.BrandTagMMs.FindAsync(id);
        //    if (brandTagMM == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.BrandTagMMs.Remove(brandTagMM);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool BrandTagMMExists(int id)
        //{
        //    return _context.BrandTagMMs.Any(e => e.Id == id);
        //}
    }
}
