using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDEventa7.Entidades
{
    public  class Venta
    {

        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public decimal Total => Cantidad * Precio;









    }
}
