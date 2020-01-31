using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class CheckIn
    {
        public int Id { get; set; }
        public string UserId  {get; set;}
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public int SleepHours { get; set; }
        public SleepQuality SleepQuality { get; set; }
        public int SleepQualityId  { get; set; }
        public int Meal { get; set; }
        public Emotion Emotion { get; set; }
        public int EmotionId { get; set; }
        public Energy Energy { get; set; }
        public int EnergyId { get; set; }
        public Motivation Motivation { get; set; }
        public int MotivationId { get; set; }
        public Attention Attention { get; set; }
        public int AttentionId { get; set; }
        public Social Social { get; set; }
        public int SocialId { get; set; }
        public int ExerciseHours { get; set; }

    }
}
