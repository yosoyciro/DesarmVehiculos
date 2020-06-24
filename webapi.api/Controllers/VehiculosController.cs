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

        [HttpPost("Agregar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Agregar(VehiculosRecurso pVehiculo)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState); //BadRequest(ModelState);
            }
            try
            {
                var vehiculo = _mapper.Map<VehiculosRecurso, Vehiculos>(pVehiculo);
                _vehiculosServicios.Agregar(vehiculo);
                return StatusCode(200, vehiculo);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.InnerException.Message);
            }
            
        }

        //[HttpPost("Actualizar")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public IActionResult Actualizar(Vehiculos pVehiculo)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return StatusCode(400, ModelState); //BadRequest(ModelState);
        //    }
        //    try
        //    {
        //        var vehiculo = _mapper.Map<Vehiculos, VehiculosRecurso>(pVehiculo);
        //        _vehiculosServicios.Actualizar(pVehiculo);
        //        return StatusCode(200, vehiculo);
        //    }
        //    catch (Exception e)
        //    {
        //        return StatusCode(500, e.InnerException.Message);
        //    }

        //}

        [HttpPut("Actualizar")]
        public async Task<ActionResult<VehiculosRecurso>> ActualizarVehiculo(int pId, [FromBody] Vehiculos pVehiculo)
        {
            //var validator = new SaveArtistResourceValidator();
            //var validationResult = await validator.ValidateAsync(saveArtistResource);

            //if (!validationResult.IsValid)
            //    return BadRequest(validationResult.Errors); // this needs refining, but for demo it is ok

            var vehiculoActualizar = await _vehiculosServicios.ObtenerPorIdConDatos(pId);

            if (vehiculoActualizar == null)
            {
                return NotFound();
            }

            await _vehiculosServicios.Actualizar(vehiculoActualizar, pVehiculo);

            var vehiculoActualizado = await _vehiculosServicios.ObtenerPorIdConDatos(pId);

            var vehiculoActualizadoRecurso = _mapper.Map<Vehiculos, VehiculosRecurso>(vehiculoActualizado);

            return Ok(vehiculoActualizadoRecurso);
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