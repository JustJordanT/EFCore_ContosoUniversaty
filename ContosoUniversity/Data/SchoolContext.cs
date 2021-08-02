using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class schoolContext : DbContext
    {
        public schoolContext(DbContextOptions<schoolContext> options) : base(options)
        {
            
        }

        public DbSet<course> Courses { get; set; }
        public DbSet<enrollment> Enrollments { get; set; }
        public DbSet<student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<course>().ToTable("Course");
            modelBuilder.Entity<enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<student>().ToTable("Student");
        }
    }
}