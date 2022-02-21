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
    }
}
