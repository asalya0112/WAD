using Microsoft.EntityFrameworkCore;
using StudentsRecordSystem.Models;
using System.Reflection;

namespace StudentsRecordSystem.DAL
{
    public class StudentContext: DbContext
    {
        // Constructer
        public StudentContext(DbContextOptions<StudentContext> o) : base(o)
        {
            Database.EnsureCreated();
        }

        // Product Database
        public DbSet<Student> Students { get; set; }
        public DbSet<Models.Module> Modules { get; set; }
    }
}
