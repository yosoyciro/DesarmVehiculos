using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    class DepositosConfiguracion : IEntityTypeConfiguration<Depositos>
    {
        public void Configure(EntityTypeBuilder<Depositos> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("DEP_X_DEPOSITOSID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("DepositosId");

            builder
                .ToTable("Depositos");
        }
    }
}
