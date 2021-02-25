using Microsoft.EntityFrameworkCore;

namespace Db
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-MMC8V3RA\SQLEXPRESS;Database=CustomerDb;Trusted_Connection=True;");
        }
    }
}   