using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    class CompaniasConfiguracion : IEntityTypeConfiguration<Companias>
    {
        public void Configure(EntityTypeBuilder<Companias> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("COM_X_COMPANIASID");

            builder
                .Property(m => m.Id);
                //.UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("CompaniasId");

            builder
                .ToTable("Companias");
        }
    }
}
