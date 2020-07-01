using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AcoStand.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designacao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    IdUtilizador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 75, nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Localidade = table.Column<string>(maxLength: 30, nullable: false),
                    Sexo = table.Column<string>(maxLength: 9, nullable: false),
                    DataNasc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.IdUtilizador);
                });

            migrationBuilder.CreateTable(
                name: "Artigos",
                columns: table => new
                {
                    IdArtigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(maxLength: 75, nullable: false),
                    Preco = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 500, nullable: false),
                    Contacto = table.Column<string>(nullable: false),
                    Validado = table.Column<bool>(nullable: false),
                    DonoFK = table.Column<int>(nullable: false),
                    CategoriaFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artigos", x => x.IdArtigo);
                    table.ForeignKey(
                        name: "FK_Artigos_Categorias_CategoriaFK",
                        column: x => x.CategoriaFK,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artigos_Utilizadores_DonoFK",
                        column: x => x.DonoFK,
                        principalTable: "Utilizadores",
                        principalColumn: "IdUtilizador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Favoritos",
                columns: table => new
                {
                    IdFavoritos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdArtigo = table.Column<int>(nullable: false),
                    IdUtlizador = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoritos", x => x.IdFavoritos);
                    table.ForeignKey(
                        name: "FK_Favoritos_Artigos_IdArtigo",
                        column: x => x.IdArtigo,
                        principalTable: "Artigos",
                        principalColumn: "IdArtigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Favoritos_Utilizadores_IdUtlizador",
                        column: x => x.IdUtlizador,
                        principalTable: "Utilizadores",
                        principalColumn: "IdUtilizador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recursos",
                columns: table => new
                {
                    IdRecursos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designacao = table.Column<string>(nullable: false),
                    Tipo = table.Column<string>(nullable: false),
                    ArtigoFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.IdRecursos);
                    table.ForeignKey(
                        name: "FK_Recursos_Artigos_ArtigoFK",
                        column: x => x.ArtigoFK,
                        principalTable: "Artigos",
                        principalColumn: "IdArtigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "A", "3c646585-248e-450f-9b9f-c52c05a6582c", "Administrator", "ADMINISTRATOR" },
                    { "U", "8d7a7a51-d77b-4d64-96fd-ba13e156d7dc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "IdUtilizador", "DataNasc", "Localidade", "Nome", "Sexo", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Golegã", "Fred", "Masculino", "Fred" },
                    { 2, new DateTime(1990, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomar", "Tiago", "Masculino", "Tiago" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_CategoriaFK",
                table: "Artigos",
                column: "CategoriaFK");

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_DonoFK",
                table: "Artigos",
                column: "DonoFK");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_IdArtigo",
                table: "Favoritos",
                column: "IdArtigo");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_IdUtlizador",
                table: "Favoritos",
                column: "IdUtlizador");

            migrationBuilder.CreateIndex(
                name: "IX_Recursos_ArtigoFK",
                table: "Recursos",
                column: "ArtigoFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "Recursos");

            migrationBuilder.DropTable(
                name: "Artigos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Utilizadores");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "U");
        }
    }
}
