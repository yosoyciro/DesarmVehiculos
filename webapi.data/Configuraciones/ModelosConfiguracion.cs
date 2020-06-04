using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class ModelosConfiguracion : IEntityTypeConfiguration<Modelos>
    {
        public void Configure(EntityTypeBuilder<Modelos> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("MOD_X_MODELOSID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("ModelosId");

            builder
                .ToTable("Modelos");
        }
    }
}
