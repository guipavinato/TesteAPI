using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteBackEnd.Models;

namespace TesteBackEnd.Data.Map
{
    public class TelefoneMap : IEntityTypeConfiguration<TelefoneModel>
    {
        public void Configure(EntityTypeBuilder<TelefoneModel> builder)
        {
            builder.HasKey(p => new { p.UsuarioId, p.Numero });
        }
    }
}