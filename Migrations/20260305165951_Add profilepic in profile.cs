using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunnersAppBackEndApi.Migrations
{
    /// <inheritdoc />
    public partial class Addprofilepicinprofile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profilepic",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profilepic",
                table: "Profiles");
        }
    }
}
