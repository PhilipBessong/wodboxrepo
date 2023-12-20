using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class goda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_userTypeId",
                table: "Users",
                column: "userTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_userTypeId",
                table: "Users",
                column: "userTypeId",
                principalTable: "UserTypes",
                principalColumn: "userTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_userTypeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_userTypeId",
                table: "Users");
        }
    }
}
