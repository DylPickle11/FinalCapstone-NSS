using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Capstone.Models.Data;
using Capstone.Models;

namespace Capstone.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Attention> Attentions { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }
        public DbSet<Emotion> Emotions { get; set; }
        public DbSet<Energy> Energies { get; set; }
        public DbSet<Motivation> Motivations { get; set; }
        public DbSet<SleepQuality> SleepQualities { get; set; }
        public DbSet<Social> Socials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Create Attention

            Attention attention1 = new Attention
            {
                Id = 1,
                AttentionType = "Focused"
            };
            modelBuilder.Entity<Attention>().HasData(attention1);

            Attention attention2 = new Attention
            {
                Id = 2,
                AttentionType = "Distracted"
            };
            modelBuilder.Entity<Attention>().HasData(attention2);

            Attention attention3 = new Attention
            {
                Id = 3,
                AttentionType = "Calm"
            };
            modelBuilder.Entity<Attention>().HasData(attention3);

            Attention attention4 = new Attention
            {
                Id = 4,
                AttentionType = "Stressed"
            };
            modelBuilder.Entity<Attention>().HasData(attention4);

            //Create Emotion

            Emotion emotion1 = new Emotion
            {
                Id = 1,
                EmotionType = "Happy"
            };
            modelBuilder.Entity<Emotion>().HasData(emotion1);
            
            Emotion emotion2 = new Emotion
            {
                Id = 2,
                EmotionType = "Sensitive"
            };
            modelBuilder.Entity<Emotion>().HasData(emotion2);
            Emotion emotion3 = new Emotion
            {
                Id = 3,
                EmotionType = "Sad"
            };
            modelBuilder.Entity<Emotion>().HasData(emotion3);
            Emotion emotion4 = new Emotion
            {
                Id = 4,
                EmotionType = "Frustrated"
            };
            modelBuilder.Entity<Emotion>().HasData(emotion4);



            //Create Energy
            Energy energy1 = new Energy
            {
                Id = 1,
                Ranking = 4,
                EnergyType = "Energized"
            };
            modelBuilder.Entity<Energy>().HasData(energy1);

            Energy energy2 = new Energy
            {
                Id = 2,
                Ranking = 3,
                EnergyType = "High"
            };
            modelBuilder.Entity<Energy>().HasData(energy2);

            Energy energy3 = new Energy
            {
                Id = 3,
                Ranking = 2,
                EnergyType = "Low"
            };
            modelBuilder.Entity<Energy>().HasData(energy3);

            Energy energy4 = new Energy
            {
                Id = 4,
                Ranking = 1,
                EnergyType = "Exhausted"

            };
            modelBuilder.Entity<Energy>().HasData(energy4);

            //Create Motivation
            Motivation motivation1 = new Motivation
            {
                Id = 1,
                MotivationType = "Motivated"
            };
            modelBuilder.Entity<Motivation>().HasData(motivation1);

            Motivation motivation2 = new Motivation
            {
                Id = 2,
                MotivationType = "Unmotivated"
            };
            modelBuilder.Entity<Motivation>().HasData(motivation2);

            Motivation motivation3 = new Motivation
            {
                Id = 3,
                MotivationType = "Productive"
            };
            modelBuilder.Entity<Motivation>().HasData(motivation3);

            Motivation motivation4 = new Motivation
            {
                Id = 4,
                MotivationType = "Unproductive"
            };
            modelBuilder.Entity<Motivation>().HasData(motivation4);


            //Create SleepQuality
            SleepQuality sleepQuality1 = new SleepQuality
            {
                Id = 1,
                Ranking = 4,
                SleepQualityType= "Restful"
            };
            modelBuilder.Entity<SleepQuality>().HasData(sleepQuality1);

            SleepQuality sleepQuality2 = new SleepQuality
            {
                Id = 2,
                Ranking = 3,
                SleepQualityType = "Interrupted Sleep"
            };
            modelBuilder.Entity<SleepQuality>().HasData(sleepQuality2);

            SleepQuality sleepQuality3 = new SleepQuality
            {
                Id = 3,
                Ranking = 2,
                SleepQualityType = "Unrestful"
            };
            modelBuilder.Entity<SleepQuality>().HasData(sleepQuality3);

            SleepQuality sleepQuality4 = new SleepQuality
            {
                Id = 4,
                Ranking = 1,
                SleepQualityType = "No Sleep"
            };
            modelBuilder.Entity<SleepQuality>().HasData(sleepQuality4);


            //Create Social
            Social social1 = new Social
            {
                Id = 1,
                SocialType = "Conflict"
            };
            modelBuilder.Entity<Social>().HasData(social1);

            Social social2 = new Social
            {
                Id = 2,
                SocialType = "Supportive"
            };
            modelBuilder.Entity<Social>().HasData(social2);

            Social social3 = new Social
            {
                Id = 3,
                SocialType = "Sociable"
            };
            modelBuilder.Entity<Social>().HasData(social3);

            Social social4 = new Social
            {
                Id = 4,
                SocialType = "Withdrawn"
            };
            modelBuilder.Entity<Social>().HasData(social4);

            //Create CheckIns
            CheckIn checkIn1 = new CheckIn
            {
                Id = 1,
                UserId = "3c72d6e7-76c3-415d-8900-6b6189d179a0",
                DateCreated = DateTime.Now,
                Description = "First Test Check In, Can't wait to see you on the other side!",
                SleepHours = 5,
                SleepQualityId = 2,
                Meal = 4,
                EmotionId = 3,
                EnergyId = 2,
                MotivationId = 1,
                AttentionId = 3,
                SocialId = 3
            };
            modelBuilder.Entity<CheckIn>().HasData(checkIn1);
        }

    }
}
