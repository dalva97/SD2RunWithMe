using System;
using Microsoft.EntityFrameworkCore;
using RunWithMe;

namespace RunWithMe
{
    public class HolidayDBContext : DbContext
    {
        public DbSet<Holiday> Holidays { get; set; }

        public string DbPath { get; }

        public HolidayDBContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "HolidayDB.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}




