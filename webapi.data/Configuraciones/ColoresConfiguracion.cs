using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    class ColoresConfiguracion : IEntityTypeConfiguration<Colores>
    {
        public void Configure(EntityTypeBuilder<Colores> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("COL_X_COLORESID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("ColoresId");

            builder
                .ToTable("Colores");
        }
    }
}
