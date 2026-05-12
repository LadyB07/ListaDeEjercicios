using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion.Modelo;
using Facturacion.Repositorio.Interfaces;
using Microsoft.Data.SqlClient;

namespace Facturacion.Repositorio
{
    internal class CDetalleFacturaRepositorio : IDetalleFacturaRepositorio<CDetalleFactura>
    {
        private readonly string? _Conexion;

        public CDetalleFacturaRepositorio(string conecion)
        {
            _Conexion = conecion;
        }

        public void Actualizar(CDetalleFactura objeto, int id)
        {
            string consulta = $"update DetalleFactura set Producto = @Producto,Cantidad = @Cantidad,Precio = @Precio where Id = @Id";
            using (SqlConnection conection = new SqlConnection(_Conexion))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conection))
                {
                    comando.Parameters.AddWithValue("@Producto", objeto.Producto);
                    comando.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                    comando.Parameters.AddWithValue("@Precio", objeto.Precio);
                    comando.Parameters.AddWithValue("@Id", objeto.Id);


                    try
                    {
                        conection.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error en la base de datos" + ex.Message);
                    }
                }
            };
        }

        public void Eliminar(int id)
        {
            string consulta = $"delete from DetalleFactura where Id = @Id";
            using (SqlConnection conexion = new SqlConnection(_Conexion))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("error en la base de datos " + ex.Message);
                    }
                }
            }
        }

        public void insertar(CDetalleFactura objeto)
        {
            using (SqlConnection conection = new SqlConnection(_Conexion))
            {
                conection.Open();
                SqlTransaction transaccion = conection.BeginTransaction();
                try
                {
                    string consulta = $"insert into DetalleFactura(FacturaId,Producto,Cantidad,Precio) values (@FacturaId,@Producto,@Cantidad,@Precio)";
                    using (SqlCommand comando = new SqlCommand(consulta, conection, transaccion))
                    {
                        comando.Parameters.AddWithValue("@FacturaId", objeto.IdFactura);
                        comando.Parameters.AddWithValue("@Producto", objeto.Producto);
                        comando.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                        comando.Parameters.AddWithValue("@Precio", objeto.Precio);
                        comando.ExecuteNonQuery();
                        transaccion.Commit();
                    }
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("error en la base de datos" + ex.Message);
                }
            }
        }

        public List<CDetalleFactura> ObtenerDetalleFactura()
        {
            string consulta = $"SELECT d.Id,d.FacturaId,f.Cliente,f.Fecha,d.Producto,d.Cantidad,d.Precio" +
            $" FROM DetalleFactura d INNER JOIN Facturas f  ON d.FacturaId = f.Id";
            List<CDetalleFactura> detalles = new List<CDetalleFactura>();
            try
            {
                using (SqlConnection conection = new SqlConnection(_Conexion))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, conection))
                    {
                        conection.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                detalles.Add(new CDetalleFactura()
                                {
                                    Id = reader.GetInt32(0),
                                   IdFactura = reader.GetInt32(1),
                                    Cliente = reader.GetString(2),
                                    Fecha = reader.GetDateTime(3),
                                    Producto = reader.GetString(4),
                                    Cantidad = reader.GetInt32(5),
                                    Precio = (double)reader.GetDecimal(6)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos " + ex.Message);
            }
            return detalles;
        }
    }
}
