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
    public class SocialsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SocialsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Socials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Social>>> GetSocials()
        {
            return await _context.Socials.ToListAsync();
        }
    }
}
