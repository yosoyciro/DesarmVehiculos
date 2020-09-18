using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class ArticulosDescarteConfiguracion : IEntityTypeConfiguration<ArticulosDescarte>
    {
        public void Configure(EntityTypeBuilder<ArticulosDescarte> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("ARTDES_X_ARTICULOSDESCARTEID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("ArticulosDescarteId");

            builder
                .ToTable("ArticulosDescarte");
        }
    }
}
