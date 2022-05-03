using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MajestyApi.Data;
using MajestyApi.Models;

namespace MajestyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoriesController : ControllerBase
    {
        private readonly MajestyApiContext _context;

        public StoriesController(MajestyApiContext context)
        {
            _context = context;
        }

        // GET: api/Stories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Storie>>> GetStorie()
        {
            return await _context.Storie.ToListAsync();
        }

        // GET: api/Stories/5
        [HttpGet("{id:int}")] // note id for distinguir GetStoriesByPlot()
        public async Task<ActionResult<Storie>> GetStorie(int id)
        {
            var storie = await _context.Storie.FindAsync(id);

            if (storie == null)
            {
                return NotFound();
            }

            return storie;
        }

        /// <summary>
        /// search by plot
        /// </summary> 
        /// <param name="searchQuery"></param>
        /// <returns></returns>
        // GET: api/Stories/searchQuery
        [HttpGet("{searchQuery}")]
        
        public async Task<ActionResult<IEnumerable<Storie>>> GetStoriesByPlot([FromRoute] string? searchQuery)
        {
            searchQuery = searchQuery ?? ""; //if null assign empty value
            searchQuery =searchQuery.ToLower().Trim(); // convert to LowerCase
             
            return await _context.Storie.Where(s => s.Plot.ToLower().
                            Contains(searchQuery) ).ToListAsync();

        }
       
        // PUT: api/Stories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStorie(int id, Storie storie)
        {
            if (id != storie.ID)
            {
                return BadRequest();
            }

            _context.Entry(storie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StorieExists(id))
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

        // POST: api/Stories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Storie>> PostStorie(Storie storie)
        {
            _context.Storie.Add(storie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStorie", new { id = storie.ID }, storie);
        }

        // DELETE: api/Stories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStorie(int id)
        {
            var storie = await _context.Storie.FindAsync(id);
            if (storie == null)
            {
                return NotFound();
            }

            _context.Storie.Remove(storie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StorieExists(int id)
        {
            return _context.Storie.Any(e => e.ID == id);
        }
    }
}
