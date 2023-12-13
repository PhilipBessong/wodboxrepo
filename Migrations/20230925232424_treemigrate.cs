using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class treemigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 1,
                column: "Name",
                value: "Weighted WodBox Step-ups");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "exeId", "MobileUrl", "Name", "VideoUrl" },
                values: new object[,]
                {
                    { 4, "mobile/DB Front Rack Reverse Lunges.mp4", "DB Front Rack Reverse Lunges", "text/10 DB Front Rack Reverse Lunges.mp4" },
                    { 5, "mobile/Single Arm DB Push-Press.mp4", "Single Arm DB Push-Press", "text/9 Single Arm DB Push-Press.mp4" },
                    { 6, "mobile/DB Front Rack Squat.mp4", "Dumbbell Front Rack Squat", "text/8 DB Front Rack Squat.mp4" },
                    { 7, "mobile/High Plank Drag Across.mp4", "High Plank Dumbbell Drag Across", "text/15 High Plank DB Drag Across.mp4" },
                    { 8, "mobile/KB Single Leg Romanian Deadlift.mp4", "KB Single Leg Romanian Deadlift", "text/16 KB Single Leg Romanian Deadlift.mp4" },
                    { 9, "mobile/Russian twists with DB.mp4", "Russian Twists with Dumbell", "text/17 Russian twists with DB.mp4" },
                    { 10, "mobile/Upright KB Row.mp4", "Upright Kettlebell Row", "text/18 Upright KB Row.mp4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 1,
                column: "Name",
                value: " Weighted WodBox Step-ups");
        }
    }
}
