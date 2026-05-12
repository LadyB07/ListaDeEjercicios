using Microsoft.Data.SqlClient;
using SistemaDEventa7.Entidades;
using SistemaDEventa7.sqlConexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDEventa7.Repository
{
    public  class VentaRepository
    {


        Conexion con = new Conexion();

   
        public void Guardar(Venta v)
        {
            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Ventas (Cliente, Producto, Cantidad, Precio) VALUES (@Cliente,@Producto,@Cantidad,@Precio)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cliente", v.Cliente);
                cmd.Parameters.AddWithValue("@Producto", v.Producto);
                cmd.Parameters.AddWithValue("@Cantidad", v.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", v.Precio);

                cmd.ExecuteNonQuery();
            }
        }

    
        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();

            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Ventas", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Venta
                    {
                        Id = (int)dr["Id"],
                        Cliente = dr["Cliente"].ToString(),
                        Producto = dr["Producto"].ToString(),
                        Cantidad = (int)dr["Cantidad"],
                        Precio = (decimal)dr["Precio"]
                    });
                }
            }
            return lista;
        }

       
        public void Eliminar(int id)
        {
            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Ventas WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

     
        public decimal TotalGeneral()
        {
            using (var conn = con.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(Cantidad * Precio) FROM Ventas", conn);

                object result = cmd.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

     
        public string ProductoMasVendido()
        {
            using (var conn = con.ObtenerConexion())
            {
                conn.Open();

                string query = @"
                SELECT TOP 1 Producto
                FROM Ventas
                GROUP BY Producto
                ORDER BY SUM(Cantidad) DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteScalar()?.ToString();
            }
        }














    }
}
