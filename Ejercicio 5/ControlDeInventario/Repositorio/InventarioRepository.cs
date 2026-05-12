using ControlDeInventario.Datos;
using ControlDeInventario.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeInventario.Repositorio
{
    public class InventarioRepository:IInventarioRepositorio
    {
        private readonly ConexionDB _conexion = new ConexionDB();

        public void Insertar(Producto producto)
        {
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Inventario (Producto, Categoria, Cantidad, PrecioCompra) VALUES (@prod, @cat, @cant, @prec)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@prod", producto.Nombre);
                cmd.Parameters.AddWithValue("@cat", producto.Categoria);
                cmd.Parameters.AddWithValue("@cant", producto.Cantidad);
                cmd.Parameters.AddWithValue("@prec", producto.PrecioCompra);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Producto producto)
        {
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = "UPDATE Inventario SET Producto=@prod, Categoria=@cat, Cantidad=@cant, PrecioCompra=@prec WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", producto.Id);
                cmd.Parameters.AddWithValue("@prod", producto.Nombre);
                cmd.Parameters.AddWithValue("@cat", producto.Categoria);
                cmd.Parameters.AddWithValue("@cant", producto.Cantidad);
                cmd.Parameters.AddWithValue("@prec", producto.PrecioCompra);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var con = _conexion.ObtenerConexion())
            {
                string query = "DELETE FROM Inventario WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                if (cmd.ExecuteNonQuery() == 0)
                    throw new Exception("No se encontró el registro.");
            }
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Inventario";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Producto
                        {
                            Id = (int)reader["Id"],
                            Nombre = reader["Producto"].ToString(),
                            Categoria = reader["Categoria"].ToString(),
                            Cantidad = (int)reader["Cantidad"],
                            PrecioCompra = (decimal)reader["PrecioCompra"]
                        });
                    }
                }
            }
            return lista;
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            return ObtenerTodos()
                   .Where(p => p.Nombre.ToLower().Contains(nombre.ToLower()))
                   .ToList();
        }

        public List<Producto> ObtenerStockBajo(int limite)
        {
            return ObtenerTodos()
                   .Where(p => p.Cantidad < limite)
                   .ToList();
        }

        public decimal CalcularValorTotal()
        {
            return ObtenerTodos()
                   .Sum(p => p.Cantidad * p.PrecioCompra);
        }
    }
}
