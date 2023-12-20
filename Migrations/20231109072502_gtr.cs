using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class gtr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "exeName",
                table: "Exercises",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MobileUrl",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 1,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/WodBox Weighted Step-up.mp4", "/text/41 WodBox Weighted Step-up.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 2,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/WodBox Jumps.mp4", "/text/40 WodBox Jumps.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 3,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/WodBox Step Overs.mp4", "/text/37 WodBox Step Overs.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 4,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/DB Front Rack Reverse Lunges.mp4", "/text/10 DB Front Rack Reverse Lunges.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 5,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/Single Arm DB Push-Press.mp4", "/text/9 Single Arm DB Push-Press.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 6,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/DB Front Rack Squat.mp4", "/text/8 DB Front Rack Squat.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 7,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/High Plank Drag Across.mp4", "/text/15 High Plank DB Drag Across.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 8,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/KB Single Leg Romanian Deadlift.mp4", "/text/16 KB Single Leg Romanian Deadlift.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 9,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/Russian twists with DB.mp4", "/text/17 Russian twists with DB.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 10,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "/mobile/Upright KB Row.mp4", "/text/18 Upright KB Row.mp4" });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_MobileUrl",
                table: "Exercises",
                column: "MobileUrl",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_VideoUrl",
                table: "Exercises",
                column: "VideoUrl",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Exercises_MobileUrl",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_VideoUrl",
                table: "Exercises");

            migrationBuilder.AlterColumn<string>(
                name: "exeName",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MobileUrl",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 1,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/WodBox Weighted Step-up.mp4", "text/41 WodBox Weighted Step-up.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 2,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/WodBox Jumps.mp4", "text/40 WodBox Jumps.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 3,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/WodBox Step Overs.mp4", "text/37 WodBox Step Overs.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 4,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/DB Front Rack Reverse Lunges.mp4", "text/10 DB Front Rack Reverse Lunges.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 5,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/Single Arm DB Push-Press.mp4", "text/9 Single Arm DB Push-Press.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 6,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/DB Front Rack Squat.mp4", "text/8 DB Front Rack Squat.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 7,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/High Plank Drag Across.mp4", "text/15 High Plank DB Drag Across.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 8,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/KB Single Leg Romanian Deadlift.mp4", "text/16 KB Single Leg Romanian Deadlift.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 9,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/Russian twists with DB.mp4", "text/17 Russian twists with DB.mp4" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "exeId",
                keyValue: 10,
                columns: new[] { "MobileUrl", "VideoUrl" },
                values: new object[] { "mobile/Upright KB Row.mp4", "text/18 Upright KB Row.mp4" });
        }
    }
}
