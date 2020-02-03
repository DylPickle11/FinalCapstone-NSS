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
    public class SleepQualitiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SleepQualitiesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/SleepQualities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SleepQuality>>> GetSleepQualities()
        {
            return await _context.SleepQualities.ToListAsync();
        }

    }
}
