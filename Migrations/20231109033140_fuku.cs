using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class fuku : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_userTypeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropIndex(
                name: "IX_Users_userTypeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "userTypeId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "userType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userType",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "userTypeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    userTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.userTypeId);
                });

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
    }
}
