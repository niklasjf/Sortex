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
    public class ModeboardsController : ControllerBase
    {
        private readonly SortexDBContext _context;

        public ModeboardsController(SortexDBContext context)
        {
            _context = context;
        }

        // GET: api/Modeboards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modeboard>>> GetModeboards()
        {
            return await _context.Modeboards.ToListAsync();
        }

        // GET: api/Modeboards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Modeboard>> GetModeboard(int id)
        {
            var modeboard = await _context.Modeboards.FindAsync(id);

            if (modeboard == null)
            {
                return NotFound();
            }

            return modeboard;
        }

        //// PUT: api/Modeboards/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutModeboard(int id, Modeboard modeboard)
        //{
        //    if (id != modeboard.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(modeboard).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ModeboardExists(id))
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

        //// POST: api/Modeboards
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Modeboard>> PostModeboard(Modeboard modeboard)
        //{
        //    _context.Modeboards.Add(modeboard);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetModeboard", new { id = modeboard.Id }, modeboard);
        //}

        //// DELETE: api/Modeboards/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteModeboard(int id)
        //{
        //    var modeboard = await _context.Modeboards.FindAsync(id);
        //    if (modeboard == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Modeboards.Remove(modeboard);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ModeboardExists(int id)
        //{
        //    return _context.Modeboards.Any(e => e.Id == id);
        //}
    }
}
