using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    class MarcasMotorConfiguracion : IEntityTypeConfiguration<MarcasMotor>
    {
        public void Configure(EntityTypeBuilder<MarcasMotor> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("MARMOT_X_MARCASMOTORESID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("MarcasMotoresId");

            builder
                .ToTable("MarcasMotor");
        }
    }
}
