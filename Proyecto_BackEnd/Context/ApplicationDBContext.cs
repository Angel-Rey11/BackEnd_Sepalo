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
    }
}
