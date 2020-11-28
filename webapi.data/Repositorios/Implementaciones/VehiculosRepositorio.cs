using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace webapi.data.Repositorios.Implementaciones
{
    public class VehiculosRepositorio : Repositorio<Vehiculos>, IVehiculosRepositorio
    {
        public VehiculosRepositorio(DesarmDatacenterContext context) : base(context) { }
        public async Task<IEnumerable<Vehiculos>> ObtenerPorPatente(string pPatente)
        {
            return await context.Vehiculos
                .Include(v => v.Marcas)
                .Include(v => v.Modelos)
                .Include(v => v.TiposCombustible)
                .Include(v => v.Companias)
                .Include(v => v.Colores)
                .Include(v => v.Categorias)
                .Include(v => v.Depositos)
                .Include(v => v.Empleados)
                .Include(v => v.MarcasChasis)
                .Include(v => v.MarcasMotor)
                .Include(v => v.VehiculosTipo)
                .Include(v => v.DepositosIslasUbicaciones)
                .Where(vehiculo => vehiculo.Patente == pPatente && vehiculo.Vehiculoscompactadosid == 0)
                .ToListAsync();
        }

        public async Task<Vehiculos> ObtenerPorIdConDatos(int pId)
        {
            return await context.Set<Vehiculos>()
                .Include(v => v.Marcas)
                .Include(v => v.Modelos)
                .Include(v => v.TiposCombustible)
                .Include(v => v.Companias)
                .Include(v => v.Colores)
                .Include(v => v.Categorias)
                .Include(v => v.Depositos)
                .Include(v => v.Empleados)
                .Include(v => v.MarcasChasis)
                .Include(v => v.MarcasMotor)
                .Include(v => v.VehiculosTipo)
                .Include(v => v.DepositosIslasUbicaciones)
                .SingleOrDefaultAsync(v => v.Id == pId);
        }

        public async Task<IEnumerable<Vehiculos>> ObtenerPorMarca (int pMarcasId)
        {
            return await context.Vehiculos
                .Include(v => v.Marcas)
                .Include(v => v.Modelos)
                .Include(v => v.TiposCombustible)
                .Include(v => v.Companias)
                .Include(v => v.Colores)
                .Include(v => v.Categorias)
                .Include(v => v.Depositos)
                .Include(v => v.Empleados)
                .Include(v => v.MarcasChasis)
                .Include(v => v.MarcasMotor)
                .Include(v => v.VehiculosTipo)
                .Include(v => v.DepositosIslasUbicaciones)
                .Where(vehiculo => vehiculo.Marcasid == pMarcasId && vehiculo.Vehiculoscompactadosid == 0)
                .ToListAsync();
        }

        public async Task<IEnumerable<Vehiculos>> ObtenerPorMarcaModelo(int pMarcasId, int pModelosId)
        {
            return await context.Vehiculos
                .Include(v => v.Marcas)
                .Include(v => v.Modelos)
                .Include(v => v.TiposCombustible)
                .Include(v => v.Companias)
                .Include(v => v.Colores)
                .Include(v => v.Categorias)
                .Include(v => v.Depositos)
                .Include(v => v.Empleados)
                .Include(v => v.MarcasChasis)
                .Include(v => v.MarcasMotor)
                .Include(v => v.VehiculosTipo)
                .Include(v => v.DepositosIslasUbicaciones)
                .Where(vehiculo => vehiculo.Marcasid == pMarcasId && vehiculo.Modelosid == pModelosId && vehiculo.Vehiculoscompactadosid == 0)
                .ToListAsync();
        }

        /*public async Task<IEnumerable<Vehiculos>> BuscarVehiculos(Expression<Func<Vehiculos, bool>> predicate)
        {
             var vehiculos = await context.Vehiculos
                .Include(v => v.Marcas)
                .Include(v => v.Modelos)
                .Include(v => v.TiposCombustible)
                .Include(v => v.Companias)
                .Include(v => v.Colores)
                .Include(v => v.Categorias)
                .Include(v => v.Depositos)
                .Include(v => v.Empleados)
                .Include(v => v.MarcasChasis)
                .Include(v => v.MarcasMotor)
                .Include(v => v.VehiculosTipo)
                .Include(v => v.DepositosIslasUbicaciones)
                .Include(v => v.Formulario04D)
                .Where(predicate)
                .ToListAsync();

            return vehiculos;
        }*/

        public async Task<IEnumerable<Vehiculos>> BuscarVehiculosMultiple(int pDepositosIslasUbicacionesId, string pPatente, int pMarcasId, int pModelosId, int pMostrarCompactados, string pNroChasis, int pLegajo, int pDepositosId)
        {
            var vehiculos = await context.Vehiculos
               .Include(v => v.Marcas)
               .Include(v => v.Modelos)
               .Include(v => v.TiposCombustible)
               .Include(v => v.Companias)
               .Include(v => v.Colores)
               .Include(v => v.Categorias)
               .Include(v => v.Depositos)
               .Include(v => v.Empleados)
               .Include(v => v.MarcasChasis)
               .Include(v => v.MarcasMotor)
               .Include(v => v.VehiculosTipo)
               .Include(v => v.DepositosIslasUbicaciones)
               .Include(v => v.Formulario04D)
               .Where(v => (0 == pDepositosIslasUbicacionesId || v.DepositosIslasUbicacionesId == pDepositosIslasUbicacionesId)
                    && (0 == pMarcasId || v.Marcasid == pMarcasId) 
                    && (0 == pModelosId || v.Modelosid == pModelosId)
                    && (0 == pLegajo || v.Formulario04D.NROLEGAJO == pLegajo)
                    && (null == pPatente || v.Patente.Contains(pPatente))
                    && (null == pNroChasis || v.Chasis.Contains(pNroChasis))
                    && (1 == pMostrarCompactados || v.Vehiculoscompactadosid == 0)
                    && (0 == pDepositosId || v.Depositosid == pDepositosId))
               .ToListAsync();

            return vehiculos;
        }

        /*public async Task<IEnumerable<Vehiculos>> BuscarPorLegajo(int pLegajo)
        {
            var Formularios04D = await context.Formulario04D
                .Where(f => f.NROLEGAJO == pLegajo)
                .Select(f => f.VEHICULOSID)
                .ToArrayAsync();

            var vehiculos = await context.Vehiculos
                .Include(v => v.Marcas)
                .Include(v => v.Modelos)
                .Include(v => v.TiposCombustible)
                .Include(v => v.Companias)
                .Include(v => v.Colores)
                .Include(v => v.Categorias)
                .Include(v => v.Depositos)
                .Include(v => v.Empleados)
                .Include(v => v.MarcasChasis)
                .Include(v => v.MarcasMotor)
                .Include(v => v.VehiculosTipo)
                .Include(v => v.DepositosIslasUbicaciones)
                .Include(v => v.Formulario04D)
                .Where(v => Formularios04D.Contains(v.Id))
                .ToListAsync();

            return vehiculos;
            
        }*/

        public async Task<Vehiculos> AgregarAsync(Vehiculos pVehiculo)
        {
            await context.Set<Vehiculos>().AddAsync(pVehiculo);
            return pVehiculo;
        }

        public async Task<Vehiculos> ObtenerPorPatenteConArticulosStock(string pPatente)
        {
            return await context.Vehiculos
                .Include(v => v.ArticulosStock)
                .SingleOrDefaultAsync(v => v.Patente == pPatente);
        }

        private DesarmDatacenterContext DesarmDatacenterContext
        {
            get { return context as DesarmDatacenterContext; }
        }
    }
}
