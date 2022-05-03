using Microsoft.EntityFrameworkCore.Migrations;

namespace MajestyApi.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Storie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Upvotes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "ID", "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[,]
                {
                    { 1, 11, "jhon.garcia@gmail.com", "Jhon", 3, "Garcia" },
                    { 28, 51, "carlos.doe@gmail.com", "Carlos", 1, "Doe" },
                    { 29, 48, "juliet.garcia@gmail.com", "Juliet", 2, "Garcia" },
                    { 30, 11, "jhon.hernandez@gmail.com", "Jhon", 4, "Hernandez" },
                    { 31, 50, "tedd.garcia@gmail.com", "Tedd", 3, "Garcia" },
                    { 32, 38, "marcos.tapanez@gmail.com", "Marcos", 4, "Tapanez" },
                    { 33, 39, "carlos.garcia@gmail.com", "Carlos", 1, "Garcia" },
                    { 34, 37, "tedd.garcia@gmail.com", "Tedd", 3, "Garcia" },
                    { 35, 13, "tedd.fernandez@gmail.com", "Tedd", 2, "Fernandez" },
                    { 36, 59, "tedd.doe@gmail.com", "Tedd", 2, "Doe" },
                    { 37, 46, "tedd.doe@gmail.com", "Tedd", 4, "Doe" },
                    { 38, 54, "jhon.tapanez@gmail.com", "Jhon", 6, "Tapanez" },
                    { 39, 47, "jhon.hernandez@gmail.com", "Jhon", 5, "Hernandez" },
                    { 40, 14, "juliet.doe@gmail.com", "Juliet", 2, "Doe" },
                    { 41, 44, "marcos.stampton@gmail.com", "Marcos", 1, "Stampton" },
                    { 42, 48, "tedd.lee@gmail.com", "Tedd", 3, "Lee" },
                    { 43, 48, "juliet.fernandez@gmail.com", "Juliet", 5, "Fernandez" },
                    { 44, 27, "brayan.lee@gmail.com", "Brayan", 3, "Lee" },
                    { 45, 11, "carlos.stampton@gmail.com", "Carlos", 5, "Stampton" },
                    { 46, 38, "brayan.tapanez@gmail.com", "Brayan", 4, "Tapanez" },
                    { 47, 10, "miguel.stampton@gmail.com", "Miguel", 2, "Stampton" },
                    { 48, 36, "marcos.lee@gmail.com", "Marcos", 3, "Lee" },
                    { 27, 20, "brayan.fernandez@gmail.com", "Brayan", 2, "Fernandez" },
                    { 26, 33, "brayan.lee@gmail.com", "Brayan", 6, "Lee" },
                    { 25, 51, "brayan.doe@gmail.com", "Brayan", 1, "Doe" },
                    { 24, 12, "brayan.lee@gmail.com", "Brayan", 6, "Lee" },
                    { 2, 43, "marcos.doe@gmail.com", "Marcos", 5, "Doe" },
                    { 3, 41, "miguel.fernandez@gmail.com", "Miguel", 4, "Fernandez" },
                    { 4, 47, "jhon.tapanez@gmail.com", "Jhon", 1, "Tapanez" },
                    { 5, 42, "brayan.hernandez@gmail.com", "Brayan", 5, "Hernandez" },
                    { 6, 19, "carlos.doe@gmail.com", "Carlos", 3, "Doe" },
                    { 7, 58, "jhon.tapanez@gmail.com", "Jhon", 3, "Tapanez" },
                    { 8, 17, "brayan.tapanez@gmail.com", "Brayan", 1, "Tapanez" },
                    { 9, 22, "carlos.tapanez@gmail.com", "Carlos", 4, "Tapanez" },
                    { 10, 47, "tedd.garcia@gmail.com", "Tedd", 1, "Garcia" },
                    { 11, 53, "tedd.lee@gmail.com", "Tedd", 6, "Lee" },
                    { 49, 32, "brayan.tapanez@gmail.com", "Brayan", 5, "Tapanez" },
                    { 12, 46, "marcos.hernandez@gmail.com", "Marcos", 1, "Hernandez" },
                    { 14, 50, "marcos.doe@gmail.com", "Marcos", 1, "Doe" },
                    { 15, 25, "tedd.stampton@gmail.com", "Tedd", 6, "Stampton" },
                    { 16, 36, "jhon.fernandez@gmail.com", "Jhon", 5, "Fernandez" },
                    { 17, 11, "brayan.stampton@gmail.com", "Brayan", 1, "Stampton" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "ID", "Age", "Email", "FirstName", "Grade", "LastName" },
                values: new object[,]
                {
                    { 18, 44, "miguel.doe@gmail.com", "Miguel", 5, "Doe" },
                    { 19, 32, "carlos.garcia@gmail.com", "Carlos", 5, "Garcia" },
                    { 20, 42, "brayan.hernandez@gmail.com", "Brayan", 5, "Hernandez" },
                    { 21, 23, "brayan.tapanez@gmail.com", "Brayan", 2, "Tapanez" },
                    { 22, 21, "marcos.garcia@gmail.com", "Marcos", 4, "Garcia" },
                    { 23, 23, "brayan.hernandez@gmail.com", "Brayan", 5, "Hernandez" },
                    { 13, 18, "jhon.tapanez@gmail.com", "Jhon", 4, "Tapanez" },
                    { 50, 47, "tedd.tapanez@gmail.com", "Tedd", 4, "Tapanez" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Storie");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
