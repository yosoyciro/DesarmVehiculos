using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class RemitosConfiguracion : IEntityTypeConfiguration<Remitos>
    {
        public void Configure(EntityTypeBuilder<Remitos> builder)
        {
            builder
               .HasKey(v => v.Id).HasName("REM_X_REMITOSID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("RemitosId");

            builder
                .ToTable("Remitos");

            //Relaciones
            builder
                .HasMany(r => r.RemitosDetalles)
                .WithOne(rd => rd.Remito)
                .HasPrincipalKey(r => r.Id);

            builder
                .HasMany(r => r.RemitosAuditorias)
                .WithOne(ra => ra.Remito)
                .HasPrincipalKey(r => r.Id);
        }
    }
}
