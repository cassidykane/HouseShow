using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseShow.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseShow.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Venue> Venues { get; set; }
    }
}
