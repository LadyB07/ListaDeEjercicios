using SistemaDeProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeProductos.Repositorios
{
    public interface IProductoRepositorio
    {
        void Insertar(Producto producto);
        void Actualizar(Producto producto);
        void Eliminar(int Id);
        List<Producto> ObtenerTodos();
        List<Producto> BuscarPorNombre(string nombre);

    }
}
