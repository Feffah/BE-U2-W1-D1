using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_U2_W1_D1.Migrations
{
    /// <inheritdoc />
    public partial class AddTrama : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Trama",
                table: "Products",
                type: "nvarchar(max)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trama",
                table: "Products");
        }
    }
}
