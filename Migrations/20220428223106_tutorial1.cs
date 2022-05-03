using Microsoft.EntityFrameworkCore.Migrations;

namespace MajestyApi.Migrations
{
    public partial class tutorial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 27, "carlos.lee@gmail.com", "Carlos", 5 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 20, "jhon.hernandez@gmail.com", "Jhon", 3, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 13, "carlos.fernandez@gmail.com", "Carlos", 4 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "marcos.hernandez@gmail.com", "Marcos", 2, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Email", "Grade", "LastName" },
                values: new object[] { "tedd.fernandez@gmail.com", 3, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 14, "carlos.garcia@gmail.com", "Carlos", 5 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 20, "brayan.stampton@gmail.com", "Brayan", 4, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 32, "jhon.lee@gmail.com", "Jhon", 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 45, "jhon.tapanez@gmail.com", "Jhon", 6, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 40, "juliet.lee@gmail.com", "Juliet", 5, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 40, "marcos.garcia@gmail.com", "Marcos", 4, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 38, "marcos.fernandez@gmail.com", "Marcos", 4, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 44, "carlos.hernandez@gmail.com", "Carlos", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 57, "brayan.hernandez@gmail.com", "Brayan", 1, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 32, "miguel.stampton@gmail.com", 3, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 21, "jhon.stampton@gmail.com", "Jhon", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 41, "juliet.lee@gmail.com", "Juliet", 6, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 26, "carlos.garcia@gmail.com", "Carlos", 4, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 40, "marcos.tapanez@gmail.com", "Marcos", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 59, "juliet.garcia@gmail.com", "Juliet", 5, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 17, "jhon.stampton@gmail.com", 6, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 14, "jhon.lee@gmail.com", "Jhon", 5, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 25, "juliet.stampton@gmail.com", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { "tedd.hernandez@gmail.com", "Tedd", 2, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 38, "tedd.lee@gmail.com", "Tedd", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 12, "marcos.stampton@gmail.com", "Marcos", 6, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 52, "juliet.doe@gmail.com", "Juliet", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 19, "miguel.doe@gmail.com", "Miguel", 1, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 28, "miguel.stampton@gmail.com", "Miguel", 3, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 50, "carlos.fernandez@gmail.com", "Carlos", 1, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 56, "marcos.tapanez@gmail.com", "Marcos", 5, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Age", "Email", "FirstName" },
                values: new object[] { 26, "brayan.doe@gmail.com", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 40, "tedd.fernandez@gmail.com", "Tedd", 1, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 12, "juliet.doe@gmail.com", "Juliet", 3, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 59, "miguel.hernandez@gmail.com", "Miguel", 6, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 14, "juliet.tapanez@gmail.com", "Juliet", 6, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 41, "carlos.hernandez@gmail.com", "Carlos", 5 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 47, "marcos.fernandez@gmail.com", "Marcos", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 18, "juliet.garcia@gmail.com", "Juliet", 6, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 43, "marcos.hernandez@gmail.com", "Marcos", 6, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 55, "marcos.hernandez@gmail.com", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 18, "tedd.doe@gmail.com", "Tedd", 4, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 45, "miguel.tapanez@gmail.com", "Miguel", 2, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 16, "tedd.lee@gmail.com", "Tedd", 6, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 26, "marcos.doe@gmail.com", "Marcos", 1, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 51, "tedd.stampton@gmail.com", "Tedd", 6, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 14, "miguel.stampton@gmail.com", "Miguel", 4 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 39, "juliet.hernandez@gmail.com", "Juliet", 3, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "miguel.hernandez@gmail.com", "Miguel", 5, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "juliet.tapanez@gmail.com", "Juliet", 3, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Doe", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", false, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 10,
                column: "Title",
                value: "Brayan");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 11,
                column: "Title",
                value: "Juliet");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Doe", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", true, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Doe", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", true, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 19,
                column: "Description",
                value: "Fernandez");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 20,
                column: "Title",
                value: "Miguel");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 22,
                column: "Published",
                value: true);

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Stampton", true });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 26,
                column: "Description",
                value: "Garcia");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", false, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", false, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 36,
                column: "Title",
                value: "Juliet");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Hernandez", false });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", false, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", true, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", true, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", false, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", true, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", false, "Juliet" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 46, "marcos.lee@gmail.com", "Marcos", 3 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "miguel.tapanez@gmail.com", "Miguel", 5, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 32, "miguel.fernandez@gmail.com", "Miguel", 5 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 31, "juliet.lee@gmail.com", "Juliet", 5, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Email", "Grade", "LastName" },
                values: new object[] { "tedd.hernandez@gmail.com", 6, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 17, "miguel.garcia@gmail.com", "Miguel", 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 45, "marcos.doe@gmail.com", "Marcos", 3, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 23, "carlos.lee@gmail.com", "Carlos", 3 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 52, "tedd.fernandez@gmail.com", "Tedd", 5, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 14, "miguel.doe@gmail.com", "Miguel", 6, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 14, "juliet.stampton@gmail.com", "Juliet", 2, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 11, "juliet.hernandez@gmail.com", "Juliet", 3, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 58, "marcos.doe@gmail.com", "Marcos", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "jhon.lee@gmail.com", "Jhon", 2, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 39, "miguel.fernandez@gmail.com", 4, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 17, "brayan.lee@gmail.com", "Brayan", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 25, "jhon.tapanez@gmail.com", "Jhon", 4, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 20, "juliet.lee@gmail.com", "Juliet", 3, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 52, "jhon.lee@gmail.com", "Jhon", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 31, "carlos.tapanez@gmail.com", "Carlos", 4, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 40, "jhon.hernandez@gmail.com", 4, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 29, "marcos.stampton@gmail.com", "Marcos", 4, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 11, "juliet.garcia@gmail.com", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { "carlos.garcia@gmail.com", "Carlos", 1, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 15, "carlos.hernandez@gmail.com", "Carlos", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 34, "juliet.fernandez@gmail.com", "Juliet", 1, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 38, "marcos.stampton@gmail.com", "Marcos", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 51, "juliet.garcia@gmail.com", "Juliet", 5, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 36, "juliet.tapanez@gmail.com", "Juliet", 6, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 12, "brayan.stampton@gmail.com", "Brayan", 3, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 50, "carlos.lee@gmail.com", "Carlos", 3, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Age", "Email", "FirstName" },
                values: new object[] { 54, "miguel.doe@gmail.com", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "brayan.stampton@gmail.com", "Brayan", 2, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 45, "marcos.garcia@gmail.com", "Marcos", 5, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 45, "marcos.garcia@gmail.com", "Marcos", 1, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 38, "jhon.doe@gmail.com", "Jhon", 3, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 22, "marcos.hernandez@gmail.com", "Marcos", 3 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 56, "juliet.lee@gmail.com", "Juliet", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 28, "brayan.stampton@gmail.com", "Brayan", 1, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 30, "miguel.doe@gmail.com", "Miguel", 5, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Age", "Email", "LastName" },
                values: new object[] { 15, "marcos.doe@gmail.com", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 59, "jhon.stampton@gmail.com", "Jhon", 3, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 18, "brayan.lee@gmail.com", "Brayan", 5, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 29, "juliet.tapanez@gmail.com", "Juliet", 3, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 43, "brayan.garcia@gmail.com", "Brayan", 3, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 39, "marcos.fernandez@gmail.com", "Marcos", 3, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 58, "marcos.stampton@gmail.com", "Marcos", 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 15, "jhon.stampton@gmail.com", "Jhon", 5, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 30, "jhon.tapanez@gmail.com", "Jhon", 1, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 24, "jhon.hernandez@gmail.com", "Jhon", 1, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", true, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 10,
                column: "Title",
                value: "Jhon");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 11,
                column: "Title",
                value: "Tedd");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", false, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", false, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", false, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 19,
                column: "Description",
                value: "Garcia");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 20,
                column: "Title",
                value: "Carlos");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 22,
                column: "Published",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Doe", false });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 26,
                column: "Description",
                value: "Tapanez");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Doe", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Doe", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", false, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 36,
                column: "Title",
                value: "Miguel");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Fernandez", true });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", false, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", false, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", true, "Carlos" });
        }
    }
}
