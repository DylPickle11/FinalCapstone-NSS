using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attentions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttentionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attentions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emotions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmotionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Energies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ranking = table.Column<int>(nullable: false),
                    EnergyType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Energies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motivations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotivationType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motivations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SleepQualities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ranking = table.Column<int>(nullable: false),
                    SleepQualityType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepQualities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    TokenId = table.Column<Guid>(nullable: false),
                    JwtId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Expires = table.Column<DateTime>(nullable: false),
                    Used = table.Column<bool>(nullable: false),
                    Invalidated = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.TokenId);
                    table.ForeignKey(
                        name: "FK_RefreshToken_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Therapists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Therapists_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckIns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(nullable: true),
                    SleepHours = table.Column<int>(nullable: false),
                    SleepQualityId = table.Column<int>(nullable: false),
                    Meal = table.Column<int>(nullable: false),
                    EmotionId = table.Column<int>(nullable: false),
                    EnergyId = table.Column<int>(nullable: false),
                    MotivationId = table.Column<int>(nullable: false),
                    AttentionId = table.Column<int>(nullable: false),
                    SocialId = table.Column<int>(nullable: false),
                    ExerciseHours = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckIns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckIns_Attentions_AttentionId",
                        column: x => x.AttentionId,
                        principalTable: "Attentions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIns_Emotions_EmotionId",
                        column: x => x.EmotionId,
                        principalTable: "Emotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIns_Energies_EnergyId",
                        column: x => x.EnergyId,
                        principalTable: "Energies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIns_Motivations_MotivationId",
                        column: x => x.MotivationId,
                        principalTable: "Motivations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIns_SleepQualities_SleepQualityId",
                        column: x => x.SleepQualityId,
                        principalTable: "SleepQualities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIns_Socials_SocialId",
                        column: x => x.SocialId,
                        principalTable: "Socials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TherapistUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TherapistId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TherapistUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TherapistUsers_Therapists_TherapistId",
                        column: x => x.TherapistId,
                        principalTable: "Therapists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TherapistUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StreetAddress", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[] { "3c72d6e7-76c3-415d-8900-6b6189d179a0", 0, "d76015b8-2d29-4698-a0a4-3f5333b1a0ae", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAED3MV8bzV54VoDC0U08pMOWkwfaqjO42G5xcjttFAYxpjeZZmnlqOasn5+UXdvPZLg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", "123 Infinity Way", false, "admin@admin.com", null });

            migrationBuilder.InsertData(
                table: "Attentions",
                columns: new[] { "Id", "AttentionType" },
                values: new object[,]
                {
                    { 1, "Focused" },
                    { 2, "Distracted" },
                    { 3, "Calm" },
                    { 4, "Stressed" }
                });

            migrationBuilder.InsertData(
                table: "Emotions",
                columns: new[] { "Id", "EmotionType" },
                values: new object[,]
                {
                    { 3, "Sad" },
                    { 4, "Frustrated" },
                    { 1, "Happy" },
                    { 2, "Sensitive" }
                });

            migrationBuilder.InsertData(
                table: "Energies",
                columns: new[] { "Id", "EnergyType", "Ranking" },
                values: new object[,]
                {
                    { 1, "Energized", 4 },
                    { 2, "High", 3 },
                    { 3, "Low", 2 },
                    { 4, "Exhausted", 1 }
                });

            migrationBuilder.InsertData(
                table: "Motivations",
                columns: new[] { "Id", "MotivationType" },
                values: new object[,]
                {
                    { 4, "Unproductive" },
                    { 1, "Motivated" },
                    { 2, "Unmotivated" },
                    { 3, "Productive" }
                });

            migrationBuilder.InsertData(
                table: "SleepQualities",
                columns: new[] { "Id", "Ranking", "SleepQualityType" },
                values: new object[,]
                {
                    { 4, 1, "No Sleep" },
                    { 3, 2, "Unrestful" },
                    { 1, 4, "Restful" },
                    { 2, 3, "Interrupted Sleep" }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "SocialType" },
                values: new object[,]
                {
                    { 1, "Conflict" },
                    { 2, "Supportive" },
                    { 3, "Sociable" },
                    { 4, "Withdrawn" }
                });

            migrationBuilder.InsertData(
                table: "Therapists",
                columns: new[] { "Id", "Address", "ApplicationUserId", "City", "Name", "Phone", "State", "Title", "ZipCode" },
                values: new object[,]
                {
                    { 14, "4623 Trousdale Drive", null, "Nashville", "Rahab Marshall", "(615)640-1533", "Tennessee", "Licensed Professional Counselor, MS, LPCMHSP", "37204" },
                    { 13, "Beginner's Mind Substance Abuse Counseling", null, "Nashville", "Jeffrey Allan Browning", "(615)236-6766", "Tennessee", "Drug & Alcohol Counselor, LADACII", "37205" },
                    { 12, "Care-N-Concern Counseling", null, "Nashville", "Nichelle Foster", "(844)296-4820", "Tennessee", "Pre-licensed Professional MMFT", "37209" },
                    { 11, "Juliana Breeden Counseling 2021 21st Avenue South Office 439", null, "Nashville", "Juliana Breeden", "(615)392-3698", "Tennessee", "Pre - Licensed Professional MMFT", "37212" },
                    { 10, null, null, "Nashville", "Beth Diveley", "(615)908-2228", "Tennessee", "Clinical Social Work / Therapist LCSW", "37205" },
                    { 9, "3200 West End Ave Suite 500", null, "Nashville", "Angela Simon", "(615)219-1074", "Tennessee", "Clinical Social Work / Therapist LCSW", "37203" },
                    { 8, "1105 17th Avenue South", null, "Nashville", "Morgan Watts", "(615)505-4033", "Tennessee", "Licensed Professional Counselor, MTS, MEd, LPC", "37212" },
                    { 5, "3515 Stokesmont Rd", null, "Nashville", "Linda Odom", "(615)913-5871", "Tennessee", "Psychologist", "37215" },
                    { 6, "Child, Adolescent and Family Therapy, 510 E Iris Drive, Unit B", null, "Nashville", "Brianna Grant", "(615)247-5435 x5", "Tennessee", "Clinical Social Work / Therapist, LCSW, RPT - S", "37204" },
                    { 4, null, null, "Nashville", "Ciara Collier", "(629)219-2111", "Tennessee", "Clinical Social Work / Therapist, LCSW", "37214" },
                    { 3, "210 25th Avenue North Suite 1220", null, "Nashville", "Janetta Fleming", "(615)987-0982", "Tennessee", " Pre-Licensed Professional, RN, LPC", "37203" },
                    { 2, "1801 West End Ave Suite 520", null, "Nashville", "Jeffrey Jay Waller", "(615)645-2458", "Tennessee", "Pre-Licensed Professional", "37203" },
                    { 1, "4001 Murphy Road Suite A", null, "Nashville", "Kat Fowler Pavin", "(615)560-8728", "Tennessee", "MA, ATR", "37209" },
                    { 7, "Green Hills Family Psych 2209 Abbott Martin Rd Suite 100", null, "Nashville", "Dr.Elisabeth Q. Sweeney", "(833)643-2235 x500", "Tennessee", "Psychologist, PhD, HSP, NCSP", "37215" },
                    { 15, "115 28th Avenue North", null, "Nashville", "Christa Casey", "(859)554-0975", "Tennessee", "Clinical Social Work/Therapist, LCSW, CPA", "37203" }
                });

            migrationBuilder.InsertData(
                table: "CheckIns",
                columns: new[] { "Id", "AttentionId", "DateCreated", "Description", "EmotionId", "EnergyId", "ExerciseHours", "Meal", "MotivationId", "SleepHours", "SleepQualityId", "SocialId", "UserId" },
                values: new object[] { 1, 3, new DateTime(2020, 2, 10, 17, 55, 39, 568, DateTimeKind.Local).AddTicks(152), "First Test Check In, Can't wait to see you on the other side!", 3, 2, 0, 4, 1, 5, 2, 3, "3c72d6e7-76c3-415d-8900-6b6189d179a0" });

            migrationBuilder.InsertData(
                table: "TherapistUsers",
                columns: new[] { "Id", "TherapistId", "UserId" },
                values: new object[] { 1, 2, "3c72d6e7-76c3-415d-8900-6b6189d179a0" });

            migrationBuilder.InsertData(
                table: "TherapistUsers",
                columns: new[] { "Id", "TherapistId", "UserId" },
                values: new object[] { 2, 5, "3c72d6e7-76c3-415d-8900-6b6189d179a0" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_AttentionId",
                table: "CheckIns",
                column: "AttentionId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_EmotionId",
                table: "CheckIns",
                column: "EmotionId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_EnergyId",
                table: "CheckIns",
                column: "EnergyId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_MotivationId",
                table: "CheckIns",
                column: "MotivationId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_SleepQualityId",
                table: "CheckIns",
                column: "SleepQualityId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIns_SocialId",
                table: "CheckIns",
                column: "SocialId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapists_ApplicationUserId",
                table: "Therapists",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapistUsers_TherapistId",
                table: "TherapistUsers",
                column: "TherapistId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapistUsers_UserId",
                table: "TherapistUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CheckIns");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "TherapistUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Attentions");

            migrationBuilder.DropTable(
                name: "Emotions");

            migrationBuilder.DropTable(
                name: "Energies");

            migrationBuilder.DropTable(
                name: "Motivations");

            migrationBuilder.DropTable(
                name: "SleepQualities");

            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropTable(
                name: "Therapists");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
