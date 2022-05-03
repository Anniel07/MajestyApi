using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MajestyApi.Models;

namespace MajestyApi.Data
{
    public class MajestyApiContext : DbContext
    {
        public MajestyApiContext (DbContextOptions<MajestyApiContext> options)
            : base(options)
        {
        }

        public DbSet<MajestyApi.Models.Storie> Storie { get; set; }
        public DbSet<MajestyApi.Models.Movie> Movie { get; set; }

        public DbSet<MajestyApi.Models.Student> Student { get; set; }
        public DbSet<MajestyApi.Models.Tutorial> Tutorial { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string[] firstName = { "Jhon", "Brayan", "Tedd", "Carlos", "Miguel", "Marcos", "Juliet" };
            string[] lastName = { "Doe", "Hernandez", "Fernandez", "Garcia", "Stampton", "Lee", "Tapanez" };
            string[] grades = {"1st", "2nd" , "3rd" , "4th" , "5th" , "6th" };
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                string fn = firstName[rand.Next(0, firstName.Length)];
                string ln = lastName[rand.Next(0, lastName.Length)];
                var std = new Student {
                    ID = i+1,
                    FirstName = fn,
                    LastName = ln,
                    Email = fn.ToLower() + "." + ln.ToLower() + "@gmail.com",
                    Age = rand.Next(10,60),
                    Grade = grades[rand.Next(0, grades.Length)] ,
                };
                modelBuilder.Entity<Student>().HasData(std);
            }
            // add tutorials data
            for (int i = 0; i < 50; i++)
            {
                string fn = firstName[rand.Next(0, firstName.Length)];
                string ln = lastName[rand.Next(0, lastName.Length)];
                var tut = new Tutorial
                {
                    ID = i + 1,
                    Title = fn,
                    Description = ln,
                    Published = (rand.NextDouble() < 0.5) ? true : false,
                };
                modelBuilder.Entity<Tutorial>().HasData(tut);
            }

        }

    }
}
