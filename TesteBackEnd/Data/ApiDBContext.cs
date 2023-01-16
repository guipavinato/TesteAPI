using Microsoft.EntityFrameworkCore;
using TesteBackEnd.Data.Map;
using TesteBackEnd.Models;

namespace TesteBackEnd.Data
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options)
            :base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TelefoneModel> Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TelefoneMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
