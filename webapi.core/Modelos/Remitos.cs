using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.core.Modelos
{
    public class Remitos : BaseEntity
    {
        public Remitos()
        {
            //RemitosDetalles = new Collection<RemitosDetalle>();
            //RemitosAuditorias = new Collection<RemitosAuditoria>();
            //DepositoOrigen = new Depositos();
            //DepositoDestino = new Depositos();
        }
        public int FECHA { get; set; }
        public int DEPOSITOSIDORIGEN { get; set; }
        public int DEPOSITOSIDDESTINO { get; set; }
        public string ESTADO { get; set; }
        public Int64 HORA { get; set; }
        public ICollection<RemitosDetalle> RemitosDetalles { get; set; }
        public ICollection<RemitosAuditoria> RemitosAuditorias { get; set; }
    }
}
