using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.Migrations
{
    public partial class Therapist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "CheckIns",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 2, 9, 16, 2, 34, 143, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.InsertData(
                table: "Therapists",
                columns: new[] { "Id", "Address", "ApplicationUserId", "City", "Name", "Phone", "State", "Title", "ZipCode" },
                values: new object[,]
                {
                    { 1, "4001 Murphy Road Suite A", null, "Nashville", "Kat Fowler Pavin", "(615)560-8728", "Tennessee", "MA, ATR", "37209" },
                    { 2, "1801 West End Ave Suite 520", null, "Nashville", "Jeffrey Jay Waller", "(615)645-2458", "Tennessee", "Pre-Licensed Professional", "37203" },
                    { 3, "210 25th Avenue North Suite 1220", null, "Nashville", "Janetta Fleming", "(615)987-0982", "Tennessee", " Pre-Licensed Professional, RN, LPC", "37203" },
                    { 4, null, null, "Nashville", "Ciara Collier", "(629)219-2111", "Tennessee", "Clinical Social Work / Therapist, LCSW", "37214" },
                    { 5, "3515 Stokesmont Rd", null, "Nashville", "Linda Odom", "(615)913-5871", "Tennessee", "Psychologist", "37215" },
                    { 6, "Child, Adolescent and Family Therapy, 510 E Iris Drive, Unit B", null, "Nashville", "Brianna Grant", "(615)247-5435 x5", "Tennessee", "Clinical Social Work / Therapist, LCSW, RPT - S", "37204" },
                    { 7, "Green Hills Family Psych 2209 Abbott Martin Rd Suite 100", null, "Nashville", "Dr.Elisabeth Q. Sweeney", "(833)643-2235 x500", "Tennessee", "Psychologist, PhD, HSP, NCSP", "37215" },
                    { 8, "1105 17th Avenue South", null, "Nashville", "Morgan Watts", "(615)505-4033", "Tennessee", "Licensed Professional Counselor, MTS, MEd, LPC", "37212" },
                    { 9, "3200 West End Ave Suite 500", null, "Nashville", "Angela Simon", "(615)219-1074", "Tennessee", "Clinical Social Work / Therapist LCSW", "37203" },
                    { 10, null, null, "Nashville", "Beth Diveley", "(615)908-2228", "Tennessee", "Clinical Social Work / Therapist LCSW", "37205" },
                    { 11, "Juliana Breeden Counseling 2021 21st Avenue South Office 439", null, "Nashville", "Juliana Breeden", "(615)392-3698", "Tennessee", "Pre - Licensed Professional MMFT", "37212" },
                    { 12, "Care-N-Concern Counseling", null, "Nashville", "Nichelle Foster", "(844)296-4820", "Tennessee", "Pre- icensed Professional MMFT", "37209" },
                    { 13, "Beginner's Mind Substance Abuse Counseling", null, "Nashville", "Jeffrey Allan Browning", "(615)236-6766", "Tennessee", "Drug & Alcohol Counselor, LADACII", "37205" },
                    { 14, "4623 Trousdale Drive", null, "Nashville", "Rahab Marshall", "(615)640-1533", "Tennessee", "Licensed Professional Counselor, MS, LPCMHSP", "37204" },
                    { 15, "115 28th Avenue North", null, "Nashville", "Christa Casey", "(859)554-0975", "Tennessee", "Clinical Social Work/Therapist, LCSW, CPA", "37203" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Therapists_ApplicationUserId",
                table: "Therapists",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Therapists");

            migrationBuilder.UpdateData(
                table: "CheckIns",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 1, 31, 12, 7, 44, 611, DateTimeKind.Local).AddTicks(2755));
        }
    }
}
