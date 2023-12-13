using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wodapi.Migrations
{
    /// <inheritdoc />
    public partial class copytwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "styleId", "styleDescription", "styleName" },
                values: new object[,]
                {
                    { 1, "Perform a specific movement for a duration of one minute, transition immediately to the next movement at the start of the following minute. Continue for x number of minutes.", "EMOM (Every Minute On the Minute)" },
                    { 2, "It consists of performing an exercise at maximum effort for 20 seconds, followed by a 10-second rest, and repeating this cycle for a total of eight rounds.", "TABATA" },
                    { 3, "Start with a set number of repetitions for an exercise and increase it with each round until you reach a designated endpoint.", "LADDER" },
                    { 4, "Alternates high-intensity exercise with rest (X number of rounds, Y amount of sec work and Z amount of rest)", "INTERVAL" },
                    { 5, "17-minute HIIT WOD 5 x exercises. Rotate stations, maximum reps per station. (3 rounds 5 min work. You have 1 minute rest after the first and second 5 min of work) total time 17 min", "FGB (Fight gone bad)" },
                    { 6, "As many rounds of specific movements as possible in X amount of time.", "AMRAP (as many rounds as possible)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "styleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "styleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "styleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "styleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "styleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "styleId",
                keyValue: 6);
        }
    }
}
