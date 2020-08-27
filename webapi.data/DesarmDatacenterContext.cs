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
                .ApplyConfiguration(new CompaniasConfiguracion())
                .ApplyConfiguration(new MarcasConfiguracion())
                .ApplyConfiguration(new ModelosConfiguracion())
                .ApplyConfiguration(new TiposCombustibleConfiguracion())
                .ApplyConfiguration(new VehiculosConfiguracion())
                .ApplyConfiguration(new ColoresConfiguracion())
                .ApplyConfiguration(new CategoriasConfiguracion())
                .ApplyConfiguration(new DepositosConfiguracion())
                .ApplyConfiguration(new EmpleadosConfiguracion())
                .ApplyConfiguration(new MarcasChasisConfiguracion())
                .ApplyConfiguration(new MarcasMotorConfiguracion())
                .ApplyConfiguration(new VehiculosTipoConfiguracion())
                .ApplyConfiguration(new Formulario04DConfiguracion())
                .ApplyConfiguration(new DepositosIslasMapaConfiguracion())
                .ApplyConfiguration(new DepositosIslasUbicacionesConfiguracion())
                .ApplyConfiguration(new ArticulosStockConfiguracion());
        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Colores> Colores { get; set; }
        public virtual DbSet<Companias> Companias { get; set; }
        public virtual DbSet<Depositos> Depositos { get; set; }
        public virtual DbSet<Empleados> CoEmpleadosmpanias { get; set; }
        public virtual DbSet<MarcasChasis> MarcasChasis { get; set; }
        public virtual DbSet<MarcasMotor> MarcasMotor { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Modelos> Modelos { get; set; }
        public virtual DbSet<TiposCombustible> TiposCombustible { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<VehiculosTipo> VehiculosTipo { get; set; }
        public virtual DbSet<Formulario04D> Formulario04D { get; set; }
        public virtual DbSet<DepositosIslasMapa> DepositosIslasMapa { get; set; }
        public virtual DbSet<DepositosIslasUbicaciones> DepositosIslasUbicaciones { get; set; }
        public virtual DbSet<ArticulosStock> ArticulosStock { get; set; }
    }
}
