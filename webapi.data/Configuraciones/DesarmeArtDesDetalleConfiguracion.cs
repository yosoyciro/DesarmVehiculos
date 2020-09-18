using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class DesarmeArtDesDetalleConfiguracion : IEntityTypeConfiguration<DesarmeArtDesDetalle>
    {
        public void Configure(EntityTypeBuilder<DesarmeArtDesDetalle> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("DESARTDESDET_X_DESARMEARTDESDETALLEID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("DesarmeArtDesDetalleId");

            builder
                .HasOne<ArticulosDescarte>(d => d.ArticulosDescarte)
                .WithMany(d => d.DesarmeArtDesDetalle)
                .HasForeignKey(d => d.ARTICULOSDESCARTEID);

            builder
                .ToTable("DesarmeArtDesDetalle");
        }
    }
}
