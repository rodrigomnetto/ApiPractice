using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiPractice.Migrations
{
    public partial class InitialMigration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "users",
                newName: "Id");
        }
    }
}
