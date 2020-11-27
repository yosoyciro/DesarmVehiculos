using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class ArticulosStockConfiguracion : IEntityTypeConfiguration<ArticulosStock>
    {
        public void Configure(EntityTypeBuilder<ArticulosStock> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("ARTS_X_ARTICULOSSTOCKID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("ArticulosStockId");

            //Relaciones
            builder
                .HasOne(v => v.Vehiculos)
                .WithMany(m => m.ArticulosStock)
                .HasForeignKey(v => v.VEHICULOSID);

            builder
                .HasOne(ars => ars.Articulos)
                .WithMany(a => a.ArticulosStock)
                .HasForeignKey(ars => ars.ARTICULOSID);

            builder
                .ToTable("ArticulosStock");
        }
    }
}
