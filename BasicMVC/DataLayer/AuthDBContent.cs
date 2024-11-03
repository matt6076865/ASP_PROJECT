using BasicMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.DataLayer
{
    public class AuthDbContext : IdentityDbContext<MVCUser>
    {
        public DbSet<MVCUser> MVCUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
