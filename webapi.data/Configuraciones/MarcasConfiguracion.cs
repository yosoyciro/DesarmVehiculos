using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class MarcasConfiguracion : IEntityTypeConfiguration<Marcas>
    {
        public void Configure(EntityTypeBuilder<Marcas> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("MAR_X_MARCASID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("MarcasId");

            builder
                .ToTable("Marcas");
        }
    }
}
