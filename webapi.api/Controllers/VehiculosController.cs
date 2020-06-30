using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapi.core.Modelos;
using webapi.business.Servicios.Implementaciones;
using webapi.root;
using webapi.data.Repositorios;
using webapi.business.Servicios;
using AutoMapper;
using webapi.api.Recursos;
using webapi.api.Validadores;

namespace webapi.api.Controllers
{
    [Route("api/Vehiculos")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private IVehiculosServicio _vehiculosServicios;
        private readonly IMapper _mapper;

        public VehiculosController(IVehiculosServicio _vehiculosServicios, IMapper mapper)
        {
            this._mapper = mapper;
            this._vehiculosServicios = _vehiculosServicios;
        }

        [HttpGet("ListarTodos")]
        public async Task<IEnumerable<Vehiculos>> ListarTodos() => await _vehiculosServicios.ListarTodos();


        [HttpGet("ObtenerPorPatente={pPatente}")]
        public async Task<ActionResult<IEnumerable<VehiculosRecurso>>> ObtenerPorPatente(string pPatente)
        {
            var vehiculo = await _vehiculosServicios.ObtenerPorPatente(pPatente);
            var vehiculoRecurso = _mapper.Map<IEnumerable<Vehiculos>, IEnumerable<VehiculosRecurso>>(vehiculo);

            return Ok(vehiculoRecurso);

        }

        [HttpGet("ObtenerPorMarcaModelo")]
        public async Task<ActionResult<IEnumerable<VehiculosRecurso>>> ObtenerPorMarcaModelo(int pMarcasId, int pModelosId)
        {
            var vehiculo = await _vehiculosServicios.ObtenerPorMarcaModelo(pMarcasId, pModelosId);
            var vehiculoRecurso = _mapper.Map<IEnumerable<Vehiculos>, IEnumerable<VehiculosRecurso>>(vehiculo);

            return Ok(vehiculoRecurso);

        }
       

        [HttpPut("Actualizar")]
        public async Task<ActionResult<VehiculosRecurso>> ActualizarVehiculo(int pId, [FromBody] VehiculoGuardarRecurso pVehiculo)
        {
            //Validaciones
            var validator = new VehiculoGuardarRecursoValidador();
            var validador = await validator.ValidateAsync(pVehiculo);

            if (!validador.IsValid)
                return BadRequest(validador.Errors);

            //Guardo
            var vehiculoActualizar = await _vehiculosServicios.ObtenerPorIdConDatos(pId);

            if (vehiculoActualizar == null)
            {
                return NotFound();
            }

            var vehiculo = _mapper.Map<VehiculoGuardarRecurso, Vehiculos>(pVehiculo);
            await _vehiculosServicios.Actualizar(vehiculoActualizar, vehiculo);

            var vehiculoActualizado = await _vehiculosServicios.ObtenerPorIdConDatos(pId);

            var vehiculoActualizadoRecurso = _mapper.Map<Vehiculos, VehiculosRecurso>(vehiculoActualizado);

            return Ok(vehiculoActualizadoRecurso);
        }

        [HttpPost("Agregar")]
        public async Task<ActionResult<VehiculosRecurso>> AgregarVehiculo([FromBody] VehiculoGuardarRecurso pVehiculo)
        {
            //Validaciones
            var validator = new VehiculoGuardarRecursoValidador();
            var validador = await validator.ValidateAsync(pVehiculo);

            if (!validador.IsValid)
                return BadRequest(validador.Errors);

            //Guardo
            var vehiculoCrear = _mapper.Map<VehiculoGuardarRecurso, Vehiculos>(pVehiculo);

            var vehiculoNuevo = await _vehiculosServicios.AgregarAsync(vehiculoCrear);
            var vehiculo = await _vehiculosServicios.ObtenerPorIdConDatos(vehiculoNuevo.Id);
            var vehiculoRecurso = _mapper.Map<Vehiculos, VehiculosRecurso>(vehiculo);   

            return Ok(vehiculoRecurso);
        }

        [HttpGet("BuscarVehiculos")]
        public async Task<ActionResult<IEnumerable<VehiculosRecurso>>> Buscar(string pPatente, int pMarcasId, int pModelosId, bool pMostrarCompactados)
        {
            var vehiculo = await _vehiculosServicios.BuscarVehiculo(pPatente, pMarcasId, pModelosId, pMostrarCompactados);
            var vehiculoRecurso = _mapper.Map<IEnumerable<Vehiculos>, IEnumerable<VehiculosRecurso>>(vehiculo);

            return Ok(vehiculoRecurso);

        }
    }
}