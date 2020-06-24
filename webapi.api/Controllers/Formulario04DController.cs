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
    [Route("api/Formulario04D")]
    [ApiController]
    public class Formulario04DController : ControllerBase
    {
        private IFormulario04DServicio _formulario04DServicio;
        private readonly IMapper _mapper;

        public Formulario04DController(IFormulario04DServicio _formulario04DServicio, IMapper mapper)
        {
            this._mapper = mapper;
            this._formulario04DServicio = _formulario04DServicio;
        }

        [HttpGet("ListarTodos")]
        public async Task<ActionResult<IEnumerable<Formulario04DRecurso>>> ListarTodos()
        {
            var formulario04D = await _formulario04DServicio.ListarTodos();
            var formulario04DRecurso = _mapper.Map<IEnumerable<Formulario04D>, IEnumerable<Formulario04DRecurso>>(formulario04D);

            return Ok(formulario04DRecurso);
        }     
        
        [HttpGet("ObtenerPorVehiculo")]
        public async Task<ActionResult<Formulario04DRecurso>> ObtenerPorVehiculo(int pVehiculosId)
        {
            var formulario04D = await _formulario04DServicio.ObtenerPorVehiculo(pVehiculosId);
            var formulario04DRecurso = _mapper.Map<Formulario04D, Formulario04DRecurso>(formulario04D);

            return Ok(formulario04DRecurso);
        }
    }
}