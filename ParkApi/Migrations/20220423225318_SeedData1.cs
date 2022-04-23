using Microsoft.EntityFrameworkCore.Migrations;

namespace CretaceousPark.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Activities", "Location", "Name", "Type", "YearFounded" },
                values: new object[,]
                {
                    { 2, "Hiking", "Washington", "Mt.rainier", "NP", 1915 },
                    { 3, "Surfing", "Washington", "Capedisappointment", "SP", 1936 },
                    { 4, "Snowboarding", "Washington", "Mtbaker", "SP", 1946 },
                    { 5, "Kayaking", "Wisconsin", "Wyalusing", "SP", 1926 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);
        }
    }
}
