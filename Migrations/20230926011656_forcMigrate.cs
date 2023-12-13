using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class forcMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wodCat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    styleId = table.Column<int>(type: "int", nullable: false),
                    rounds = table.Column<int>(type: "int", nullable: false),
                    mpr = table.Column<int>(type: "int", nullable: false),
                    r1m1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r1m2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r1m3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r1sets = table.Column<int>(type: "int", nullable: false),
                    r1move = table.Column<int>(type: "int", nullable: false),
                    r1rest = table.Column<int>(type: "int", nullable: false),
                    r2m1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r2m2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r2m3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r2sets = table.Column<int>(type: "int", nullable: false),
                    r2move = table.Column<int>(type: "int", nullable: false),
                    r2rest = table.Column<int>(type: "int", nullable: false),
                    r3m1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r3m2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r3m3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r3sets = table.Column<int>(type: "int", nullable: false),
                    r3move = table.Column<int>(type: "int", nullable: false),
                    r3rest = table.Column<int>(type: "int", nullable: false),
                    r4m1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r4m2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r4m3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    r4sets = table.Column<int>(type: "int", nullable: false),
                    r4move = table.Column<int>(type: "int", nullable: false),
                    r4rest = table.Column<int>(type: "int", nullable: false),
                    daDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
