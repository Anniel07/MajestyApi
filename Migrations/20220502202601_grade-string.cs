using Microsoft.EntityFrameworkCore.Migrations;

namespace MajestyApi.Migrations
{
    public partial class gradestring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Grade",
                table: "Student",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 52, "tedd.doe@gmail.com", "Tedd", "5th", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 54, "brayan.lee@gmail.com", "Brayan", "1st", "Lee" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 37, "jhon.garcia@gmail.com", "Jhon", "1st" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 24, "carlos.fernandez@gmail.com", "Carlos", "6th", "Fernandez" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 17, "jhon.doe@gmail.com", "Jhon", "2nd", "Doe" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 12, "brayan.doe@gmail.com", "Brayan", "4th", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 21, "jhon.hernandez@gmail.com", "Jhon", "6th" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 38, "miguel.doe@gmail.com", "Miguel", "3rd", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 47, "miguel.fernandez@gmail.com", "Miguel", "2nd", "Fernandez" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "tedd.hernandez@gmail.com", "Tedd", "6th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 12, "marcos.garcia@gmail.com", "Marcos", "6th" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 39, "miguel.hernandez@gmail.com", "Miguel", "5th" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 40, "miguel.stampton@gmail.com", "Miguel", "2nd" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 59, "miguel.hernandez@gmail.com", "1st", "Hernandez" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 12, "carlos.hernandez@gmail.com", "6th", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 54, "carlos.fernandez@gmail.com", "Carlos", "4th", "Fernandez" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 19, "juliet.fernandez@gmail.com", "3rd", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 47, "juliet.fernandez@gmail.com", "Juliet", "3rd", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 47, "tedd.tapanez@gmail.com", "Tedd", "1st" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 34, "carlos.stampton@gmail.com", "1st", "Stampton" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 10, "marcos.doe@gmail.com", "3rd", "Doe" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 15, "miguel.garcia@gmail.com", "Miguel", "3rd", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "tedd.fernandez@gmail.com", "Tedd", "1st", "Fernandez" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 22, "miguel.hernandez@gmail.com", "2nd", "Hernandez" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 49, "tedd.fernandez@gmail.com", "Tedd", "2nd", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 31, "miguel.tapanez@gmail.com", "Miguel", "1st" });

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
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", true, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Fernandez", false });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", true, "Brayan" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Marcos" });

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
                column: "Description",
                value: "Stampton");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Tapanez", false });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Tedd" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Carlos" });

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
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Hernandez", false, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Miguel" });

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
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", true, "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 24,
                column: "Description",
                value: "Lee");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", true, "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Hernandez", true });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 29,
                column: "Description",
                value: "Garcia");

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Brayan" });

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
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Lee", true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Miguel" });

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
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", true, "Brayan" });

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
                column: "Title",
                value: "Jhon");

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 46,
                column: "Title",
                value: "Tedd");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 47,
                column: "Title",
                value: "Miguel");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Tapanez", "Marcos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 27, "carlos.lee@gmail.com", "Carlos", 5, "Lee" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 13, "carlos.fernandez@gmail.com", "Carlos", 4, "Fernandez" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 44, "tedd.fernandez@gmail.com", "Tedd", 3, "Fernandez" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "jhon.lee@gmail.com", "Jhon", 2, "Lee" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 40, "marcos.garcia@gmail.com", 4, "Garcia" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 44, "carlos.hernandez@gmail.com", "Carlos", 4, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 57, "brayan.hernandez@gmail.com", "Brayan", 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "miguel.stampton@gmail.com", "Miguel", 3, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 21, "jhon.stampton@gmail.com", "Jhon", 5, "Stampton" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 40, "marcos.tapanez@gmail.com", "Marcos", 6, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 59, "juliet.garcia@gmail.com", "Juliet", 5 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 17, "jhon.stampton@gmail.com", "Jhon", 6, "Stampton" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 25, "juliet.stampton@gmail.com", "Juliet", 2, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 43, "tedd.hernandez@gmail.com", "Tedd", 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 38, "tedd.lee@gmail.com", "Tedd", 6, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 12, "marcos.stampton@gmail.com", "Marcos", 6 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 52, "juliet.doe@gmail.com", "Juliet", 2, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 19, "miguel.doe@gmail.com", 1, "Doe" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 50, "carlos.fernandez@gmail.com", 1, "Fernandez" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 26, "brayan.doe@gmail.com", 4, "Doe" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 12, "juliet.doe@gmail.com", 3, "Doe" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 14, "juliet.tapanez@gmail.com", "Juliet", 6 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 41, "carlos.hernandez@gmail.com", 5, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 47, "marcos.fernandez@gmail.com", "Marcos", 6, "Fernandez" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 43, "marcos.hernandez@gmail.com", 6, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 55, "marcos.hernandez@gmail.com", "Marcos", 2, "Hernandez" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 14, "miguel.stampton@gmail.com", 4, "Stampton" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 37, "juliet.tapanez@gmail.com", "Juliet", 3 });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Juliet" });

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
                columns: new[] { "Description", "Published" },
                values: new object[] { "Stampton", true });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", false, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Miguel" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 11,
                column: "Description",
                value: "Tapanez");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Published", "Title" },
                values: new object[] { true, "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Doe", true });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Brayan" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Hernandez", "Marcos" });

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
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", true, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", true, "Miguel" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Tapanez", false, "Tedd" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 24,
                column: "Description",
                value: "Stampton");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", false, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Garcia", true, "Jhon" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Description", "Published" },
                values: new object[] { "Stampton", false });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 29,
                column: "Description",
                value: "Lee");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Stampton", false, "Miguel" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Lee", "Juliet" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Published", "Title" },
                values: new object[] { false, "Jhon" });

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
                columns: new[] { "Description", "Published", "Title" },
                values: new object[] { "Fernandez", false, "Carlos" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 42,
                column: "Title",
                value: "Marcos");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Fernandez", "Miguel" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Garcia", "Juliet" });

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 46,
                column: "Title",
                value: "Brayan");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 47,
                column: "Title",
                value: "Marcos");

            migrationBuilder.UpdateData(
                table: "Tutorial",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Marcos" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Stampton", "Juliet" });
        }
    }
}
