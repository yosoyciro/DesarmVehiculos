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
    [Route("api/ArticulosStock")]
    [ApiController]
    public class ArticulosStockController : ControllerBase
    {
        private IArticulosStockServicio _articulosStockServicio;
        private readonly IMapper _mapper;

        public ArticulosStockController(IArticulosStockServicio _articulosStockServicio, IMapper mapper)
        {
            this._mapper = mapper;
            this._articulosStockServicio = _articulosStockServicio;
        }

        [HttpGet("ListarTodos")]
        public async Task<IEnumerable<ArticulosStock>> ListarTodos() => await _articulosStockServicio.ListarTodos();

        [HttpGet("ObtenerPorVehiculo")]
        public async Task<ActionResult<IEnumerable<ArticulosStockRecurso>>> ObtenerPorVehiculo(int pVehiculosId)
        {
            var articulosStock = await _articulosStockServicio.ObtenerPorVehiculo(pVehiculosId);
            var articulosStockRecurso = _mapper.Map<IEnumerable<ArticulosStock>, IEnumerable<ArticulosStockRecurso>>(articulosStock);

            return Ok(articulosStockRecurso);
        }

        [HttpGet("ObtenerPorFormulario04D")]
        public async Task<ActionResult<IEnumerable<ArticulosStockRecurso>>> ObtenerPorFormulario04D(int pFormularios04DId   )
        {
            var articulosStock = await _articulosStockServicio.ObtenerPorFormulario04D(pFormularios04DId);
            var articulosStockRecurso = _mapper.Map<IEnumerable<ArticulosStock>, IEnumerable<ArticulosStockRecurso>>(articulosStock);

            return Ok(articulosStockRecurso);
        }
    }
}
