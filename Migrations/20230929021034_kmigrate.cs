using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class kmigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "styleDescription",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "styleName",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "styleDescription",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "styleName",
                table: "Workouts");
        }
    }
}
