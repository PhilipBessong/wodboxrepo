using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class mj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Styles_styleId",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_styleId",
                table: "Workouts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
