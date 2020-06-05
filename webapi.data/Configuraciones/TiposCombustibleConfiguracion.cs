using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class TiposCombustibleConfiguracion : IEntityTypeConfiguration<TiposCombustible>
    {
        public void Configure(EntityTypeBuilder<TiposCombustible> builder)
        {
            builder
               .HasKey(v => v.Id).HasName("TipCom_x_TiposCombustibleId");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("TiposCombustibleId");

            builder
                .ToTable("TiposCombustible");
        }
    }
}
