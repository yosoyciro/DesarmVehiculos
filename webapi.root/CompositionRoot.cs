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
            services.AddScoped<IVehiculosServicios, VehiculosServicio>();
            services.AddScoped<IVehiculosRepositorio, VehiculosRepositorio>();
            //services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}