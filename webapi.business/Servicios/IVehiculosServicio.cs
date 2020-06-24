﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using webapi.core.Modelos;

namespace webapi.business.Servicios
{
    public interface IVehiculosServicio
    {
        Task<IEnumerable<Vehiculos>> ListarTodos();
        Task<Vehiculos> ObtenerPorId(int pId);
        Task<Vehiculos> ObtenerPorIdConDatos(int pId);
        Task<IEnumerable<Vehiculos>> ObtenerPorPatente(string pPatente);
        Task<Vehiculos> Agregar(Vehiculos vehiculo);
        Task Actualizar(Vehiculos pVehiculoActualizar, Vehiculos pVehiculo);
        Task<IEnumerable<Vehiculos>> ObtenerPorMarca(int pMarcasId);
        Task<IEnumerable<Vehiculos>> ObtenerPorMarcaModelo(int pMarcasId, int pModelosId);
        Task<IEnumerable<Vehiculos>> BuscarVehiculo(string pPatente, int pMarcasId, int pModelosId, bool pMostrarCompactados);
        //Task<IEnumerable<Vehiculos>> ListarTodos();
    }
}