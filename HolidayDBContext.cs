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
            => options.UseSqlite($"Filename={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Holiday>().HasData(new Holiday
            {
                Id = Guid.Parse("8a6138ba-89e4-4249-88d3-65c3809bfa8e"),
                Name = "Fourth of July",
                Date = DateTime.Parse("2023-07-04")
            },
        new Holiday
        {
            Id = Guid.Parse("edf6fdb9-86ed-4284-9085-a11370c58f6c"),
            Name = "Christmas Day",
            Date = DateTime.Parse("2023-12-25")
        },
        new Holiday
        {
            Id = Guid.Parse("279df99d-26bb-48f2-bbdc-63a609691d96"),
            Name = "April Fools",
            Date = DateTime.Parse("2023-04-01")
        });
        }
    }
}
  
     

        

        
   




