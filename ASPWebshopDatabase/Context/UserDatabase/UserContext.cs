using ASPWebshopDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ASPWebshopDatabase
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public string DbPath { get; private set; }

        public UserContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}user.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

}
