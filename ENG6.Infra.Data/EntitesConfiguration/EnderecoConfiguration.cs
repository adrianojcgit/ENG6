using ENG6.Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ENG6.Infra.Data.EntitesConfiguration
{
    public class EnderecoConfiguration
    {
        public void Configure(EntityTypeBuilder<Endereco> builder) 
        {
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Cliente)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(e => e.ClienteId);
        }
    }
}
