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
    public class MotivationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MotivationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Motivations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Motivation>>> GetMotivations()
        {
            return await _context.Motivations.ToListAsync();
        }
    }
}
