using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunnersAppBackEndApi.Migrations
{
    /// <inheritdoc />
    public partial class addlocationtoprofile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Profiles");
        }
    }
}
