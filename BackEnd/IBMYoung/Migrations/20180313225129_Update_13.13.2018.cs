using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IBMYoung.Migrations
{
    public partial class Update_13132018 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "usuarioIdId",
                table: "tarefa",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "boletim",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    anoReferencia = table.Column<int>(nullable: false),
                    dataCadastro = table.Column<DateTime>(nullable: false),
                    frequencia = table.Column<float>(nullable: false),
                    mesReferencia = table.Column<string>(nullable: true),
                    nota = table.Column<float>(nullable: false),
                    observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boletim", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "funcionario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    usuarioIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionario", x => x.ID);
                    table.ForeignKey(
                        name: "FK_funcionario_usuario_usuarioIdId",
                        column: x => x.usuarioIdId,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "questao",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    conteudo = table.Column<string>(nullable: true),
                    tarefaIdId = table.Column<int>(nullable: true),
                    titulo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questao", x => x.ID);
                    table.ForeignKey(
                        name: "FK_questao_tarefa_tarefaIdId",
                        column: x => x.tarefaIdId,
                        principalTable: "tarefa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "topico",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dataCriacao = table.Column<DateTime>(nullable: false),
                    texto = table.Column<string>(nullable: true),
                    titulo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topico", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "alternativa",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    alternativaA = table.Column<string>(nullable: true),
                    alternativaB = table.Column<string>(nullable: true),
                    alternativaC = table.Column<string>(nullable: true),
                    alternativaCorreta = table.Column<string>(nullable: true),
                    alternativaD = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alternativa", x => x.ID);
                    table.ForeignKey(
                        name: "FK_alternativa_questao_ID",
                        column: x => x.ID,
                        principalTable: "questao",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "replica",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dataCriacao = table.Column<DateTime>(nullable: false),
                    texto = table.Column<string>(nullable: true),
                    topicoIdID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_replica", x => x.ID);
                    table.ForeignKey(
                        name: "FK_replica_topico_topicoIdID",
                        column: x => x.topicoIdID,
                        principalTable: "topico",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tarefa_usuarioIdId",
                table: "tarefa",
                column: "usuarioIdId");

            migrationBuilder.CreateIndex(
                name: "IX_funcionario_usuarioIdId",
                table: "funcionario",
                column: "usuarioIdId");

            migrationBuilder.CreateIndex(
                name: "IX_questao_tarefaIdId",
                table: "questao",
                column: "tarefaIdId");

            migrationBuilder.CreateIndex(
                name: "IX_replica_topicoIdID",
                table: "replica",
                column: "topicoIdID");

            migrationBuilder.AddForeignKey(
                name: "FK_tarefa_usuario_usuarioIdId",
                table: "tarefa",
                column: "usuarioIdId",
                principalTable: "usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tarefa_usuario_usuarioIdId",
                table: "tarefa");

            migrationBuilder.DropTable(
                name: "alternativa");

            migrationBuilder.DropTable(
                name: "boletim");

            migrationBuilder.DropTable(
                name: "funcionario");

            migrationBuilder.DropTable(
                name: "replica");

            migrationBuilder.DropTable(
                name: "questao");

            migrationBuilder.DropTable(
                name: "topico");

            migrationBuilder.DropIndex(
                name: "IX_tarefa_usuarioIdId",
                table: "tarefa");

            migrationBuilder.DropColumn(
                name: "usuarioIdId",
                table: "tarefa");
        }
    }
}
