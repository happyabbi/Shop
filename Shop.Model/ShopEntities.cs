using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    public class ShopEntities : DbContext
    {
        //public ShopEntities(DbContextOptions<ShopEntities> options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Database\\ShopDB.db;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentId);
                entity.Property(e => e.FirstName).HasMaxLength(32);
                entity.Property(e => e.LastName).HasMaxLength(32);
                entity.HasData(new Student
                {
                    StudentId = 1,
                    FirstName = "wei",
                    LastName = "kun",
                });

            });
        }


        public DbSet<Student> Students { get; set; }
    }
}
