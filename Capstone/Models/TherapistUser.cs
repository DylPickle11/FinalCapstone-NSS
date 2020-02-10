using Capstone.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class TherapistUser
    {
        public int Id { get; set; }
        public int TherapistId { get; set; }
        public Therapist Therapist { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
