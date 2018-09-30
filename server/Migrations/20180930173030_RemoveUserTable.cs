using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace stackoverflowclone.Migrations
{
    public partial class RemoveUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTable");

            migrationBuilder.DropColumn(
                name: "AnsweredBy",
                table: "QuestionsTable");

            migrationBuilder.DropColumn(
                name: "AnsweredBy",
                table: "AnswersTable");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "QuestionsTable",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "AnswersTable",
                newName: "QuestionModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswersTable_QuestionModelId",
                table: "AnswersTable",
                column: "QuestionModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswersTable_QuestionsTable_QuestionModelId",
                table: "AnswersTable",
                column: "QuestionModelId",
                principalTable: "QuestionsTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswersTable_QuestionsTable_QuestionModelId",
                table: "AnswersTable");

            migrationBuilder.DropIndex(
                name: "IX_AnswersTable_QuestionModelId",
                table: "AnswersTable");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "QuestionsTable",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "QuestionModelId",
                table: "AnswersTable",
                newName: "QuestionId");

            migrationBuilder.AddColumn<string>(
                name: "AnsweredBy",
                table: "QuestionsTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnsweredBy",
                table: "AnswersTable",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.Id);
                });
        }
    }
}
