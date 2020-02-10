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
        public DbSet<Therapist> Therapists { get; set; }

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
                SleepQualityType = "Restful"
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

            Therapist therapist1 = new Therapist
            {
                Id = 1,
                Name = "Kat Fowler Pavin",
                Title = "MA, ATR",
                Address = "4001 Murphy Road Suite A",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37209",
                Phone = "(615)560-8728",
               

            };
            //therapist1.Specialities.Add("Trauma and PTSD");
            //therapist1.Specialities.Add("Relationship Issues");
            //therapist1.Specialities.Add("Anxiety");
 
            modelBuilder.Entity<Therapist>().HasData(therapist1);

            Therapist therapist2 = new Therapist
            {
                Id = 2,
                Name = "Jeffrey Jay Waller",
                Title = "Pre-Licensed Professional",
                Address = "1801 West End Ave Suite 520",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37203",
                Phone = "(615)645-2458"
               

            };
            //therapist2.Specialities.Add("Self Esteem");
            //therapist2.Specialities.Add("Depression");
            //therapist2.Specialities.Add("Anxiety");
            modelBuilder.Entity<Therapist>().HasData(therapist2);

            Therapist therapist3 = new Therapist
            {
                Id = 3,
                Name = "Janetta Fleming",
                Title = " Pre-Licensed Professional, RN, LPC",
                Address = "210 25th Avenue North Suite 1220",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37203",
                Phone = "(615)987-0982",

            };
            //therapist3.Specialities.Add("Grief Trauma and PTSD");
            //therapist3.Specialities.Add("Pregnancy");
            //therapist3.Specialities.Add("Prenatal");
            //therapist3.Specialities.Add("Postpartum");
            modelBuilder.Entity<Therapist>().HasData(therapist3);

            Therapist therapist4 = new Therapist
            {
                Id = 4,
                Name = "Ciara Collier",
                Title = "Clinical Social Work / Therapist, LCSW",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37214",
                Phone = "(629)219-2111"
            };
            //therapist4.Specialities.Add("Anxiety");
            //therapist4.Specialities.Add("Depression");
            //therapist4.Specialities.Add("Stress");

            modelBuilder.Entity<Therapist>().HasData(therapist4);

            Therapist therapist5 = new Therapist
            {
                Id = 5,
                Name = "Linda Odom",
                Title = "Psychologist",
                Address = "3515 Stokesmont Rd",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37215",
                Phone = "(615)913-5871"

            };

            modelBuilder.Entity<Therapist>().HasData(therapist5);

            Therapist therapist6 = new Therapist
            {
                Id = 6,
                Name = "Brianna Grant",
                Title = "Clinical Social Work / Therapist, LCSW, RPT - S",
                Address = "Child, Adolescent and Family Therapy, 510 E Iris Drive, Unit B",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37204",
                Phone = "(615)247-5435 x5",

            };
            //therapist6.Specialities.Add("Child or Adolescent Trauma and PTSD Grief");

            modelBuilder.Entity<Therapist>().HasData(therapist6);
            Therapist therapist7 = new Therapist
            {
                Id = 7,
                Name = "Dr.Elisabeth Q. Sweeney",
                Title = "Psychologist, PhD, HSP, NCSP",
                Address = "Green Hills Family Psych 2209 Abbott Martin Rd Suite 100",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37215",
                Phone = "(833)643-2235 x500"

            };
            //therapist7.Specialities.Add("Anxiety");
            //therapist7.Specialities.Add("Depression");
            //therapist7.Specialities.Add("Stress");
            modelBuilder.Entity<Therapist>().HasData(therapist7);

            Therapist therapist8 = new Therapist
            {
                Id = 8,
                Name = "Morgan Watts",
                Title = "Licensed Professional Counselor, MTS, MEd, LPC",
                Address = "1105 17th Avenue South",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37212",
                Phone = "(615)505-4033"
            };
            //therapist8.Specialities.Add("Anxiety");
            //therapist8.Specialities.Add("Trauma and PTSD");
            //therapist8.Specialities.Add("Relationship Isses");
            modelBuilder.Entity<Therapist>().HasData(therapist8);

            Therapist therapist9 = new Therapist
            {
                Id = 9,
                Name = "Angela Simon",
                Title = "Clinical Social Work / Therapist LCSW",
                Address = "3200 West End Ave Suite 500",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37203",
                Phone = "(615)219-1074",

            };
            //therapist9.Specialities.Add("Relationship Issues");
            //therapist9.Specialities.Add("Depression");
            //therapist9.Specialities.Add("Self Esteem");
            modelBuilder.Entity<Therapist>().HasData(therapist9);

            Therapist therapist10 = new Therapist
            {
                Id = 10,
                Name = "Beth Diveley",
                Title = "Clinical Social Work / Therapist LCSW",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37205",
                Phone = "(615)908-2228"
            };
            //therapist10.Specialities.Add("Anxiety");
            //therapist10.Specialities.Add("Depression");
            //therapist10.Specialities.Add("Substance Use");

            modelBuilder.Entity<Therapist>().HasData(therapist10);

            Therapist therapist11 = new Therapist
            {
                Id = 11,
                Name = "Juliana Breeden",
                Title = "Pre - Licensed Professional MMFT",
                Address = "Juliana Breeden Counseling 2021 21st Avenue South Office 439",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37212",
                Phone = "(615)392-3698",

            };
            //therapist11.Specialities.Add("Martial and Premarital");
            //therapist11.Specialities.Add("Relationship Issues");
            //therapist11.Specialities.Add("Depression");
            modelBuilder.Entity<Therapist>().HasData(therapist11);

            Therapist therapist12 = new Therapist
            {
                Id = 12,
                Name = "Nichelle Foster",
                Title = "Pre- icensed Professional MMFT",
                Address = "Care-N-Concern Counseling",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37209",
                Phone = "(844)296-4820",

            };
            //therapist12.Specialities.Add("Martial and Premarital");
            //therapist12.Specialities.Add("Relationship Issues");
            //therapist12.Specialities.Add("Addiction");
            modelBuilder.Entity<Therapist>().HasData(therapist12);


            Therapist therapist13 = new Therapist
            {
                Id = 13,
                Name = "Jeffrey Allan Browning",
                Title = "Drug & Alcohol Counselor, LADACII",
                Address = "Beginner's Mind Substance Abuse Counseling",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37205",
                Phone = "(615)236-6766"

            };

            //therapist13.Specialities.Add("Substance Use");
            //therapist13.Specialities.Add("Alcohol Use");
            //therapist13.Specialities.Add("Addiction");
            modelBuilder.Entity<Therapist>().HasData(therapist13);

            Therapist therapist14 = new Therapist
            {

                Id = 14,
                Name = "Rahab Marshall",
                Title = "Licensed Professional Counselor, MS, LPCMHSP",
                Address = "4623 Trousdale Drive",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37204",
                Phone = "(615)640-1533"
            };
            //therapist14.Specialities.Add("Anxiety");
            //therapist14.Specialities.Add("Parenting");
            //therapist14.Specialities.Add("Child or Adolescent");
            modelBuilder.Entity<Therapist>().HasData(therapist14);

            Therapist therapist15 = new Therapist
            {
                Id = 15,
                Name = "Christa Casey",
                Title = "Clinical Social Work/Therapist, LCSW, CPA",
                Address = "115 28th Avenue North",
                City = "Nashville",
                State = "Tennessee",
                ZipCode = "37203",
                Phone = "(859)554-0975"

            };
            //therapist15.Specialities.Add("Child or Adolescent");
            //therapist15.Specialities.Add("Anxiety");
            //therapist15.Specialities.Add("Trauma and PTSD");
            modelBuilder.Entity<Therapist>().HasData(therapist15);

        }

    }
}

