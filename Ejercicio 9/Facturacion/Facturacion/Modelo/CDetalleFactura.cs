using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Modelo
{
    internal class CDetalleFactura
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public string? Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string? Cliente {  get; set; }
        public DateTime Fecha { get; set; }

    }
}
