using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.core.Modelos
{
    public class Vehiculos : BaseEntity
    {
        public string Descripcion { get; set; }
        public int Marcasid { get; set; }
        public Marcas Marcas { get; set; }
        public int Modelosid { get; set; }
        public Modelos Modelos { get; set; }
        public short? Anio { get; set; }
        public short? Puertas { get; set; }
        public string Patente { get; set; }
        public string Chasis { get; set; }
        public string Motor { get; set; }
        public string Propietario { get; set; }
        public int? Coloresid { get; set; }
        public int? Formulario04did { get; set; }
        public int? Fechapedido04d { get; set; }
        public int? Fechaingresounidad { get; set; }
        public int? Fechadespiece { get; set; }
        public int? Companiasid { get; set; }
        public double? Costorecupero { get; set; }
        public int? Fechapagorecupero { get; set; }
        public int? Numerocertificadobaja { get; set; }
        public string Observaciones { get; set; }
        public int? Marcaschasisid { get; set; }
        public int? Marcasmotoresid { get; set; }
        public string Tipocombustible { get; set; }
        public int? Vehiculostipoid { get; set; }
        public byte? Impreso { get; set; }
        public int? Librosid { get; set; }
        public int? Depositosid { get; set; }
        public string Nrosiniestro { get; set; }
        public int? Empleadosid { get; set; }
        public byte? Paracompactar { get; set; }
        public int? Fechacompactacion { get; set; }
        public int? Vehiculoscompactadosid { get; set; }
        public int? Facturarecupero { get; set; }
        public int? Categoriasid { get; set; }
        public string Tipotransmision { get; set; }
        public int? Tiposcombustibleid { get; set; }
        public int? Fechabajadnrpa { get; set; }
    }
}
