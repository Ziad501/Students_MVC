using Microsoft.EntityFrameworkCore;

namespace Students_MVC.Models
{
    public class DBapp: DbContext
    {
        public DBapp(DbContextOptions options) : base(options)
        {
        }
        public DBapp()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=StudentDb;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }
    }
}
