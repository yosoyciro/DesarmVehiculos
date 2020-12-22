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
    [Route("api/Remitos")]
    [ApiController]
    public class RemitosController : ControllerBase
    {
        private IRemitosServicio _remitosServicio;
        private readonly IMapper _mapper;

        public RemitosController(IRemitosServicio _remitosServicio, IMapper mapper)
        {
            this._mapper = mapper;
            this._remitosServicio = _remitosServicio;
        }

        [HttpGet("ObtenerPorIdConDetalle")]
        public async Task<ActionResult<RemitosRecurso>> ObtenerPorIdConDetalle(int pRemitosId)
        {
            var remito = await _remitosServicio.ObtenerPorIdConDetalle(pRemitosId);
            var remitoRecurso = _mapper.Map<Remitos, RemitosRecurso>(remito);

            return Ok(remitoRecurso);
        }

        [HttpPost("Agregar")]
        public async Task<ActionResult<RemitoGuardarRecurso>> AgregarRemito([FromBody] RemitoGuardarRecurso pRemito)
        {
            //Guardo
            try
            {
                var remitoCrear = _mapper.Map<RemitoGuardarRecurso, Remitos>(pRemito);

                var remitoNuevo = await _remitosServicio.AgregarAsync(remitoCrear);
                var remito = await _remitosServicio.ObtenerPorIdConDetalleYAuditoria(remitoNuevo.Id);
                var remitoRecurso = _mapper.Map<Remitos, RemitosRecurso>(remito);

                return Ok(remitoRecurso);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException.Message);  //Content( ex.InnerException.Message);
            }

        }

        [HttpPut("Anular")]
        public async Task<ActionResult<RemitosRecurso>> AnularRemito(int pId)
        {
            //Guardo
            var remitoAnular = await _remitosServicio.ObtenerPorIdConDetalle(pId);

            if (remitoAnular == null)
            {
                return NotFound();
            }
            
            await _remitosServicio.Anular(remitoAnular);

            var remitoActualizado = await _remitosServicio.ObtenerPorIdConDetalle(pId);

            var remitoActualizadoRecurso = _mapper.Map<Remitos, RemitosRecurso>(remitoActualizado);

            return Ok(remitoActualizadoRecurso);
        }
    }
}
