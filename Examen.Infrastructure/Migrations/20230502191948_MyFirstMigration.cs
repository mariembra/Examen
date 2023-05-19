using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exemples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exemples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fournissuers",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournissuers", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    ProduitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateProd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategorieFk = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Composition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NomLab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.ProduitId);
                    table.ForeignKey(
                        name: "FK_Produits_Catagories_CategorieFk",
                        column: x => x.CategorieFk,
                        principalTable: "Catagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factures",
                columns: table => new
                {
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    FournisseurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factures", x => new { x.ProduitId, x.FournisseurId });
                    table.ForeignKey(
                        name: "FK_Factures_Fournissuers_FournisseurId",
                        column: x => x.FournisseurId,
                        principalTable: "Fournissuers",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factures_Produits_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produits",
                        principalColumn: "ProduitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factures_FournisseurId",
                table: "Factures",
                column: "FournisseurId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CategorieFk",
                table: "Produits",
                column: "CategorieFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exemples");

            migrationBuilder.DropTable(
                name: "Factures");

            migrationBuilder.DropTable(
                name: "Fournissuers");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Catagories");
        }
    }
}
