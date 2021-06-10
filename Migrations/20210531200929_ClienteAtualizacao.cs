using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClienteApp.Migrations
{
    public partial class ClienteAtualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataInlusao",
                table: "Cliente");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataInclusao",
                table: "Cliente");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInlusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
