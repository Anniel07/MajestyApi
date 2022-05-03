using Microsoft.EntityFrameworkCore.Migrations;

namespace MajestyApi.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Borrar",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 19, "miguel.lee@gmail.com", "Miguel", 6, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 38, "tedd.tapanez@gmail.com", "Tedd", 4, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 36, "juliet.hernandez@gmail.com", "Juliet", 1, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 30, "marcos.garcia@gmail.com", "Marcos", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 55, "tedd.hernandez@gmail.com", "Tedd", 6 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 16, "carlos.garcia@gmail.com", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 52, "jhon.hernandez@gmail.com", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 22, "jhon.doe@gmail.com", "Jhon", 5, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "brayan.hernandez@gmail.com", "Brayan", 5, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "juliet.stampton@gmail.com", "Juliet", 6, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 44, "jhon.garcia@gmail.com", "Jhon", 5, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 35, "tedd.tapanez@gmail.com", "Tedd", 4, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { "carlos.fernandez@gmail.com", "Carlos", 6, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 22, "brayan.tapanez@gmail.com", "Brayan", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 53, "miguel.stampton@gmail.com", "Miguel", 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 37, "jhon.doe@gmail.com", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 56, "jhon.lee@gmail.com", "Jhon", 4, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 18, "brayan.lee@gmail.com", "Brayan", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 53, "miguel.tapanez@gmail.com", "Miguel", 6, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 13, "marcos.fernandez@gmail.com", "Marcos", 2, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 56, "miguel.hernandez@gmail.com", "Miguel", 5, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "juliet.fernandez@gmail.com", "Juliet", 2, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 14, "juliet.doe@gmail.com", "Juliet", 2, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 51, "marcos.fernandez@gmail.com", "Marcos", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 44, "jhon.tapanez@gmail.com", "Jhon", 4, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 28, "juliet.tapanez@gmail.com", "Juliet", 5, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 27,
                column: "Age",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 27, "jhon.hernandez@gmail.com", "Jhon", 2, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "miguel.stampton@gmail.com", "Miguel", 6, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 50, "brayan.lee@gmail.com", "Brayan", 5, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 42, "brayan.stampton@gmail.com", "Brayan", 1, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 59, "miguel.tapanez@gmail.com", "Miguel", 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 58, "jhon.tapanez@gmail.com", "Jhon", 6, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 24, "marcos.fernandez@gmail.com", "Marcos", 5, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 39, "juliet.doe@gmail.com", "Juliet", 4, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "juliet.fernandez@gmail.com", "Juliet", 5, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 38, "marcos.tapanez@gmail.com", "Marcos", 1, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 49, "marcos.tapanez@gmail.com", "Marcos", 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 33, "jhon.tapanez@gmail.com", 2, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 17, "brayan.fernandez@gmail.com", "Brayan", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 17, "tedd.doe@gmail.com", "Tedd", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 33, "brayan.garcia@gmail.com", "Brayan", 2, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 57, "tedd.lee@gmail.com", "Tedd", 1, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 49, "brayan.hernandez@gmail.com", 6, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 25, "tedd.tapanez@gmail.com", "Tedd", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 31, "tedd.tapanez@gmail.com", "Tedd", 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 47, "jhon.lee@gmail.com", "Jhon", 5, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 35, "juliet.doe@gmail.com", "Juliet", 4, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 15, "juliet.fernandez@gmail.com", "Juliet", 6, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "jhon.doe@gmail.com", "Jhon", 2, "Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Borrar",
                table: "Movie");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 11, "jhon.garcia@gmail.com", "Jhon", 3, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 43, "marcos.doe@gmail.com", "Marcos", 5, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 41, "miguel.fernandez@gmail.com", "Miguel", 4, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 47, "jhon.tapanez@gmail.com", "Jhon", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 42, "brayan.hernandez@gmail.com", "Brayan", 5 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 19, "carlos.doe@gmail.com", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 58, "jhon.tapanez@gmail.com", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 17, "brayan.tapanez@gmail.com", "Brayan", 1, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 22, "carlos.tapanez@gmail.com", "Carlos", 4, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 47, "tedd.garcia@gmail.com", "Tedd", 1, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 53, "tedd.lee@gmail.com", "Tedd", 6, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 46, "marcos.hernandez@gmail.com", "Marcos", 1, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { "jhon.tapanez@gmail.com", "Jhon", 4, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 50, "marcos.doe@gmail.com", "Marcos", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 25, "tedd.stampton@gmail.com", "Tedd", 6 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 36, "jhon.fernandez@gmail.com", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 11, "brayan.stampton@gmail.com", "Brayan", 1, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 44, "miguel.doe@gmail.com", "Miguel", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "carlos.garcia@gmail.com", "Carlos", 5, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 42, "brayan.hernandez@gmail.com", "Brayan", 5, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "brayan.tapanez@gmail.com", "Brayan", 2, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 21, "marcos.garcia@gmail.com", "Marcos", 4, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "brayan.hernandez@gmail.com", "Brayan", 5, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 12, "brayan.lee@gmail.com", "Brayan", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 51, "brayan.doe@gmail.com", "Brayan", 1, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 33, "brayan.lee@gmail.com", "Brayan", 6, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 27,
                column: "Age",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 51, "carlos.doe@gmail.com", "Carlos", 1, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 48, "juliet.garcia@gmail.com", "Juliet", 2, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 11, "jhon.hernandez@gmail.com", "Jhon", 4, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 50, "tedd.garcia@gmail.com", "Tedd", 3, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 38, "marcos.tapanez@gmail.com", "Marcos", 4 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 39, "carlos.garcia@gmail.com", "Carlos", 1, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "tedd.garcia@gmail.com", "Tedd", 3, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 13, "tedd.fernandez@gmail.com", "Tedd", 2, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 59, "tedd.doe@gmail.com", "Tedd", 2, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 46, "tedd.doe@gmail.com", "Tedd", 4, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 54, "jhon.tapanez@gmail.com", "Jhon", 6 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 47, "jhon.hernandez@gmail.com", 5, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 14, "juliet.doe@gmail.com", "Juliet", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 44, "marcos.stampton@gmail.com", "Marcos", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 48, "tedd.lee@gmail.com", "Tedd", 3, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 48, "juliet.fernandez@gmail.com", "Juliet", 5, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 27, "brayan.lee@gmail.com", 3, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 11, "carlos.stampton@gmail.com", "Carlos", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 38, "brayan.tapanez@gmail.com", "Brayan", 4 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 10, "miguel.stampton@gmail.com", "Miguel", 2, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 36, "marcos.lee@gmail.com", "Marcos", 3, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "brayan.tapanez@gmail.com", "Brayan", 5, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 47, "tedd.tapanez@gmail.com", "Tedd", 4, "Tapanez" });
        }
    }
}
