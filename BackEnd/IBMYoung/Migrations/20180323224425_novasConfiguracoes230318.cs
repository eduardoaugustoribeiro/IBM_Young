using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IBMYoung.Migrations
{
    public partial class novasConfiguracoes230318 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternativa_questao_ID",
                table: "alternativa");

            migrationBuilder.DropForeignKey(
                name: "FK_tarefa_usuario_usuarioIdId",
                table: "tarefa");

            migrationBuilder.DropColumn(
                name: "alternativaA",
                table: "alternativa");

            migrationBuilder.DropColumn(
                name: "alternativaB",
                table: "alternativa");

            migrationBuilder.DropColumn(
                name: "alternativaC",
                table: "alternativa");

            migrationBuilder.DropColumn(
                name: "alternativaD",
                table: "alternativa");

            migrationBuilder.RenameColumn(
                name: "usuarioIdId",
                table: "tarefa",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_tarefa_usuarioIdId",
                table: "tarefa",
                newName: "IX_tarefa_usuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "usuario",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "usuario",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tipo",
                table: "usuario",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "multEscolha",
                table: "tarefa",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AprendizID",
                table: "boletim",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "alternativa",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "questaoIdID",
                table: "alternativa",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "aprendiz",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dataEntrada = table.Column<DateTime>(nullable: false),
                    dataSaida = table.Column<DateTime>(nullable: false),
                    instituicaoID = table.Column<int>(nullable: true),
                    nivel = table.Column<int>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    sobrenome = table.Column<string>(nullable: true),
                    usuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aprendiz", x => x.ID);
                    table.ForeignKey(
                        name: "FK_aprendiz_instituicao_instituicaoID",
                        column: x => x.instituicaoID,
                        principalTable: "instituicao",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_aprendiz_usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_boletim_AprendizID",
                table: "boletim",
                column: "AprendizID");

            migrationBuilder.CreateIndex(
                name: "IX_alternativa_questaoIdID",
                table: "alternativa",
                column: "questaoIdID");

            migrationBuilder.CreateIndex(
                name: "IX_aprendiz_instituicaoID",
                table: "aprendiz",
                column: "instituicaoID");

            migrationBuilder.CreateIndex(
                name: "IX_aprendiz_usuarioId",
                table: "aprendiz",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_alternativa_questao_questaoIdID",
                table: "alternativa",
                column: "questaoIdID",
                principalTable: "questao",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_boletim_aprendiz_AprendizID",
                table: "boletim",
                column: "AprendizID",
                principalTable: "aprendiz",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tarefa_usuario_usuarioId",
                table: "tarefa",
                column: "usuarioId",
                principalTable: "usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_alternativa_questao_questaoIdID",
                table: "alternativa");

            migrationBuilder.DropForeignKey(
                name: "FK_boletim_aprendiz_AprendizID",
                table: "boletim");

            migrationBuilder.DropForeignKey(
                name: "FK_tarefa_usuario_usuarioId",
                table: "tarefa");

            migrationBuilder.DropTable(
                name: "aprendiz");

            migrationBuilder.DropIndex(
                name: "IX_boletim_AprendizID",
                table: "boletim");

            migrationBuilder.DropIndex(
                name: "IX_alternativa_questaoIdID",
                table: "alternativa");

            migrationBuilder.DropColumn(
                name: "tipo",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "multEscolha",
                table: "tarefa");

            migrationBuilder.DropColumn(
                name: "AprendizID",
                table: "boletim");

            migrationBuilder.DropColumn(
                name: "questaoIdID",
                table: "alternativa");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "tarefa",
                newName: "usuarioIdId");

            migrationBuilder.RenameIndex(
                name: "IX_tarefa_usuarioId",
                table: "tarefa",
                newName: "IX_tarefa_usuarioIdId");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "usuario",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "usuario",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "alternativa",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "alternativaA",
                table: "alternativa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "alternativaB",
                table: "alternativa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "alternativaC",
                table: "alternativa",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "alternativaD",
                table: "alternativa",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_alternativa_questao_ID",
                table: "alternativa",
                column: "ID",
                principalTable: "questao",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tarefa_usuario_usuarioIdId",
                table: "tarefa",
                column: "usuarioIdId",
                principalTable: "usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
