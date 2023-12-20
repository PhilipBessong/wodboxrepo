using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class secMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "exeId", "MobileUrl", "Name", "VideoUrl" },
                values: new object[] { 3, "mobile/WodBox Step Overs.mp4", "WodBox Step Overs", "text/37 WodBox Step Overs.mp4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 3);
        }
    }
}
