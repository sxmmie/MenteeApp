using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MenteeApp.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mentees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    MentorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mentees_Mentors_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeetUps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(nullable: true),
                    Attendance = table.Column<int>(nullable: false),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    MeetUpStartTime = table.Column<DateTimeOffset>(nullable: false),
                    MeetUpEndTime = table.Column<DateTimeOffset>(nullable: false),
                    UpdateMeetUpTopic = table.Column<DateTimeOffset>(nullable: false),
                    MeetUpCancelled = table.Column<DateTimeOffset>(nullable: false),
                    MenteeId = table.Column<int>(nullable: true),
                    MentorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetUps_Mentees_MenteeId",
                        column: x => x.MenteeId,
                        principalTable: "Mentees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetUps_Mentors_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeetUps_MenteeId",
                table: "MeetUps",
                column: "MenteeId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetUps_MentorId",
                table: "MeetUps",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentees_MentorId",
                table: "Mentees",
                column: "MentorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetUps");

            migrationBuilder.DropTable(
                name: "Mentees");

            migrationBuilder.DropTable(
                name: "Mentors");
        }
    }
}
