using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class copyMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "styleDescription",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "styleName",
                table: "Workouts");

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    styleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    styleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    styleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.styleId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_styleId",
                table: "Workouts",
                column: "styleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Styles_styleId",
                table: "Workouts",
                column: "styleId",
                principalTable: "Styles",
                principalColumn: "styleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Styles_styleId",
                table: "Workouts");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_styleId",
                table: "Workouts");

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
    }
}
