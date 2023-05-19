using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeSIcrinator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Produits",
                newName: "TypeProduit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeProduit",
                table: "Produits",
                newName: "Discriminator");
        }
    }
}
