using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Capstone.Data;
using Capstone.Models;

namespace Capstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TherapistsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TherapistsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Therapists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Therapist>>> GetTherapists()
        {
            return await _context.Therapists.ToListAsync();
        }

        // GET: api/Therapists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Therapist>> GetTherapist(int id)
        {
            var therapist = await _context.Therapists.FindAsync(id);

            if (therapist == null)
            {
                return NotFound();
            }

            return therapist;
        }

        // PUT: api/Therapists/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTherapist(int id, Therapist therapist)
        {
            if (id != therapist.Id)
            {
                return BadRequest();
            }

            _context.Entry(therapist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TherapistExists(id))
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

        // POST: api/Therapists
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Therapist>> PostTherapist(Therapist therapist)
        {
            _context.Therapists.Add(therapist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTherapist", new { id = therapist.Id }, therapist);
        }

        // DELETE: api/Therapists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Therapist>> DeleteTherapist(int id)
        {
            var therapist = await _context.Therapists.FindAsync(id);
            if (therapist == null)
            {
                return NotFound();
            }

            _context.Therapists.Remove(therapist);
            await _context.SaveChangesAsync();

            return therapist;
        }

        private bool TherapistExists(int id)
        {
            return _context.Therapists.Any(e => e.Id == id);
        }
    }
}
