using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class @as : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userTypeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "userTypeId",
                table: "Users");
        }
    }
}
