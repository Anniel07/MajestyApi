using Microsoft.EntityFrameworkCore.Migrations;

namespace MajestyApi.Migrations
{
    public partial class newest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 14, "tedd.hernandez@gmail.com", "1st", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 13, "tedd.stampton@gmail.com", "Tedd", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 40, "juliet.hernandez@gmail.com", "Juliet", "6th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 34, "carlos.hernandez@gmail.com", "Carlos", "5th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 16, "marcos.hernandez@gmail.com", "Marcos", "6th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 57, "juliet.hernandez@gmail.com", "Juliet", "6th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 10, "brayan.stampton@gmail.com", "Brayan", "6th", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 32, "carlos.lee@gmail.com", "4th", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 56, "tedd.hernandez@gmail.com", "Tedd", "5th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 54, "brayan.garcia@gmail.com", "Brayan", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 13, "marcos.fernandez@gmail.com", "6th", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 41, "carlos.doe@gmail.com", "Carlos", "3rd", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Age", "Grade" },
                values: new object[] { 41, "2nd" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { "tedd.fernandez@gmail.com", "Tedd", "2nd", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 50, "brayan.doe@gmail.com", "Brayan", "5th", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Age", "Grade" },
                values: new object[] { 35, "2nd" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 44, "marcos.doe@gmail.com", "Marcos", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 36, "tedd.lee@gmail.com", "Tedd", "2nd", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 18, "tedd.tapanez@gmail.com", "4th", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 36, "brayan.doe@gmail.com", "Brayan", "1st", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 48, "jhon.stampton@gmail.com", "Jhon", "4th", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 16, "jhon.hernandez@gmail.com", "Jhon", "6th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "jhon.lee@gmail.com", "Jhon", "1st", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Email", "FirstName", "Grade" },
                values: new object[] { "marcos.hernandez@gmail.com", "Marcos", "4th" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 12, "marcos.lee@gmail.com", "Marcos", "3rd", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 11, "tedd.fernandez@gmail.com", "Tedd", "3rd", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 10, "carlos.fernandez@gmail.com", "Carlos", "3rd", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "brayan.stampton@gmail.com", "Brayan", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 40, "miguel.stampton@gmail.com", "Miguel", "6th", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 13, "tedd.doe@gmail.com", "Tedd", "4th", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 20, "juliet.lee@gmail.com", "Juliet", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 39, "brayan.fernandez@gmail.com", "1st", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 45, "tedd.garcia@gmail.com", "Tedd", "2nd", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 47, "jhon.hernandez@gmail.com", "Jhon", "5th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 12, "miguel.fernandez@gmail.com", "Miguel", "5th" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 50, "brayan.stampton@gmail.com", "Brayan", "3rd", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 36, "marcos.garcia@gmail.com", "Marcos", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 27, "miguel.stampton@gmail.com", "Miguel", "5th", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 30, "marcos.fernandez@gmail.com", "Marcos", "5th", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "brayan.garcia@gmail.com", "Brayan", "1st", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 17, "marcos.tapanez@gmail.com", "Marcos", "4th", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 14, "juliet.stampton@gmail.com", "Juliet", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 27, "juliet.tapanez@gmail.com", "Juliet", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 35, "juliet.hernandez@gmail.com", "Juliet", "2nd", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 48, "juliet.tapanez@gmail.com", "Juliet", "5th", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 33, "juliet.garcia@gmail.com", "Juliet", "5th", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "brayan.tapanez@gmail.com", "Brayan", "4th", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 36, "marcos.doe@gmail.com", "Marcos", "2nd", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 14, "jhon.tapanez@gmail.com", "Jhon", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 29, "carlos.hernandez@gmail.com", "Carlos", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 2,
                column: "Title",
                value: "Miguel");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 6,
                column: "Description",
                value: "Garcia");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Doe", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", true, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Fernandez", true });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 23,
                column: "Description",
                value: "Doe");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Carlos" });

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
                values: new object[] { "Lee", true, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", false, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Doe", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", false, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", true, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", false, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", false, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", false, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 49,
                column: "Description",
                value: "Doe");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 50,
                column: "Title",
                value: "Tedd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 52, "tedd.doe@gmail.com", "5th", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 54, "brayan.lee@gmail.com", "Brayan", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 24, "marcos.tapanez@gmail.com", "Marcos", "2nd", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 13, "juliet.fernandez@gmail.com", "Juliet", "4th", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 29, "jhon.garcia@gmail.com", "Jhon", "3rd", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "jhon.garcia@gmail.com", "Jhon", "1st", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 16, "tedd.doe@gmail.com", "Tedd", "5th", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 24, "carlos.fernandez@gmail.com", "6th", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 24, "carlos.stampton@gmail.com", "Carlos", "1st", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 17, "jhon.doe@gmail.com", "Jhon", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 45, "marcos.doe@gmail.com", "1st", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 58, "jhon.garcia@gmail.com", "Jhon", "4th", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Age", "Grade" },
                values: new object[] { 12, "4th" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { "jhon.hernandez@gmail.com", "Jhon", "6th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 30, "carlos.lee@gmail.com", "Carlos", "1st", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Age", "Grade" },
                values: new object[] { 38, "3rd" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 47, "miguel.fernandez@gmail.com", "Miguel", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "jhon.tapanez@gmail.com", "Jhon", "1st", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 37, "tedd.hernandez@gmail.com", "6th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 12, "marcos.garcia@gmail.com", "Marcos", "6th", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 42, "brayan.garcia@gmail.com", "Brayan", "3rd", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 52, "tedd.stampton@gmail.com", "Tedd", "3rd", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 43, "tedd.garcia@gmail.com", "Tedd", "2nd", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Email", "FirstName", "Grade" },
                values: new object[] { "miguel.hernandez@gmail.com", "Miguel", "5th" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 35, "carlos.fernandez@gmail.com", "Carlos", "5th", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 40, "miguel.stampton@gmail.com", "Miguel", "2nd", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "miguel.tapanez@gmail.com", "Miguel", "6th", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "miguel.hernandez@gmail.com", "Miguel", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 52, "marcos.garcia@gmail.com", "Marcos", "1st", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 12, "carlos.hernandez@gmail.com", "Carlos", "6th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 54, "carlos.fernandez@gmail.com", "Carlos", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 30, "brayan.hernandez@gmail.com", "2nd", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 36, "miguel.lee@gmail.com", "Miguel", "4th", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 19, "juliet.fernandez@gmail.com", "Juliet", "3rd", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 47, "juliet.fernandez@gmail.com", "Juliet", "3rd" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 47, "tedd.tapanez@gmail.com", "Tedd", "1st", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 34, "carlos.stampton@gmail.com", "Carlos", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "tedd.garcia@gmail.com", "Tedd", "2nd", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 20, "brayan.stampton@gmail.com", "Brayan", "2nd", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 10, "marcos.doe@gmail.com", "Marcos", "3rd", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 25, "carlos.doe@gmail.com", "Carlos", "5th", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 15, "miguel.garcia@gmail.com", "Miguel", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 23, "tedd.fernandez@gmail.com", "Tedd", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "carlos.stampton@gmail.com", "Carlos", "4th", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 16, "miguel.lee@gmail.com", "Miguel", "4th", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 53, "miguel.fernandez@gmail.com", "Miguel", "1st", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 22, "miguel.hernandez@gmail.com", "Miguel", "2nd", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 41, "jhon.tapanez@gmail.com", "Jhon", "6th", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 49, "tedd.fernandez@gmail.com", "Tedd", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 31, "miguel.tapanez@gmail.com", "Miguel", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 2,
                column: "Title",
                value: "Juliet");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", true, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", false, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 6,
                column: "Description",
                value: "Hernandez");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Marcos" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Doe", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", false, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Hernandez", false });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", false, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 23,
                column: "Description",
                value: "Lee");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Tedd" });

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
                values: new object[] { "Garcia", false, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", false, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Doe", false, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", false, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Doe", "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", true, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 49,
                column: "Description",
                value: "Lee");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 50,
                column: "Title",
                value: "Marcos");
        }
    }
}
