using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiForAngular.DataAccess.Migrations
{
    public partial class DateOfJoiningChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfJoining",
                table: "Employees",
                nullable: true,
                defaultValue: "10/23/2020 16:09:41",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 23, 15, 41, 56, 274, DateTimeKind.Local).AddTicks(3543));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfJoining",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 23, 15, 41, 56, 274, DateTimeKind.Local).AddTicks(3543),
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "10/23/2020 16:09:41");
        }
    }
}
