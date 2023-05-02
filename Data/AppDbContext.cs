using Catstagram.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Catstagram.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Post> Posts { get; set; }
    }
}
