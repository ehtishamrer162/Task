using System.Collections.Generic;
using System.Security.Claims;

namespace TaskQuiz.Server
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Task> Task { get; set; }
    }
}
