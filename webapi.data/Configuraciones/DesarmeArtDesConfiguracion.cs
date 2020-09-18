using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class DesarmeArtDesConfiguracion : IEntityTypeConfiguration<DesarmeArtDes>
    {
        public void Configure(EntityTypeBuilder<DesarmeArtDes> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("DESARTDES_X_DESARMEARTDESID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("DesarmeArtDesId");

            //Relaciones
            builder
                .HasMany(v => v.DesarmeArtDesDetalle)
                .WithOne(v => v.DesarmeArtDes);

            builder
                .ToTable("DesarmeArtDes");
        }
    }
}
