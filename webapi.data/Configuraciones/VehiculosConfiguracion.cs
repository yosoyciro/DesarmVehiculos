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
                .HasOne(v => v.TiposCombustible)
                .WithMany(t => t.Vehiculos)
                .HasForeignKey(v => v.Tiposcombustibleid);

            builder
                .HasOne(v => v.Companias)
                .WithMany(c => c.Vehiculos)
                .HasForeignKey(v => v.Companiasid);

            builder
                 .HasOne(v => v.Colores)
                .WithMany(c => c.Vehiculos)
                .HasForeignKey(v => v.Coloresid);

            builder
                .HasOne(v => v.Categorias)
                .WithMany(c => c.Vehiculos)
                .HasForeignKey(v => v.Categoriasid);

            builder
                .HasOne(v => v.Depositos)
                .WithMany(d => d.Vehiculos)
                .HasForeignKey(v => v.Depositosid);

            builder
                .HasOne(v => v.Empleados)
                .WithMany(e => e.Vehiculos)
                .HasForeignKey(v => v.Empleadosid);

            builder
                .HasOne(v => v.MarcasChasis)
                .WithMany(m => m.Vehiculos)
                .HasForeignKey(v => v.Marcaschasisid);

            builder
                .HasOne(v => v.MarcasMotor)
                .WithMany(c => c.Vehiculos)
                .HasForeignKey(v => v.Marcasmotoresid);

            builder
                .HasOne(v => v.VehiculosTipo)
                .WithMany(c => c.Vehiculos)
                .HasForeignKey(v => v.Vehiculostipoid);

            builder
                .ToTable("Vehiculos");
        }
    }
}
