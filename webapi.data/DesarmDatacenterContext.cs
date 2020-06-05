using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webapi.core.Modelos;
using webapi.data.Configuraciones;

namespace webapi.data
{
    public class DesarmDatacenterContext : DbContext
    {
        public DesarmDatacenterContext()
        {
        }

        public DesarmDatacenterContext(DbContextOptions<DesarmDatacenterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new MarcasConfiguracion());

            builder
                .ApplyConfiguration(new VehiculosConfiguracion());

            builder
                .ApplyConfiguration(new ModelosConfiguracion());

            builder
                .ApplyConfiguration(new TiposCombustibleConfiguracion());
        }
    

        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        //public virtual DbSet<VehiculosTipo> VehiculosTipo { get; set; }
        //public virtual DbSet<Marcas> Marcas { get; set; }

        
    }
}
