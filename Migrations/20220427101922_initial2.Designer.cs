﻿// <auto-generated />
using MajestyApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MajestyApi.Migrations
{
    [DbContext(typeof(MajestyApiContext))]
    [Migration("20220427101922_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MajestyApi.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Borrar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MajestyApi.Models.Storie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Plot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Upvotes")
                        .HasColumnType("int");

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Storie");
                });

            modelBuilder.Entity("MajestyApi.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 19,
                            Email = "miguel.lee@gmail.com",
                            FirstName = "Miguel",
                            Grade = 6,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 2,
                            Age = 38,
                            Email = "tedd.tapanez@gmail.com",
                            FirstName = "Tedd",
                            Grade = 4,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 3,
                            Age = 36,
                            Email = "juliet.hernandez@gmail.com",
                            FirstName = "Juliet",
                            Grade = 1,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 4,
                            Age = 30,
                            Email = "marcos.garcia@gmail.com",
                            FirstName = "Marcos",
                            Grade = 1,
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 5,
                            Age = 55,
                            Email = "tedd.hernandez@gmail.com",
                            FirstName = "Tedd",
                            Grade = 6,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 6,
                            Age = 16,
                            Email = "carlos.garcia@gmail.com",
                            FirstName = "Carlos",
                            Grade = 3,
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 7,
                            Age = 52,
                            Email = "jhon.hernandez@gmail.com",
                            FirstName = "Jhon",
                            Grade = 3,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 8,
                            Age = 22,
                            Email = "jhon.doe@gmail.com",
                            FirstName = "Jhon",
                            Grade = 5,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 9,
                            Age = 23,
                            Email = "brayan.hernandez@gmail.com",
                            FirstName = "Brayan",
                            Grade = 5,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 10,
                            Age = 37,
                            Email = "juliet.stampton@gmail.com",
                            FirstName = "Juliet",
                            Grade = 6,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 11,
                            Age = 44,
                            Email = "jhon.garcia@gmail.com",
                            FirstName = "Jhon",
                            Grade = 5,
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 12,
                            Age = 35,
                            Email = "tedd.tapanez@gmail.com",
                            FirstName = "Tedd",
                            Grade = 4,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 13,
                            Age = 18,
                            Email = "carlos.fernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = 6,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 14,
                            Age = 22,
                            Email = "brayan.tapanez@gmail.com",
                            FirstName = "Brayan",
                            Grade = 1,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 15,
                            Age = 53,
                            Email = "miguel.stampton@gmail.com",
                            FirstName = "Miguel",
                            Grade = 2,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 16,
                            Age = 37,
                            Email = "jhon.doe@gmail.com",
                            FirstName = "Jhon",
                            Grade = 5,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 17,
                            Age = 56,
                            Email = "jhon.lee@gmail.com",
                            FirstName = "Jhon",
                            Grade = 4,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 18,
                            Age = 18,
                            Email = "brayan.lee@gmail.com",
                            FirstName = "Brayan",
                            Grade = 5,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 19,
                            Age = 53,
                            Email = "miguel.tapanez@gmail.com",
                            FirstName = "Miguel",
                            Grade = 6,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 20,
                            Age = 13,
                            Email = "marcos.fernandez@gmail.com",
                            FirstName = "Marcos",
                            Grade = 2,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 21,
                            Age = 56,
                            Email = "miguel.hernandez@gmail.com",
                            FirstName = "Miguel",
                            Grade = 5,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 22,
                            Age = 37,
                            Email = "juliet.fernandez@gmail.com",
                            FirstName = "Juliet",
                            Grade = 2,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 23,
                            Age = 14,
                            Email = "juliet.doe@gmail.com",
                            FirstName = "Juliet",
                            Grade = 2,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 24,
                            Age = 51,
                            Email = "marcos.fernandez@gmail.com",
                            FirstName = "Marcos",
                            Grade = 6,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 25,
                            Age = 44,
                            Email = "jhon.tapanez@gmail.com",
                            FirstName = "Jhon",
                            Grade = 4,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 26,
                            Age = 28,
                            Email = "juliet.tapanez@gmail.com",
                            FirstName = "Juliet",
                            Grade = 5,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 27,
                            Age = 27,
                            Email = "brayan.fernandez@gmail.com",
                            FirstName = "Brayan",
                            Grade = 2,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 28,
                            Age = 27,
                            Email = "jhon.hernandez@gmail.com",
                            FirstName = "Jhon",
                            Grade = 2,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 29,
                            Age = 37,
                            Email = "miguel.stampton@gmail.com",
                            FirstName = "Miguel",
                            Grade = 6,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 30,
                            Age = 50,
                            Email = "brayan.lee@gmail.com",
                            FirstName = "Brayan",
                            Grade = 5,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 31,
                            Age = 42,
                            Email = "brayan.stampton@gmail.com",
                            FirstName = "Brayan",
                            Grade = 1,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 32,
                            Age = 59,
                            Email = "miguel.tapanez@gmail.com",
                            FirstName = "Miguel",
                            Grade = 2,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 33,
                            Age = 58,
                            Email = "jhon.tapanez@gmail.com",
                            FirstName = "Jhon",
                            Grade = 6,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 34,
                            Age = 24,
                            Email = "marcos.fernandez@gmail.com",
                            FirstName = "Marcos",
                            Grade = 5,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 35,
                            Age = 39,
                            Email = "juliet.doe@gmail.com",
                            FirstName = "Juliet",
                            Grade = 4,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 36,
                            Age = 23,
                            Email = "juliet.fernandez@gmail.com",
                            FirstName = "Juliet",
                            Grade = 5,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 37,
                            Age = 38,
                            Email = "marcos.tapanez@gmail.com",
                            FirstName = "Marcos",
                            Grade = 1,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 38,
                            Age = 49,
                            Email = "marcos.tapanez@gmail.com",
                            FirstName = "Marcos",
                            Grade = 2,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 39,
                            Age = 33,
                            Email = "jhon.tapanez@gmail.com",
                            FirstName = "Jhon",
                            Grade = 2,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 40,
                            Age = 17,
                            Email = "brayan.fernandez@gmail.com",
                            FirstName = "Brayan",
                            Grade = 2,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 41,
                            Age = 17,
                            Email = "tedd.doe@gmail.com",
                            FirstName = "Tedd",
                            Grade = 1,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 42,
                            Age = 33,
                            Email = "brayan.garcia@gmail.com",
                            FirstName = "Brayan",
                            Grade = 2,
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 43,
                            Age = 57,
                            Email = "tedd.lee@gmail.com",
                            FirstName = "Tedd",
                            Grade = 1,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 44,
                            Age = 49,
                            Email = "brayan.hernandez@gmail.com",
                            FirstName = "Brayan",
                            Grade = 6,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 45,
                            Age = 25,
                            Email = "tedd.tapanez@gmail.com",
                            FirstName = "Tedd",
                            Grade = 5,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 46,
                            Age = 31,
                            Email = "tedd.tapanez@gmail.com",
                            FirstName = "Tedd",
                            Grade = 1,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 47,
                            Age = 47,
                            Email = "jhon.lee@gmail.com",
                            FirstName = "Jhon",
                            Grade = 5,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 48,
                            Age = 35,
                            Email = "juliet.doe@gmail.com",
                            FirstName = "Juliet",
                            Grade = 4,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 49,
                            Age = 15,
                            Email = "juliet.fernandez@gmail.com",
                            FirstName = "Juliet",
                            Grade = 6,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 50,
                            Age = 32,
                            Email = "jhon.doe@gmail.com",
                            FirstName = "Jhon",
                            Grade = 2,
                            LastName = "Doe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}