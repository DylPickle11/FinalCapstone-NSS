using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Capstone.Data;
using Capstone.Models;
using Capstone.Models.Data;
using Microsoft.AspNetCore.Identity;
using Capstone.Helpers;

namespace Capstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TherapistUsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TherapistUsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: api/TherapistUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TherapistUser>>> GetTherapistUsers()
        {
           // var userId = HttpContext.GetUserId();

            return await _context.TherapistUsers
                .Where(u => u.UserId == "3c72d6e7-76c3-415d-8900-6b6189d179a0")
                .Include(t => t.Therapist)
                .ToListAsync();
        }

        // GET: api/TherapistUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TherapistUser>> GetTherapistUser(int id)
        {
            var therapistUser = await _context.TherapistUsers.FindAsync(id);

            if (therapistUser == null)
            {
                return NotFound();
            }

            return therapistUser;
        }

        // PUT: api/TherapistUsers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTherapistUser(int id, TherapistUser therapistUser)
        {
            if (id != therapistUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(therapistUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TherapistUserExists(id))
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

        // POST: api/TherapistUsers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TherapistUser>> PostTherapistUser(TherapistUser therapistUser)
        {
            _context.TherapistUsers.Add(therapistUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTherapistUser", new { id = therapistUser.Id }, therapistUser);
        }

        // DELETE: api/TherapistUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TherapistUser>> DeleteTherapistUser(int id)
        {
            var therapistUser = await _context.TherapistUsers.FindAsync(id);
            if (therapistUser == null)
            {
                return NotFound();
            }

            _context.TherapistUsers.Remove(therapistUser);
            await _context.SaveChangesAsync();

            return therapistUser;
        }

        private bool TherapistUserExists(int id)
        {
            return _context.TherapistUsers.Any(e => e.Id == id);
        }
    }
}
