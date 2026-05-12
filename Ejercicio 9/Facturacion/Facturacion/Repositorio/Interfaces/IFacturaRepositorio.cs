using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Repositorio.Interfaces
{
    internal interface IFacturaRepositorio<T>
    {
        List<T> ObtenerFactura();
        void insertar(T objeto);
        void Actualizar(T objeto, int id);
        void Eliminar(int id);
    }
}
