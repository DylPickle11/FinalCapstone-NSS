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
    public class EnergiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EnergiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Energies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Energy>>> GetEnergies()
        {
            return await _context.Energies.ToListAsync();
        }
    }
}
