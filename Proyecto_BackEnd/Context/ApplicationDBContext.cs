using Microsoft.EntityFrameworkCore;
using Proyecto_BackEnd.Model;

namespace Proyecto_BackEnd.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) { 

        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<CajeroModel> Cashiers { get; set; }
        public DbSet<CallModel> Calls { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CajeroModel>()
                .HasIndex(u => u.ip)
                .IsUnique();

            builder.Entity<CajeroModel>()
                .HasMany(p => p.calls)
                .WithOne(c => c.Cajero)
                .HasForeignKey(c => c.CajeroId);

            builder.Entity<UserModel>()
                .HasMany(p => p.calls)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId);
        }
    }
}
