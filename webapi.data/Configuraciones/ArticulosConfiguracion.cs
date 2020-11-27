using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    class ArticulosConfiguracion : IEntityTypeConfiguration<Articulos>
    {
        public void Configure(EntityTypeBuilder<Articulos> builder)
        {
            builder
               .HasKey(v => v.Id).HasName("ART_X_ARTICULOSID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("ArticulosId");

            builder
                .ToTable("Articulos");

        }
    }
}
