
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\mssqllocaldb;Database=StudentDatabase;Trusted_Connection=True;");
        }
    }
}
