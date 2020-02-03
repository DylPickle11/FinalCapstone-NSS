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
    public class AttentionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AttentionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Attentions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attention>>> GetAttentions()
        {
            return await _context.Attentions.ToListAsync();
        }

    }
}
