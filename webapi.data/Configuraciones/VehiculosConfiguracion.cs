using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;

namespace webapi.data.Configuraciones
{
    public class VehiculosConfiguracion : IEntityTypeConfiguration<Vehiculos>
    {
        public void Configure(EntityTypeBuilder<Vehiculos> builder)
        {
            builder
                .HasKey(v => v.Id).HasName("VEH_X_VEHICULOSID");

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(v => v.Id).HasColumnName("VehiculosId");

            //Relaciones
            builder
                .HasOne(v => v.Modelos)
                .WithMany(m => m.Vehiculos)
                .HasForeignKey(v => v.Modelosid);

            builder
                .HasOne(v => v.Marcas)
                .WithMany(m => m.Vehiculos)
                .HasForeignKey(v => v.Marcasid);

            builder
                .ToTable("Vehiculos");
        }
    }
}
