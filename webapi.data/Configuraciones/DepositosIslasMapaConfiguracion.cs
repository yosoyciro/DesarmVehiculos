using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;


namespace webapi.data.Configuraciones
{
    public class DepositosIslasMapaConfiguracion : IEntityTypeConfiguration<DepositosIslasMapa>
    {
        public void Configure(EntityTypeBuilder<DepositosIslasMapa> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("DEPISLMAP_X_DEPOSITOSISLASMAPAID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("DEPOSITOSISLASMAPAID");

            builder
                .ToTable("DepositosIslasMapa");
        }
    }
}
