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

        public Task<Vehiculos> Agregar(Vehiculos vehiculo)
        {
            throw new NotImplementedException();
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
                
                await _unitOfWork.CommitAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public async Task<IEnumerable<Vehiculos>> BuscarVehiculo(string pPatente, int pMarcasId, int pModelosId, bool pMostrarCompactados)
        {
            if (pPatente != null)
                return await _unitOfWork.VehiculosRepositorio.BuscarVehiculos(BuscarPorPatente(pPatente, pMostrarCompactados));

            else if (pMarcasId != 0 && pModelosId != 0)
                return await _unitOfWork.VehiculosRepositorio.BuscarVehiculos(BuscarPorMarcaModelo(pMarcasId, pModelosId, pMostrarCompactados));

            else
                return null;
        }

        Expression<Func<Vehiculos, bool>> BuscarPorPatente(string pPatente, bool pMostrarCompactados)
        {
            switch (pMostrarCompactados)
            {
                case true:
                    return x => x.Patente == pPatente && x.Vehiculoscompactadosid > 0;

                case false:
                    return x => x.Patente == pPatente && x.Vehiculoscompactadosid == 0;               
            }
            
        }

        Expression<Func<Vehiculos, bool>> BuscarPorMarcaModelo(int pMarcasId, int pModelosId, bool pMostrarCompactados)
        {
            switch (pMostrarCompactados)
            {
                case true:
                    return x => (x.Marcasid == pMarcasId && x.Modelosid == pModelosId) && x.Vehiculoscompactadosid > 0;

                case false:
                    return x => (x.Marcasid == pMarcasId && x.Modelosid == pModelosId) && x.Vehiculoscompactadosid == 0;
            }

        }
    }
}
