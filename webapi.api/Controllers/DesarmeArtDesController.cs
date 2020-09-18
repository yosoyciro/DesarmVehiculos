using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.core.Modelos;
using webapi.business.Servicios.Implementaciones;
using webapi.root;
using webapi.data.Repositorios;
using webapi.business.Servicios;
using AutoMapper;
using webapi.api.Recursos;

namespace webapi.api.Controllers
{
    [Route("api/DesarmeArtDes")]
    [ApiController]
    public class DesarmeArtDesController : ControllerBase
    {
        private IDesarmeArtDesServicio _desarmeArtDesServicio;
        private readonly IMapper _mapper;

        public DesarmeArtDesController(IDesarmeArtDesServicio _desarmeArtDesServicio, IMapper mapper)
        {
            this._mapper = mapper;
            this._desarmeArtDesServicio = _desarmeArtDesServicio;
        }

        [HttpGet("ListarTodos")]
        public async Task<IEnumerable<DesarmeArtDes>> ListarTodos() => await _desarmeArtDesServicio.ListarTodos();

        [HttpGet("ObtenerPorVehiculo")]
        public async Task<ActionResult<DesarmeArtDesRecurso>> ObtenerPorVehiculo(int pVehiculosId)
        {
            var desarmeArtDes = await _desarmeArtDesServicio.ObtenerPorVehiculo(pVehiculosId);
            var desarmeArtDesRecurso = _mapper.Map<DesarmeArtDes, DesarmeArtDesRecurso>(desarmeArtDes);

            return Ok(desarmeArtDesRecurso);

        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult<DesarmeArtDesRecurso>> ActualizarVehiculo(int pId, [FromBody] DesarmeArtDesRecurso pDesarmeArtDes)
        {
            //Guardo
            var desarmeArtDesActualizar = await _desarmeArtDesServicio.ObtenerPorIdConDatos(pId);

            if (desarmeArtDesActualizar == null)
            {
                return NotFound();
            }

            var desarmeArtDes = _mapper.Map<DesarmeArtDesRecurso, DesarmeArtDes>(pDesarmeArtDes);
            await _desarmeArtDesServicio.Actualizar(desarmeArtDesActualizar, desarmeArtDes);

            var desarmeArtDesActualizado = await _desarmeArtDesServicio.ObtenerPorIdConDatos(pId);

            var desarmeArtDesActualizadoRecurso = _mapper.Map<DesarmeArtDes, DesarmeArtDesRecurso>(desarmeArtDesActualizado);

            return Ok(desarmeArtDesActualizadoRecurso);
        }
    }
}
