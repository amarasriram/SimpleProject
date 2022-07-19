using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleProject.Migrations
{
    public partial class seeddataToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Age", "FirstName", "Gender", "LastName", "TeamName" },
                values: new object[,]
                {
                    { 1, 21, "Amara", "M", "Sriram", "A" },
                    { 2, 20, "Muskan", "F", "Muskan", "A" },
                    { 3, 21, "Rahul", "M", "Yadav", "A" },
                    { 4, 20, "Shraddha", "F", "Shraddha", "A" },
                    { 5, 20, "Aishwarya", "F", "Verma", "A" },
                    { 6, 20, "Shreya", "F", "", "B" },
                    { 7, 20, "Nandhita", "F", "", "B" },
                    { 8, 20, "Shashwat", "M", "", "B" },
                    { 9, 21, "Siddarth", "M", "", "B" },
                    { 10, 20, "Shriya", "F", "", "B" },
                    { 11, 21, "Sriram", "M", "", "C" },
                    { 12, 20, "Sneha", "F", "Sinha", "C" },
                    { 13, 20, "Simran", "F", "Singh", "C" },
                    { 14, 21, "Subhash", "M", "Gurjar", "C" },
                    { 15, 19, "Umeed", "F", "Chandel", "C" },
                    { 17, 20, "Pujitha", "F", "Vavilapalli", "D" },
                    { 18, 20, "Palak", "F", "Soni", "D" },
                    { 19, 21, "Saurabh", "M", "Kumar", "D" },
                    { 20, 20, "Tisha", "F", "Varshney", "D" },
                    { 21, 21, "Aman", "M", "Asati", "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 21);
        }
    }
}
