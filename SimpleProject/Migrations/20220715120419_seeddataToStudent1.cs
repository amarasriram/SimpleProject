using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleProject.Migrations
{
    public partial class seeddataToStudent1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Age", "FirstName", "Gender", "LastName", "TeamName" },
                values: new object[] { 22, 21, "Vaibhav", "M", "Bhatnagar", "D" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 22);
        }
    }
}
