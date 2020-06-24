using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    class VehiculosTipoConfiguracion : IEntityTypeConfiguration<VehiculosTipo>
    {
        public void Configure(EntityTypeBuilder<VehiculosTipo> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("VEHTIP_X_VEHICULOSTIPOID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("VehiculosTipoId");

            builder
                .ToTable("VehiculosTipo");
        }
    }
}
