using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    class MarcasChasisConfiguracion : IEntityTypeConfiguration<MarcasChasis>
    {
        public void Configure(EntityTypeBuilder<MarcasChasis> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("MARCHA_X_MARCASCHASISID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("MarcasChasisId");

            builder
                .ToTable("MarcasChasis");
        }
    }
}
