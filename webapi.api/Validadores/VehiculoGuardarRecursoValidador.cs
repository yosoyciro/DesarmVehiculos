using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using webapi.api.Recursos;

namespace webapi.api.Validadores
{
    public class VehiculoGuardarRecursoValidador : AbstractValidator<VehiculoGuardarRecurso>
    {
        public VehiculoGuardarRecursoValidador()
        {
            RuleFor(a => a.MarcasId)
                .NotEmpty()
                .WithMessage("'MarcasId' no puede ser 0.");
        }
    }
}
