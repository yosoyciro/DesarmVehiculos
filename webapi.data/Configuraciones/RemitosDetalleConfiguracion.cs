using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace webapi.data.Configuraciones
{
    public class RemitosDetalleConfiguracion : IEntityTypeConfiguration<RemitosDetalle>
    {
        public void Configure(EntityTypeBuilder<RemitosDetalle> builder)
        {
            builder
              .HasKey(v => v.Id).HasName("REMDET_X_REMITOSDETALLEID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("RemitosDetalleId");

            builder
                .ToTable("RemitosDetalle");

            builder
                .HasOne(rd => rd.ArticulosStock)
                .WithMany(a => a.RemitosDetalles)
                .HasPrincipalKey(a => a.Id);
            
        }
    }
}
