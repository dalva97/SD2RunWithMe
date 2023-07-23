using System;
using Microsoft.EntityFrameworkCore;
using RunWithMe;

namespace RunWithMe
{
    public class DatesDBContext : DbContext
    {
        public DbSet<Dates> Datetime { get; set; }

        public string DbPath { get; }

        public DatesDBContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "DatesDB.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}

