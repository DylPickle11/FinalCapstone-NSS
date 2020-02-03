using System;

namespace Capstone.Settings
{
    public class SwaggerOptions
    {
        public string Description { get; set; }
        public string UIEndpoint { get; set; }
    }
}


//// GET: api/Attentions
//[HttpGet]
//public async Task<ActionResult<IEnumerable<Attention>>> GetAttentions()
//{
//    return await _context.Attentions.ToListAsync();
//}
//// GET: api/Attentions
//[HttpGet]
//public async Task<ActionResult<IEnumerable<Emotion>>> GetEmotions()
//{
//    return await _context.Emotions.ToListAsync();
//}
//// GET: api/Attentions
//[HttpGet]
//public async Task<ActionResult<IEnumerable<Energy>>> GetEnergies()
//{
//    return await _context.Energies.ToListAsync();
//}
//// GET: api/Attentions
//[HttpGet]
//public async Task<ActionResult<IEnumerable<Motivation>>> GetMotivations()
//{
//    return await _context.Motivations.ToListAsync();
//}
//// GET: api/Attentions
//[HttpGet]
//public async Task<ActionResult<IEnumerable<SleepQuality>>> GetSleepQualities()
//{
//    return await _context.SleepQualities.ToListAsync();
//}
//// GET: api/Social
//[HttpGet]
//public async Task<ActionResult<IEnumerable<Social>>> GetSocials()
//{
//    return await _context.Socials.ToListAsync();
//}
