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
        private IVehiculosServicios _vehiculosServicios;
        private readonly IMapper _mapper;

        public VehiculosController(IVehiculosServicios _vehiculosServicios, IMapper mapper)
        {
            this._mapper = mapper;
            this._vehiculosServicios = _vehiculosServicios;
        }

        [HttpGet("ListarTodos")]
        [Produces("application/xml")]
        //public IEnumerable<Vehiculos> GetByPatente() => _vehiculosServicios.ListarTodos();

        [HttpGet("ObtenerPorId={pVehiculosId}")]
        //[Produces("application/xml")]
        public async Task<Vehiculos> ObtenerPorId(int pVehiculosId) => await _vehiculosServicios.ObtenerPorId(pVehiculosId);

        [HttpGet("ObtenerPorPatente={pPatente}")]
        public async Task<ActionResult<VehiculosRecurso>> ObtenerPorPatente(string pPatente)
        {
            var vehiculo = await _vehiculosServicios.ObtenerPorPatente(pPatente);
            var vehiculoRecurso = _mapper.Map<Vehiculos, VehiculosRecurso>(vehiculo);

            return Ok(vehiculoRecurso);

        }

        [HttpPost("Agregar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/xml")]
        public IActionResult Agregar(Vehiculos pVehiculo)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400, ModelState); //BadRequest(ModelState);
            }
            try
            {
                _vehiculosServicios.Agregar(pVehiculo);
                return StatusCode(200, pVehiculo);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.InnerException.Message);
            }
            
        }
    }
}