using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;
using webapi.data.Repositorios;
using webapi.data.Repositorios.Implementaciones;
using webapi.data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace webapi.business.Servicios.Implementaciones
{
    public class VehiculosServicio : IVehiculosServicio
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehiculosServicio(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
       
        public async Task<IEnumerable<Vehiculos>> ObtenerPorPatente(string pPatente)
        {
            return await _unitOfWork.VehiculosRepositorio
                .ObtenerPorPatente(pPatente);
        }

        public async Task<Vehiculos> ObtenerPorPatenteConArticulosStock(string pPatente)
        {
            return await _unitOfWork.VehiculosRepositorio
                .ObtenerPorPatenteConArticulosStock(pPatente);
        }

        public async Task<Vehiculos> ObtenerPorId(int pId)
        {
            return await _unitOfWork.VehiculosRepositorio.ObtenerPorId(pId);
        }

        public async Task<Vehiculos> ObtenerPorIdConDatos(int pId)
        {
            return await _unitOfWork.VehiculosRepositorio.ObtenerPorIdConDatos(pId);
        }

        public async Task<IEnumerable<Vehiculos>> ListarTodos()
        {
            return await _unitOfWork.VehiculosRepositorio.ListarTodos();
        }

        public Task<IEnumerable<Vehiculos>> ObtenerPorMarca(int pMarcasId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Vehiculos>> ObtenerPorMarcaModelo(int pMarcasId, int pModelosId)
        {
            return await _unitOfWork.VehiculosRepositorio.ObtenerPorMarcaModelo(pMarcasId, pModelosId);
        }


        public async Task Actualizar(Vehiculos pVehiculoActualizar, Vehiculos pVehiculo)
        {
            try
            {
                pVehiculoActualizar.Marcasid = pVehiculo.Marcasid;
                pVehiculoActualizar.Marcasid = pVehiculo.Marcasid;
                pVehiculoActualizar.Modelosid = pVehiculo.Modelosid;
                pVehiculoActualizar.Descripcion = pVehiculo.Descripcion;
                pVehiculoActualizar.Vehiculostipoid = pVehiculo.Vehiculostipoid;
                pVehiculoActualizar.Categoriasid = pVehiculo.Categoriasid;
                pVehiculoActualizar.Anio = pVehiculo.Anio;
                pVehiculoActualizar.Patente = pVehiculo.Patente;
                pVehiculoActualizar.Chasis = pVehiculo.Chasis;
                pVehiculoActualizar.Motor = pVehiculo.Motor;
                pVehiculoActualizar.Propietario = pVehiculo.Propietario;
                pVehiculoActualizar.Marcaschasisid = pVehiculo.Marcaschasisid;
                pVehiculoActualizar.Marcasmotoresid = pVehiculo.Marcasmotoresid;
                pVehiculoActualizar.Tiposcombustibleid = pVehiculo.Tiposcombustibleid;
                pVehiculoActualizar.Tipotransmision = pVehiculo.Tipotransmision;
                pVehiculoActualizar.Coloresid = pVehiculo.Coloresid;
                pVehiculoActualizar.Fechapedido04d = pVehiculo.Fechapedido04d;
                pVehiculoActualizar.Fechaingresounidad = pVehiculo.Fechaingresounidad;
                pVehiculoActualizar.Depositosid = pVehiculo.Depositosid;
                pVehiculoActualizar.Fechadespiece = pVehiculo.Fechadespiece;
                pVehiculoActualizar.Fechabajadnrpa = pVehiculo.Fechabajadnrpa;
                pVehiculoActualizar.Companiasid = pVehiculo.Companiasid;
                pVehiculoActualizar.Nrosiniestro = pVehiculo.Nrosiniestro;
                pVehiculoActualizar.Costorecupero = pVehiculo.Costorecupero;
                pVehiculoActualizar.Fechapagorecupero = pVehiculo.Fechapagorecupero;
                pVehiculoActualizar.Facturarecupero = pVehiculo.Facturarecupero;
                pVehiculoActualizar.Numerocertificadobaja = pVehiculo.Numerocertificadobaja;                
                pVehiculoActualizar.Empleadosid = pVehiculo.Empleadosid;
                pVehiculoActualizar.Usuario = pVehiculo.Usuario;
                pVehiculoActualizar.FechaActualizacion = pVehiculo.FechaActualizacion;
                pVehiculoActualizar.DepositosIslasUbicacionesId = pVehiculo.DepositosIslasUbicacionesId;
                
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public async Task<Vehiculos> AgregarAsync(Vehiculos pVehiculo)
        {
            try
            {
                await _unitOfWork.VehiculosRepositorio.AgregarAsync(pVehiculo);
                await _unitOfWork.CommitAsync();

                return pVehiculo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        //public async Task<IEnumerable<Vehiculos>> BuscarVehiculo(string pPatente, int pMarcasId, int pModelosId, bool pMostrarCompactados, string pNroChasis, int pLegajo)
        //{
        //    if (pPatente != null)
        //        return await _unitOfWork.VehiculosRepositorio.BuscarVehiculos(BuscarPorPatente(pPatente, pMostrarCompactados));

        //    if (pMarcasId != 0)
        //        return await _unitOfWork.VehiculosRepositorio.BuscarVehiculos(BuscarPorMarcaModelo(pMarcasId, pModelosId, pMostrarCompactados));

        //    if (pNroChasis != "" && pNroChasis != null)
        //        return await _unitOfWork.VehiculosRepositorio.BuscarVehiculos(BuscarPorChasis(pNroChasis, pMostrarCompactados));

        //    if (pLegajo != 0)
        //        return await _unitOfWork.VehiculosRepositorio.BuscarPorLegajo(pLegajo);

        //    else
        //        return null;
        //}

        public async Task<IEnumerable<Vehiculos>> BuscarVehiculosMultiple(int pDepositosIslasUbicacionesId, string pPatente, int pMarcasId, int pModelosId, int pMostrarCompactados, string pNroChasis, int pLegajo, int pDepositosId)
        {
            return await _unitOfWork.VehiculosRepositorio.BuscarVehiculosMultiple(pDepositosIslasUbicacionesId, pPatente, pMarcasId, pModelosId, pMostrarCompactados, pNroChasis, pLegajo, pDepositosId);
        }

        /*#region expresiones
        Expression<Func<Vehiculos, bool>> BuscarPorPatente(string pPatente, bool pMostrarCompactados)
        {            
            switch (pMostrarCompactados)
            {
                case true:
                    return x => x.Patente.Contains(pPatente);

                case false:
                    return x => x.Patente.Contains(pPatente) && x.Vehiculoscompactadosid == 0;
            }

        }

        Expression<Func<Vehiculos, bool>> BuscarPorMarcaModelo(int pMarcasId, int pModelosId, bool pMostrarCompactados)
        {
            switch (pMostrarCompactados)
            {
                case true:
                    if (pModelosId != 0)
                        return x => x.Marcasid == pMarcasId && x.Modelosid == pModelosId;
                    else
                        return x => x.Marcasid == pMarcasId;

                case false:
                    if (pModelosId != 0)
                        return x => (x.Marcasid == pMarcasId && x.Modelosid == pModelosId && x.Vehiculoscompactadosid == 0);
                    else
                        return x => (x.Marcasid == pMarcasId && x.Vehiculoscompactadosid == 0);
            }

        }

        Expression<Func<Vehiculos, bool>> BuscarPorChasis(string pNroChasis, bool pMostrarCompactados)
        {
            switch (pMostrarCompactados)
            {
                case true:
                    //return x => x.Chasis.Contains(pNroChasis);
                    return x => x.Chasis.EndsWith(pNroChasis);

                case false:
                    return x => x.Chasis.EndsWith(pNroChasis) && x.Vehiculoscompactadosid == 0;
            }

        }
        #endregion*/

        public async Task ActualizarDepositosIslasUbicaciones(Vehiculos pVehiculoActualizar, int pDepositosIslasUbicacionesId)
        {
            try
            {
                pVehiculoActualizar.DepositosIslasUbicacionesId = pDepositosIslasUbicacionesId;

                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
