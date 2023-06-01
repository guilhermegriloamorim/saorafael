using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAlmoxarifado.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barracas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barracas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItensEntrada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DtEntrada = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<decimal>(type: "TEXT", nullable: false),
                    Unidade = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    Observacao = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensEntrada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensEntrada_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItensSaida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DtSaida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<decimal>(type: "TEXT", nullable: false),
                    Unidade = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    Observacao = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    BarracaId = table.Column<int>(type: "INTEGER", nullable: true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensSaida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensSaida_Barracas_BarracaId",
                        column: x => x.BarracaId,
                        principalTable: "Barracas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItensSaida_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensEntrada_ItemId",
                table: "ItensEntrada",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensSaida_BarracaId",
                table: "ItensSaida",
                column: "BarracaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensSaida_ItemId",
                table: "ItensSaida",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensEntrada");

            migrationBuilder.DropTable(
                name: "ItensSaida");

            migrationBuilder.DropTable(
                name: "Barracas");

            migrationBuilder.DropTable(
                name: "Itens");
        }
    }
}
