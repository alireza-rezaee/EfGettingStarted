using EfGettingStarted.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfGettingStarted.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
            => option.UseSqlite(@"Data Source=D:\blogging2.db");
    }
}
