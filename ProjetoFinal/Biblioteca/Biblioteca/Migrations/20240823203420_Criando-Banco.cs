using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class CriandoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivros_Autores_AutorId",
                table: "AutorLivros");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivros_Livros_LivroId",
                table: "AutorLivros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutorLivros",
                table: "AutorLivros");

            migrationBuilder.DropIndex(
                name: "IX_AutorLivros_LivroId",
                table: "AutorLivros");

            migrationBuilder.RenameColumn(
                name: "LivroId",
                table: "AutorLivros",
                newName: "Principal");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "AutorLivros",
                newName: "CodLivro");

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Livros",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatCodigo",
                table: "Livros",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CodBarras",
                table: "Livros",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodCategoria",
                table: "Livros",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Edicao",
                table: "Livros",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PrazoMaximo",
                table: "Livros",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodAutor",
                table: "AutorLivros",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutorLivros",
                table: "AutorLivros",
                columns: new[] { "CodAutor", "CodLivro" });

            migrationBuilder.CreateTable(
                name: "Bairros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    SalarioBase = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exemplares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdLivro = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    LivCodigo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exemplares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exemplares_Livros_LivCodigo",
                        column: x => x.LivCodigo,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    RG = table.Column<string>(type: "TEXT", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", nullable: false),
                    CodEndereco = table.Column<int>(type: "INTEGER", nullable: false),
                    CodBairro = table.Column<int>(type: "INTEGER", nullable: false),
                    CodCidade = table.Column<int>(type: "INTEGER", nullable: false),
                    PrazoDevol = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Bairros_CodBairro",
                        column: x => x.CodBairro,
                        principalTable: "Bairros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Cidades_CodCidade",
                        column: x => x.CodCidade,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clientes_Enderecos_CodEndereco",
                        column: x => x.CodEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Editoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    CodEndereco = table.Column<int>(type: "INTEGER", nullable: false),
                    CodCidade = table.Column<int>(type: "INTEGER", nullable: false),
                    CodBairro = table.Column<int>(type: "INTEGER", nullable: false),
                    Contato = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Editoras_Bairros_CodBairro",
                        column: x => x.CodBairro,
                        principalTable: "Bairros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Editoras_Cidades_CodCidade",
                        column: x => x.CodCidade,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Editoras_Enderecos_CodEndereco",
                        column: x => x.CodEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    RG = table.Column<string>(type: "TEXT", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", nullable: false),
                    CodEndereco = table.Column<int>(type: "INTEGER", nullable: false),
                    CodBairro = table.Column<int>(type: "INTEGER", nullable: false),
                    CodCidade = table.Column<int>(type: "INTEGER", nullable: false),
                    CodCargo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Bairros_CodBairro",
                        column: x => x.CodBairro,
                        principalTable: "Bairros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Cargos_CodCargo",
                        column: x => x.CodCargo,
                        principalTable: "Cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Cidades_CodCidade",
                        column: x => x.CodCidade,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Enderecos_CodEndereco",
                        column: x => x.CodEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CodFuncionario = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emprestimos_Funcionarios_CodFuncionario",
                        column: x => x.CodFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CodLivro = table.Column<int>(type: "INTEGER", nullable: false),
                    CodFuncionario = table.Column<int>(type: "INTEGER", nullable: false),
                    CodCliente = table.Column<int>(type: "INTEGER", nullable: false),
                    Situacao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_CodCliente",
                        column: x => x.CodCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Funcionarios_CodFuncionario",
                        column: x => x.CodFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Livros_CodLivro",
                        column: x => x.CodLivro,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExemplarEmprestimos",
                columns: table => new
                {
                    CodExemplar = table.Column<int>(type: "INTEGER", nullable: false),
                    CodEmprestimo = table.Column<int>(type: "INTEGER", nullable: false),
                    DtPrevDevolucao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DtDevolucao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DtPrevMulta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorMulta = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExemplarEmprestimos", x => new { x.CodExemplar, x.CodEmprestimo });
                    table.ForeignKey(
                        name: "FK_ExemplarEmprestimos_Emprestimos_CodEmprestimo",
                        column: x => x.CodEmprestimo,
                        principalTable: "Emprestimos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExemplarEmprestimos_Exemplares_CodExemplar",
                        column: x => x.CodExemplar,
                        principalTable: "Exemplares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_CatCodigo",
                table: "Livros",
                column: "CatCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLivros_CodLivro",
                table: "AutorLivros",
                column: "CodLivro");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CodBairro",
                table: "Clientes",
                column: "CodBairro");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CodCidade",
                table: "Clientes",
                column: "CodCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CodEndereco",
                table: "Clientes",
                column: "CodEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Editoras_CodBairro",
                table: "Editoras",
                column: "CodBairro");

            migrationBuilder.CreateIndex(
                name: "IX_Editoras_CodCidade",
                table: "Editoras",
                column: "CodCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Editoras_CodEndereco",
                table: "Editoras",
                column: "CodEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimos_CodFuncionario",
                table: "Emprestimos",
                column: "CodFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_ExemplarEmprestimos_CodEmprestimo",
                table: "ExemplarEmprestimos",
                column: "CodEmprestimo");

            migrationBuilder.CreateIndex(
                name: "IX_Exemplares_LivCodigo",
                table: "Exemplares",
                column: "LivCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CodBairro",
                table: "Funcionarios",
                column: "CodBairro");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CodCargo",
                table: "Funcionarios",
                column: "CodCargo");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CodCidade",
                table: "Funcionarios",
                column: "CodCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CodEndereco",
                table: "Funcionarios",
                column: "CodEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CodCliente",
                table: "Reservas",
                column: "CodCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CodFuncionario",
                table: "Reservas",
                column: "CodFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CodLivro",
                table: "Reservas",
                column: "CodLivro");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivros_Autores_CodAutor",
                table: "AutorLivros",
                column: "CodAutor",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivros_Livros_CodLivro",
                table: "AutorLivros",
                column: "CodLivro",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Categorias_CatCodigo",
                table: "Livros",
                column: "CatCodigo",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivros_Autores_CodAutor",
                table: "AutorLivros");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivros_Livros_CodLivro",
                table: "AutorLivros");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Categorias_CatCodigo",
                table: "Livros");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Editoras");

            migrationBuilder.DropTable(
                name: "ExemplarEmprestimos");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Emprestimos");

            migrationBuilder.DropTable(
                name: "Exemplares");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Bairros");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Livros_CatCodigo",
                table: "Livros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutorLivros",
                table: "AutorLivros");

            migrationBuilder.DropIndex(
                name: "IX_AutorLivros_CodLivro",
                table: "AutorLivros");

            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "CatCodigo",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "CodBarras",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "CodCategoria",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Edicao",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "PrazoMaximo",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "CodAutor",
                table: "AutorLivros");

            migrationBuilder.RenameColumn(
                name: "Principal",
                table: "AutorLivros",
                newName: "LivroId");

            migrationBuilder.RenameColumn(
                name: "CodLivro",
                table: "AutorLivros",
                newName: "AutorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutorLivros",
                table: "AutorLivros",
                columns: new[] { "AutorId", "LivroId" });

            migrationBuilder.CreateIndex(
                name: "IX_AutorLivros_LivroId",
                table: "AutorLivros",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivros_Autores_AutorId",
                table: "AutorLivros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivros_Livros_LivroId",
                table: "AutorLivros",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
