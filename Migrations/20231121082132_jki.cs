using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class jki : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 2,
                column: "VideoUrl",
                value: "/finaletwo/videos/text/40 WodBox Jumps.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 3,
                column: "VideoUrl",
                value: "/finaletwo/videos/text/37 WodBox Step Overs.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 4,
                column: "VideoUrl",
                value: "/finaletwo/videos/text/10 DB Front Rack Reverse Lunges.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 5,
                column: "VideoUrl",
                value: "/finaletwo/videos/text/9 Single Arm DB Push-Press.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 6,
                column: "VideoUrl",
                value: "/finaletwo/videos/text/8 DB Front Rack Squat.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 7,
                column: "VideoUrl",
                value: "/finaletwo/videos/text/15 High Plank DB Drag Across.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 8,
                column: "VideoUrl",
                value: "/finaletwo/videos/finale - Copy/videos/text/16 KB Single Leg Romanian Deadlift.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 9,
                column: "VideoUrl",
                value: "/finaletwo/videos/text/17 Russian twists with DB.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 10,
                column: "VideoUrl",
                value: "/finaletwo/videos/text/18 Upright KB Row.mp4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 2,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/40 WodBox Jumps.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 3,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/37 WodBox Step Overs.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 4,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/10 DB Front Rack Reverse Lunges.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 5,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/9 Single Arm DB Push-Press.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 6,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/8 DB Front Rack Squat.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 7,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/15 High Plank DB Drag Across.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 8,
                column: "VideoUrl",
                value: "/finale - Copy/videos/finale - Copy/videos/text/16 KB Single Leg Romanian Deadlift.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 9,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/17 Russian twists with DB.mp4");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 10,
                column: "VideoUrl",
                value: "/finale - Copy/videos/text/18 Upright KB Row.mp4");
        }
    }
}
