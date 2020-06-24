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
    [Route("api/Categorias")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private ICategoriasServicio _categoriasServicio;
        private readonly IMapper _mapper;

        public CategoriasController(ICategoriasServicio _categoriasServicio, IMapper mapper)
        {
            this._mapper = mapper;
            this._categoriasServicio = _categoriasServicio;
        }

        [HttpGet("ListarTodos")]
        public async Task<IEnumerable<Categorias>> ListarTodos() => await _categoriasServicio.ListarTodos();
        
    }
}