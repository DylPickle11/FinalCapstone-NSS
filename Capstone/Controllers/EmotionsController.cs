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
    public class EmotionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmotionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Emotions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emotion>>> GetEmotions()
        {
            return await _context.Emotions.ToListAsync();
        }
    }
}
