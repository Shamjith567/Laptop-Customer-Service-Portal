using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LaptopAPI.Models;

namespace LaptopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopDetailController : ControllerBase
    {
        private readonly LaptopDetailContext _context;

        public LaptopDetailController(LaptopDetailContext context)
        {
            _context = context;
        }

        // GET: api/LaptopDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LaptopDetail>>> GetlaptopDetails()
        {
            return await _context.laptopDetails.ToListAsync();
        }

        // GET: api/LaptopDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LaptopDetail>> GetLaptopDetail(int id)
        {
            var laptopDetail = await _context.laptopDetails.FindAsync(id);

            if (laptopDetail == null)
            {
                return NotFound();
            }

            return laptopDetail;
        }

        // PUT: api/LaptopDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLaptopDetail(int id, LaptopDetail laptopDetail)
        {
            if (id != laptopDetail.LaptopDetailId)
            {
                return BadRequest();
            }

            _context.Entry(laptopDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaptopDetailExists(id))
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

        // POST: api/LaptopDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LaptopDetail>> PostLaptopDetail(LaptopDetail laptopDetail)
        {
            _context.laptopDetails.Add(laptopDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLaptopDetail", new { id = laptopDetail.LaptopDetailId }, laptopDetail);
        }

        // DELETE: api/LaptopDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLaptopDetail(int id)
        {
            var laptopDetail = await _context.laptopDetails.FindAsync(id);
            if (laptopDetail == null)
            {
                return NotFound();
            }

            _context.laptopDetails.Remove(laptopDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LaptopDetailExists(int id)
        {
            return _context.laptopDetails.Any(e => e.LaptopDetailId == id);
        }
    }
}
