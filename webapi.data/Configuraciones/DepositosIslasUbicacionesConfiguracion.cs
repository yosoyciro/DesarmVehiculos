using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class DepositosIslasUbicacionesConfiguracion : IEntityTypeConfiguration<DepositosIslasUbicaciones>
    {
        public void Configure(EntityTypeBuilder<DepositosIslasUbicaciones> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("DEPISLUBI_X_DEPOSITOSISLASUBICACIONESID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("DEPOSITOSISLASUBICACIONESID");

            builder
                .ToTable("DepositosIslasUbicaciones");
        }
    }
}
