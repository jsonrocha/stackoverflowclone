using Microsoft.EntityFrameworkCore.Migrations;

namespace stackoverflowclone.Migrations
{
    public partial class AddedVotesController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UpVote",
                table: "QuestionsTable",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DownVote",
                table: "QuestionsTable",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UpVote",
                table: "AnswersTable",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DownVote",
                table: "AnswersTable",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UpVote",
                table: "QuestionsTable",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DownVote",
                table: "QuestionsTable",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpVote",
                table: "AnswersTable",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DownVote",
                table: "AnswersTable",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
