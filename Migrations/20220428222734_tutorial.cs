using Microsoft.EntityFrameworkCore.Migrations;

namespace MajestyApi.Migrations
{
    public partial class tutorial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tutorial",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Published = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutorial", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 46, "marcos.lee@gmail.com", "Marcos", 3, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 23, "miguel.tapanez@gmail.com", "Miguel", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 32, "miguel.fernandez@gmail.com", "Miguel", 5, "Fernandez" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 44, "tedd.hernandez@gmail.com", "Tedd", 6, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 17, "miguel.garcia@gmail.com", "Miguel", 2, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 45, "marcos.doe@gmail.com", "Marcos", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "carlos.lee@gmail.com", "Carlos", 3, "Lee" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 58, "marcos.doe@gmail.com", "Marcos", 4, "Doe" });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 39, "miguel.fernandez@gmail.com", "Miguel", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 17, "brayan.lee@gmail.com", "Brayan", 5, "Lee" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 20, "juliet.lee@gmail.com", "Juliet", 3 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 52, "jhon.lee@gmail.com", 6, "Lee" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 11, "juliet.garcia@gmail.com", "Juliet", 2, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 43, "carlos.garcia@gmail.com", "Carlos", 1, "Garcia" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 38, "marcos.stampton@gmail.com", "Marcos", 2 });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 36, "juliet.tapanez@gmail.com", "Juliet", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 12, "brayan.stampton@gmail.com", 3, "Stampton" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 54, "miguel.doe@gmail.com", 4, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 32, "brayan.stampton@gmail.com", "Brayan", 2 });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 38, "jhon.doe@gmail.com", "Jhon", "Doe" });

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
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 56, "juliet.lee@gmail.com", "Juliet", 6, "Lee" });

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
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 30, "miguel.doe@gmail.com", 5, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 15, "marcos.doe@gmail.com", "Marcos", 2, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName" },
                values: new object[] { 59, "jhon.stampton@gmail.com", "Jhon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 18, "brayan.lee@gmail.com", "Brayan", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 29, "juliet.tapanez@gmail.com", "Juliet", "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 43, "brayan.garcia@gmail.com", "Brayan", "Garcia" });

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
                columns: new[] { "Age", "Grade" },
                values: new object[] { 58, 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 15, "jhon.stampton@gmail.com", "Jhon", "Stampton" });

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

            migrationBuilder.InsertData(
                table: "Tutorial",
                columns: new[] { "ID", "Description", "Published", "Title" },
                values: new object[,]
                {
                    { 50, "Doe", true, "Carlos" },
                    { 48, "Hernandez", false, "Carlos" },
                    { 22, "Garcia", false, "Juliet" },
                    { 21, "Tapanez", false, "Carlos" },
                    { 20, "Fernandez", true, "Carlos" },
                    { 19, "Garcia", true, "Tedd" },
                    { 18, "Stampton", false, "Tedd" },
                    { 17, "Doe", false, "Juliet" },
                    { 16, "Hernandez", true, "Juliet" },
                    { 15, "Hernandez", false, "Juliet" },
                    { 14, "Stampton", false, "Miguel" },
                    { 13, "Garcia", false, "Brayan" },
                    { 12, "Hernandez", true, "Miguel" },
                    { 11, "Tapanez", true, "Tedd" },
                    { 10, "Garcia", true, "Jhon" },
                    { 9, "Garcia", false, "Marcos" },
                    { 8, "Fernandez", false, "Marcos" },
                    { 7, "Garcia", false, "Carlos" },
                    { 6, "Fernandez", false, "Tedd" },
                    { 5, "Tapanez", true, "Tedd" },
                    { 4, "Tapanez", true, "Juliet" },
                    { 3, "Fernandez", true, "Juliet" },
                    { 2, "Garcia", true, "Jhon" },
                    { 23, "Lee", false, "Juliet" },
                    { 49, "Fernandez", true, "Brayan" },
                    { 24, "Doe", false, "Jhon" },
                    { 26, "Tapanez", true, "Jhon" },
                    { 47, "Tapanez", false, "Tedd" },
                    { 46, "Hernandez", true, "Marcos" },
                    { 45, "Fernandez", false, "Carlos" },
                    { 44, "Hernandez", false, "Jhon" },
                    { 43, "Tapanez", false, "Marcos" },
                    { 42, "Garcia", true, "Jhon" },
                    { 41, "Stampton", false, "Marcos" }
                });

            migrationBuilder.InsertData(
                table: "Tutorial",
                columns: new[] { "ID", "Description", "Published", "Title" },
                values: new object[,]
                {
                    { 40, "Hernandez", true, "Tedd" },
                    { 39, "Tapanez", false, "Marcos" },
                    { 38, "Garcia", false, "Brayan" },
                    { 37, "Fernandez", true, "Jhon" },
                    { 36, "Garcia", false, "Miguel" },
                    { 35, "Lee", true, "Tedd" },
                    { 34, "Doe", true, "Miguel" },
                    { 33, "Tapanez", false, "Juliet" },
                    { 32, "Doe", false, "Marcos" },
                    { 31, "Lee", true, "Miguel" },
                    { 30, "Hernandez", false, "Tedd" },
                    { 29, "Doe", true, "Miguel" },
                    { 28, "Doe", true, "Carlos" },
                    { 27, "Lee", true, "Jhon" },
                    { 25, "Tapanez", false, "Marcos" },
                    { 1, "Lee", true, "Brayan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tutorial");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 42, "jhon.tapanez@gmail.com", "Jhon", 4, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 49, "juliet.lee@gmail.com", "Juliet", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 21, "marcos.doe@gmail.com", "Marcos", 4, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 49, "brayan.fernandez@gmail.com", "Brayan", 1, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 17, "carlos.stampton@gmail.com", "Carlos", 3, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 59, "marcos.doe@gmail.com", "Marcos", 1, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 28, "brayan.fernandez@gmail.com", "Brayan", "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 43, "juliet.fernandez@gmail.com", "Juliet", 1, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 53, "juliet.garcia@gmail.com", "Juliet", 1, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 37, "juliet.stampton@gmail.com", "Juliet", 5, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 33, "carlos.doe@gmail.com", "Carlos", 6, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 29, "jhon.doe@gmail.com", "Jhon", 5, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 30, "tedd.garcia@gmail.com", "Tedd", 3, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 57, "juliet.stampton@gmail.com", "Juliet", 6, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 29, "juliet.garcia@gmail.com", "Juliet", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 51, "carlos.fernandez@gmail.com", "Carlos", 3, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 45, "carlos.hernandez@gmail.com", "Carlos", 5, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 19, "carlos.lee@gmail.com", "Carlos", 5 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 57, "jhon.fernandez@gmail.com", 5, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 11, "miguel.doe@gmail.com", "Miguel", 1, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 12, "jhon.stampton@gmail.com", 3, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 16, "juliet.hernandez@gmail.com", "Juliet", 2, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 16, "miguel.tapanez@gmail.com", "Miguel", 3, "Tapanez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 23, "tedd.doe@gmail.com", "Tedd", 2, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 35, "brayan.doe@gmail.com", "Brayan", "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 22, "tedd.stampton@gmail.com", "Tedd", 4, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 23, "tedd.stampton@gmail.com", "Tedd", 3 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 25, "miguel.hernandez@gmail.com", "Miguel", 6, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 34, "carlos.hernandez@gmail.com", "Carlos", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 35, "brayan.fernandez@gmail.com", 2, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 14, "jhon.garcia@gmail.com", "Jhon", 4, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 36, "miguel.lee@gmail.com", 1, "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 34, "jhon.stampton@gmail.com", "Jhon", 4 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 46, "carlos.doe@gmail.com", "Carlos", 2, "Doe" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 17, "tedd.fernandez@gmail.com", "Tedd", 3, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 40, "juliet.stampton@gmail.com", "Juliet", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "Grade" },
                values: new object[] { 54, "miguel.hernandez@gmail.com", "Miguel", 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 59, "carlos.fernandez@gmail.com", "Carlos", 5, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 50, "carlos.fernandez@gmail.com", "Carlos", 6, "Fernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Age", "Email", "Grade", "LastName" },
                values: new object[] { 58, "miguel.stampton@gmail.com", 3, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 26, "jhon.hernandez@gmail.com", "Jhon", 6, "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName" },
                values: new object[] { 26, "marcos.stampton@gmail.com", "Marcos" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 34, "carlos.hernandez@gmail.com", "Carlos", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 20, "brayan.hernandez@gmail.com", "Brayan", "Hernandez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 10, "marcos.stampton@gmail.com", "Marcos", "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 36, "juliet.garcia@gmail.com", "Juliet", 5, "Garcia" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Age", "Grade" },
                values: new object[] { 13, 2 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 46, "tedd.lee@gmail.com", "Tedd", "Lee" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 24, "carlos.stampton@gmail.com", "Carlos", 5, "Stampton" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[] { 42, "tedd.stampton@gmail.com", "Tedd", 6, "Stampton" });
        }
    }
}
