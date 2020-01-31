using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "AspNetUsers",
                nullable: true);

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
                name: "CheckIns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
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
                    { 1, "Happy" },
                    { 2, "Sensitive" },
                    { 3, "Sad" },
                    { 4, "Frustrated" }
                });

            migrationBuilder.InsertData(
                table: "Energies",
                columns: new[] { "Id", "EnergyType", "Ranking" },
                values: new object[,]
                {
                    { 3, "Low", 2 },
                    { 4, "Exhausted", 1 },
                    { 1, "Energized", 4 },
                    { 2, "High", 3 }
                });

            migrationBuilder.InsertData(
                table: "Motivations",
                columns: new[] { "Id", "MotivationType" },
                values: new object[,]
                {
                    { 1, "Motivated" },
                    { 2, "Unmotivated" },
                    { 3, "Productive" },
                    { 4, "Unproductive" }
                });

            migrationBuilder.InsertData(
                table: "SleepQualities",
                columns: new[] { "Id", "Ranking", "SleepQualityType" },
                values: new object[,]
                {
                    { 1, 4, "Restful" },
                    { 2, 3, "Interrupted Sleep" },
                    { 3, 2, "Unrestful" },
                    { 4, 1, "No Sleep" }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "SocialType" },
                values: new object[,]
                {
                    { 3, "Sociable" },
                    { 1, "Conflict" },
                    { 2, "Supportive" },
                    { 4, "Withdrawn" }
                });

            migrationBuilder.InsertData(
                table: "CheckIns",
                columns: new[] { "Id", "AttentionId", "DateCreated", "Description", "EmotionId", "EnergyId", "ExerciseHours", "Meal", "MotivationId", "SleepHours", "SleepQualityId", "SocialId", "UserId" },
                values: new object[] { 1, 3, new DateTime(2020, 1, 31, 12, 7, 44, 611, DateTimeKind.Local).AddTicks(2755), "First Test Check In, Can't wait to see you on the other side!", 3, 2, 0, 4, 1, 5, 2, 3, "3c72d6e7-76c3-415d-8900-6b6189d179a0" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckIns");

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

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "AspNetUsers");
        }
    }
}
