using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_U2_W1_D1.Migrations
{
    /// <inheritdoc />
    public partial class FirstBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Copertina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Autore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezzo = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
