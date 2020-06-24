using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.api.Recursos
{
    public class VehiculosRecurso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Patente { get; set; }
        public short Anio { get; set; }
        public short Puertas { get; set; }
        public string Chasis { get; set; }
        public string Motor { get; set; }
        public string Propietario { get; set; }
        public ColoresRecurso Colores { get; set; }
        public int? Formulario04did { get; set; }
        public int? Fechapedido04d { get; set; }
        public int? Fechaingresounidad { get; set; }
        public int? Fechadespiece { get; set; }
        public CompaniasRecurso Companias { get; set; }
        public double? Costorecupero { get; set; }
        public int? Fechapagorecupero { get; set; }
        public int? Numerocertificadobaja { get; set; }
        public string Observaciones { get; set; }
        public MarcasChasisRecurso MarcasChasis { get; set; }
        public MarcasMotorRecurso MarcasMotor { get; set; }
        public string Tipocombustible { get; set; }
        public VehiculosTipoRecurso VehiculosTipo { get; set; }
        public byte? Impreso { get; set; }
        public int? Librosid { get; set; }
        public DepositosRecurso Depositos { get; set; }
        public string Nrosiniestro { get; set; }
        public EmpleadosRecurso Empleados { get; set; }
        public byte? Paracompactar { get; set; }
        public int? Fechacompactacion { get; set; }
        public int? Vehiculoscompactadosid { get; set; }
        public int? Facturarecupero { get; set; }
        public CategoriasRecurso Categorias { get; set; }
        public string Tipotransmision { get; set; }
        public TiposCombustibleRecurso TiposCombustible { get; set; }
        public int? Fechabajadnrpa { get; set; }
        public MarcasRecurso Marcas { get; set; }
        public ModelosRecurso Modelos { get; set; }
    }
}
