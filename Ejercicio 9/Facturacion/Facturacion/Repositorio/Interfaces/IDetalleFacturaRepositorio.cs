using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Repositorio.Interfaces
{
    internal interface IDetalleFacturaRepositorio<T>
    {
        List<T> ObtenerDetalleFactura();
        void insertar(T objeto);
        void Actualizar(T objeto, int id);
        void Eliminar(int id);
    }
}
