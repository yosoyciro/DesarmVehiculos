using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class Formulario04DConfiguracion : IEntityTypeConfiguration<Formulario04D>
    {
        public void Configure(EntityTypeBuilder<Formulario04D> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("FOR04D_X_FORMULARIO04DID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("Formulario04DId");

            builder
                .ToTable("Formulario04D");
        }
    }
}
