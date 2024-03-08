using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Odev5OgrenciOtomasyonWF.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HaftNotu",
                table: "Dersler",
                newName: "HarfNotu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HarfNotu",
                table: "Dersler",
                newName: "HaftNotu");
        }
    }
}
