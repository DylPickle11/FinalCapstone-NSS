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
using Microsoft.AspNetCore.Authorization;

namespace Capstone.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CheckInsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public CheckInsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        // GET: api/CheckIns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CheckIn>>> GetCheckIns()
        {

            var userId = HttpContext.GetUserId();

            return await _context.CheckIns
                .Where(u => u.UserId == userId)
                .Include(a => a.Attention)
                .Include(e => e.Emotion)
                .Include(e => e.Energy)
                .Include(e => e.Motivation)
                .Include(e => e.SleepQuality)
                .Include(e => e.Social)
                .ToListAsync();




        }

        // GET: api/CheckIns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CheckIn>> GetCheckIn(int id)
        {
            var checkIn = await _context.CheckIns
                .Include(a => a.Attention)
                .Include(e => e.Emotion)
                .Include(e => e.Energy)
                .Include(e => e.Motivation)
                .Include(e => e.SleepQuality)
                .Include(e => e.Social)
                .SingleOrDefaultAsync(i => i.Id == id);

            if (checkIn == null)
            {
                return NotFound();
            }

            return checkIn;
        }

        // PUT: api/CheckIns/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCheckIn(int id, CheckIn checkIn)
        {
            if (id != checkIn.Id)
            {
                return BadRequest();
            }

            _context.Entry(checkIn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckInExists(id))
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

        // POST: api/CheckIns
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CheckIn>> PostCheckIn(CheckIn checkIn)
        {
            _context.CheckIns.Add(checkIn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCheckIn", new { id = checkIn.Id }, checkIn);
        }

        // DELETE: api/CheckIns/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CheckIn>> DeleteCheckIn(int id)
        {
            var checkIn = await _context.CheckIns.FindAsync(id);
            if (checkIn == null)
            {
                return NotFound();
            }

            _context.CheckIns.Remove(checkIn);
            await _context.SaveChangesAsync();

            return checkIn;
        }

        private bool CheckInExists(int id)
        {
            return _context.CheckIns.Any(e => e.Id == id);
        }

    }
}
