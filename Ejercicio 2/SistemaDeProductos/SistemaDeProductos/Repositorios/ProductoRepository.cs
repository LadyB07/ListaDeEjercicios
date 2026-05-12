using Microsoft.Data.SqlClient;
using SistemaDeProductos.Datos;
using SistemaDeProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeProductos.Repositorios
{
    public class ProductoRepository : IProductoRepositorio
    {
        private readonly ConexionDB _conexion = new ConexionDB();

        public void Insertar(Producto producto)
        {
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Productos (Nombre, Precio, Stock) VALUES (@nombre, @precio, @stock)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Producto producto)
        {
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = "UPDATE Productos SET Nombre=@nombre, Precio=@precio, Stock=@stock WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", producto.Id);
                cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var con = _conexion.ObtenerConexion())
            {
                string query = "DELETE FROM Productos WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    throw new Exception("No se encontró el registro en la base de datos.");
                }
            }
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Productos";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Producto
                        {
                            Id = (int)reader["Id"],
                            Nombre = reader["Nombre"].ToString(),
                            Precio = (decimal)reader["Precio"],
                            Stock = (int)reader["Stock"]
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
    }
}
