﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class oiu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userType",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "userTypeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userTypeId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "userType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
