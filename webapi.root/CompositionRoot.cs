using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using webapi.data;
using webapi.business.Servicios;
using webapi.business.Servicios.Implementaciones;
using webapi.data.Repositorios;
using webapi.data.Repositorios.Implementaciones;
using Microsoft.Extensions.Configuration;


namespace webapi.root
{
    public class CompositionRoot
    {
        public CompositionRoot() {}

        public static void injectDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DesarmDatacenterContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("ConexionDesarmDatacenter")));
            services.AddScoped<DesarmDatacenterContext>();
            services.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));

            //Servicios
            services
                .AddScoped<ICategoriasServicio, CategoriasServicio>()
                .AddScoped<IColoresServicio, ColoresServicio>()
                .AddScoped<ICompaniasServicio, CompaniasServicio>()
                .AddScoped<IDepositosServicio, DepositosServicio>()
                .AddScoped<IEmpleadosServicio, EmpleadosServicio>()
                .AddScoped<IMarcasServicio, MarcasServicio>()
                .AddScoped<IMarcasChasisServicio, MarcasChasisServicio>()
                .AddScoped<IMarcasMotorServicio, MarcasMotorServicio>()
                .AddScoped<IModelosServicio, ModelosServicio>()
                .AddScoped<ITiposCombustibleServicio, TiposCombustibleServicio>()
                .AddScoped<IVehiculosServicio, VehiculosServicio>()
                .AddScoped<IVehiculosTipoServicio, VehiculosTipoServicio>()
                .AddScoped<IFormulario04DServicio, Formulario04DServicio>();

            //Repositorios            
            services
                .AddScoped<ICategoriasRepositorio, CategoriasRepositorio>()
                .AddScoped<IColoresRepositorio, ColoresRepositorio>()
                .AddScoped<ICompaniasRepositorio, CompaniasRepositorio>()
                .AddScoped<IDepositosRepositorio, DepositosRepositorio>()
                .AddScoped<IEmpleadosRepositorio, EmpleadosRepositorio>()
                .AddScoped<IMarcasRepositorio, MarcasRepositorio>()
                .AddScoped<IMarcasChasisRepositorio, MarcasChasisRepositorio>()
                .AddScoped<IMarcasMotorRepositorio, MarcasMotorRepositorio>()
                .AddScoped<IModelosRepositorio, ModelosRepositorio>()
                .AddScoped<ITiposCombustibleRepositorio, TiposCombustibleRepositorio>()
                .AddScoped<IVehiculosRepositorio, VehiculosRepositorio>()
                .AddScoped<IVehiculosTipoRepositorio, VehiculosTipoRepositorio>()
                .AddScoped<IFormulario04DRepositorio, Formulario04DRepositorio>();
            
            //Unit of work
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}