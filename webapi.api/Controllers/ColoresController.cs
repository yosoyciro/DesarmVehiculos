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
    [Route("api/Colores")]
    [ApiController]
    public class ColoresController : ControllerBase
    {
        private IColoresServicio _coloresServicio;
        private readonly IMapper _mapper;

        public ColoresController(IColoresServicio _coloresServicio, IMapper mapper)
        {
            this._mapper = mapper;
            this._coloresServicio = _coloresServicio;
        }

        [HttpGet("ListarTodos")]
        public async Task<IEnumerable<Colores>> ListarTodos() => await _coloresServicio.ListarTodos();
    }
}