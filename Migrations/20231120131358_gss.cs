using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class gss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 1,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/wodboxweightedstepup.mp4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 1,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/41 WodBox Weighted Step-up.mp4");
        }
    }
}
