using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class RemitosAuditoriaConfiguracion : IEntityTypeConfiguration<RemitosAuditoria>
    {
        public void Configure(EntityTypeBuilder<RemitosAuditoria> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("REMAUD_X_REMITOSAUDITORIAID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("RemitosAuditoriaId");

            builder
                .ToTable("RemitosAuditoria");
        }
    }
}
