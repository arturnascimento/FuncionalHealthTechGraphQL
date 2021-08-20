using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APITestGraphQL.Migrations
{
    public partial class segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DtDone",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "Erro",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Erro",
                table: "Tasks");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtDone",
                table: "Tasks",
                type: "datetime2",
                nullable: true);
        }
    }
}
