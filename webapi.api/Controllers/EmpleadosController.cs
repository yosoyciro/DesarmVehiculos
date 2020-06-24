﻿using System;
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
    [Route("api/Empleados")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private IEmpleadosServicio _servicio;
        private readonly IMapper _mapper;

        public EmpleadosController(IEmpleadosServicio _servicio, IMapper mapper)
        {
            this._mapper = mapper;
            this._servicio = _servicio;
        }

        [HttpGet("ListarTodos")]
        public async Task<IEnumerable<Empleados>> ListarTodos() => await _servicio.ListarTodos();
    }
}