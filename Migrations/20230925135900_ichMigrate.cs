using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class ichMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    exeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.exeId);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "exeId", "MobileUrl", "Name", "VideoUrl" },
                values: new object[,]
                {
                    { 1, "mobile/WodBox Weighted Step-up.mp4", " Weighted WodBox Step-ups", "text/41 WodBox Weighted Step-up.mp4" },
                    { 2, "mobile/WodBox Jumps.mp4", "WodBox Jumps", "text/40 WodBox Jumps.mp4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");
        }
    }
}
