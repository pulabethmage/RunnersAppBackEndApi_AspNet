using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunnersAppBackEndApi.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    activityid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profileid = table.Column<int>(type: "int", nullable: false),
                    activity_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eventid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.activityid);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    eventid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    event_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    event_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    event_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    event_description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.eventid);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    performannceid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vo2max = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.performannceid);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    profileid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    performannceid = table.Column<int>(type: "int", nullable: false),
                    profileimage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.profileid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
