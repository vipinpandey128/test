using WebApplication3.Models;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Model;

namespace WebApplication3.DbContexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Choices> Choices { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
