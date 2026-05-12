using ControlDeInventario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeInventario.Repositorio
{
    public interface IInventarioRepositorio
    {
        void Insertar(Producto producto);
        void Actualizar(Producto producto);
        void Eliminar(int id);
        List<Producto> BuscarPorNombre(string nombre);
        List<Producto> ObtenerTodos();
        List<Producto> ObtenerStockBajo(int limite);
        decimal CalcularValorTotal();
    }
}
