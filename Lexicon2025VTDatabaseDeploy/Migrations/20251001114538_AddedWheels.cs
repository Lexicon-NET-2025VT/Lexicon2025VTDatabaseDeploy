using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lexicon2025VTDatabaseDeploy.Migrations
{
    /// <inheritdoc />
    public partial class AddedWheels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NrOfWheels",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NrOfWheels",
                table: "Vehicles");
        }
    }
}
