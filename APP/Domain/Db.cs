using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using static System.Formats.Asn1.AsnWriter;

namespace APP.Domain
{
    public class Db : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        public Db(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>().HasIndex(roleEntity => roleEntity.Name).IsUnique();

            modelBuilder.Entity<User>().HasIndex(userEntity => userEntity.UserName).IsUnique();

            modelBuilder.Entity<User>().HasIndex(userEntity => new { userEntity.FirstName, userEntity.LastName });
        }
    }
}