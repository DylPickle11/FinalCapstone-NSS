﻿// <auto-generated />
using System;
using Capstone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Capstone.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Capstone.Models.Attention", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttentionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attentions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AttentionType = "Focused"
                        },
                        new
                        {
                            Id = 2,
                            AttentionType = "Distracted"
                        },
                        new
                        {
                            Id = 3,
                            AttentionType = "Calm"
                        },
                        new
                        {
                            Id = 4,
                            AttentionType = "Stressed"
                        });
                });

            modelBuilder.Entity("Capstone.Models.CheckIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttentionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmotionId")
                        .HasColumnType("int");

                    b.Property<int>("EnergyId")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseHours")
                        .HasColumnType("int");

                    b.Property<int>("Meal")
                        .HasColumnType("int");

                    b.Property<int>("MotivationId")
                        .HasColumnType("int");

                    b.Property<int>("SleepHours")
                        .HasColumnType("int");

                    b.Property<int>("SleepQualityId")
                        .HasColumnType("int");

                    b.Property<int>("SocialId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttentionId");

                    b.HasIndex("EmotionId");

                    b.HasIndex("EnergyId");

                    b.HasIndex("MotivationId");

                    b.HasIndex("SleepQualityId");

                    b.HasIndex("SocialId");

                    b.ToTable("CheckIns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AttentionId = 3,
                            DateCreated = new DateTime(2020, 2, 10, 17, 55, 39, 568, DateTimeKind.Local).AddTicks(152),
                            Description = "First Test Check In, Can't wait to see you on the other side!",
                            EmotionId = 3,
                            EnergyId = 2,
                            ExerciseHours = 0,
                            Meal = 4,
                            MotivationId = 1,
                            SleepHours = 5,
                            SleepQualityId = 2,
                            SocialId = 3,
                            UserId = "3c72d6e7-76c3-415d-8900-6b6189d179a0"
                        });
                });

            modelBuilder.Entity("Capstone.Models.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "3c72d6e7-76c3-415d-8900-6b6189d179a0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d76015b8-2d29-4698-a0a4-3f5333b1a0ae",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "admin",
                            LastName = "admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAED3MV8bzV54VoDC0U08pMOWkwfaqjO42G5xcjttFAYxpjeZZmnlqOasn5+UXdvPZLg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            StreetAddress = "123 Infinity Way",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("Capstone.Models.Data.RefreshToken", b =>
                {
                    b.Property<Guid>("TokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Invalidated")
                        .HasColumnType("bit");

                    b.Property<string>("JwtId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Used")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TokenId");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("Capstone.Models.Emotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmotionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Emotions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmotionType = "Happy"
                        },
                        new
                        {
                            Id = 2,
                            EmotionType = "Sensitive"
                        },
                        new
                        {
                            Id = 3,
                            EmotionType = "Sad"
                        },
                        new
                        {
                            Id = 4,
                            EmotionType = "Frustrated"
                        });
                });

            modelBuilder.Entity("Capstone.Models.Energy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnergyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Energies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnergyType = "Energized",
                            Ranking = 4
                        },
                        new
                        {
                            Id = 2,
                            EnergyType = "High",
                            Ranking = 3
                        },
                        new
                        {
                            Id = 3,
                            EnergyType = "Low",
                            Ranking = 2
                        },
                        new
                        {
                            Id = 4,
                            EnergyType = "Exhausted",
                            Ranking = 1
                        });
                });

            modelBuilder.Entity("Capstone.Models.Motivation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MotivationType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Motivations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MotivationType = "Motivated"
                        },
                        new
                        {
                            Id = 2,
                            MotivationType = "Unmotivated"
                        },
                        new
                        {
                            Id = 3,
                            MotivationType = "Productive"
                        },
                        new
                        {
                            Id = 4,
                            MotivationType = "Unproductive"
                        });
                });

            modelBuilder.Entity("Capstone.Models.SleepQuality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.Property<string>("SleepQualityType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SleepQualities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ranking = 4,
                            SleepQualityType = "Restful"
                        },
                        new
                        {
                            Id = 2,
                            Ranking = 3,
                            SleepQualityType = "Interrupted Sleep"
                        },
                        new
                        {
                            Id = 3,
                            Ranking = 2,
                            SleepQualityType = "Unrestful"
                        },
                        new
                        {
                            Id = 4,
                            Ranking = 1,
                            SleepQualityType = "No Sleep"
                        });
                });

            modelBuilder.Entity("Capstone.Models.Social", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SocialType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Socials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SocialType = "Conflict"
                        },
                        new
                        {
                            Id = 2,
                            SocialType = "Supportive"
                        },
                        new
                        {
                            Id = 3,
                            SocialType = "Sociable"
                        },
                        new
                        {
                            Id = 4,
                            SocialType = "Withdrawn"
                        });
                });

            modelBuilder.Entity("Capstone.Models.Therapist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Therapists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "4001 Murphy Road Suite A",
                            City = "Nashville",
                            Name = "Kat Fowler Pavin",
                            Phone = "(615)560-8728",
                            State = "Tennessee",
                            Title = "MA, ATR",
                            ZipCode = "37209"
                        },
                        new
                        {
                            Id = 2,
                            Address = "1801 West End Ave Suite 520",
                            City = "Nashville",
                            Name = "Jeffrey Jay Waller",
                            Phone = "(615)645-2458",
                            State = "Tennessee",
                            Title = "Pre-Licensed Professional",
                            ZipCode = "37203"
                        },
                        new
                        {
                            Id = 3,
                            Address = "210 25th Avenue North Suite 1220",
                            City = "Nashville",
                            Name = "Janetta Fleming",
                            Phone = "(615)987-0982",
                            State = "Tennessee",
                            Title = " Pre-Licensed Professional, RN, LPC",
                            ZipCode = "37203"
                        },
                        new
                        {
                            Id = 4,
                            City = "Nashville",
                            Name = "Ciara Collier",
                            Phone = "(629)219-2111",
                            State = "Tennessee",
                            Title = "Clinical Social Work / Therapist, LCSW",
                            ZipCode = "37214"
                        },
                        new
                        {
                            Id = 5,
                            Address = "3515 Stokesmont Rd",
                            City = "Nashville",
                            Name = "Linda Odom",
                            Phone = "(615)913-5871",
                            State = "Tennessee",
                            Title = "Psychologist",
                            ZipCode = "37215"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Child, Adolescent and Family Therapy, 510 E Iris Drive, Unit B",
                            City = "Nashville",
                            Name = "Brianna Grant",
                            Phone = "(615)247-5435 x5",
                            State = "Tennessee",
                            Title = "Clinical Social Work / Therapist, LCSW, RPT - S",
                            ZipCode = "37204"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Green Hills Family Psych 2209 Abbott Martin Rd Suite 100",
                            City = "Nashville",
                            Name = "Dr.Elisabeth Q. Sweeney",
                            Phone = "(833)643-2235 x500",
                            State = "Tennessee",
                            Title = "Psychologist, PhD, HSP, NCSP",
                            ZipCode = "37215"
                        },
                        new
                        {
                            Id = 8,
                            Address = "1105 17th Avenue South",
                            City = "Nashville",
                            Name = "Morgan Watts",
                            Phone = "(615)505-4033",
                            State = "Tennessee",
                            Title = "Licensed Professional Counselor, MTS, MEd, LPC",
                            ZipCode = "37212"
                        },
                        new
                        {
                            Id = 9,
                            Address = "3200 West End Ave Suite 500",
                            City = "Nashville",
                            Name = "Angela Simon",
                            Phone = "(615)219-1074",
                            State = "Tennessee",
                            Title = "Clinical Social Work / Therapist LCSW",
                            ZipCode = "37203"
                        },
                        new
                        {
                            Id = 10,
                            City = "Nashville",
                            Name = "Beth Diveley",
                            Phone = "(615)908-2228",
                            State = "Tennessee",
                            Title = "Clinical Social Work / Therapist LCSW",
                            ZipCode = "37205"
                        },
                        new
                        {
                            Id = 11,
                            Address = "Juliana Breeden Counseling 2021 21st Avenue South Office 439",
                            City = "Nashville",
                            Name = "Juliana Breeden",
                            Phone = "(615)392-3698",
                            State = "Tennessee",
                            Title = "Pre - Licensed Professional MMFT",
                            ZipCode = "37212"
                        },
                        new
                        {
                            Id = 12,
                            Address = "Care-N-Concern Counseling",
                            City = "Nashville",
                            Name = "Nichelle Foster",
                            Phone = "(844)296-4820",
                            State = "Tennessee",
                            Title = "Pre-licensed Professional MMFT",
                            ZipCode = "37209"
                        },
                        new
                        {
                            Id = 13,
                            Address = "Beginner's Mind Substance Abuse Counseling",
                            City = "Nashville",
                            Name = "Jeffrey Allan Browning",
                            Phone = "(615)236-6766",
                            State = "Tennessee",
                            Title = "Drug & Alcohol Counselor, LADACII",
                            ZipCode = "37205"
                        },
                        new
                        {
                            Id = 14,
                            Address = "4623 Trousdale Drive",
                            City = "Nashville",
                            Name = "Rahab Marshall",
                            Phone = "(615)640-1533",
                            State = "Tennessee",
                            Title = "Licensed Professional Counselor, MS, LPCMHSP",
                            ZipCode = "37204"
                        },
                        new
                        {
                            Id = 15,
                            Address = "115 28th Avenue North",
                            City = "Nashville",
                            Name = "Christa Casey",
                            Phone = "(859)554-0975",
                            State = "Tennessee",
                            Title = "Clinical Social Work/Therapist, LCSW, CPA",
                            ZipCode = "37203"
                        });
                });

            modelBuilder.Entity("Capstone.Models.TherapistUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TherapistId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TherapistId");

                    b.HasIndex("UserId");

                    b.ToTable("TherapistUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TherapistId = 2,
                            UserId = "3c72d6e7-76c3-415d-8900-6b6189d179a0"
                        },
                        new
                        {
                            Id = 2,
                            TherapistId = 5,
                            UserId = "3c72d6e7-76c3-415d-8900-6b6189d179a0"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Capstone.Models.CheckIn", b =>
                {
                    b.HasOne("Capstone.Models.Attention", "Attention")
                        .WithMany()
                        .HasForeignKey("AttentionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone.Models.Emotion", "Emotion")
                        .WithMany()
                        .HasForeignKey("EmotionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone.Models.Energy", "Energy")
                        .WithMany()
                        .HasForeignKey("EnergyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone.Models.Motivation", "Motivation")
                        .WithMany()
                        .HasForeignKey("MotivationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone.Models.SleepQuality", "SleepQuality")
                        .WithMany()
                        .HasForeignKey("SleepQualityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone.Models.Social", "Social")
                        .WithMany()
                        .HasForeignKey("SocialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Capstone.Models.Data.RefreshToken", b =>
                {
                    b.HasOne("Capstone.Models.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Capstone.Models.Therapist", b =>
                {
                    b.HasOne("Capstone.Models.Data.ApplicationUser", null)
                        .WithMany("Therapists")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Capstone.Models.TherapistUser", b =>
                {
                    b.HasOne("Capstone.Models.Therapist", "Therapist")
                        .WithMany()
                        .HasForeignKey("TherapistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone.Models.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Capstone.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Capstone.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Capstone.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Capstone.Models.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
