using Facturacion.Modelo;
using Facturacion.Repositorio.Interfaces;
using Microsoft.Data.SqlClient;

namespace Facturacion.Repositorio
{
    internal class CFacturaRepositorio : IFacturaRepositorio<CFactura>
    {
        private readonly string? _Conexion;

        public CFacturaRepositorio(string? conecion)
        {
            _Conexion = conecion;
        }


        public void Actualizar(CFactura objeto, int id)
        {
            string consulta = $"update Facturas set Cliente = @Cliente,Fecha =@Fecha where Id = @Id";
            using (SqlConnection conection = new SqlConnection(_Conexion))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conection))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.Parameters.AddWithValue("@Cliente", objeto.Cliente);
                    comando.Parameters.AddWithValue("@Fecha", objeto.Fecha);
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
            }
        }

        public void Eliminar(int id)
        {
            string consulta = $"delete from Facturas where Id = @Id";
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

        public void insertar(CFactura objeto)
        {

            using (SqlConnection conection = new SqlConnection(_Conexion))
            {
                conection.Open();
                SqlTransaction transaccion = conection.BeginTransaction();
                try
                {
                    string consulta = $"insert into Facturas(Cliente,Fecha) values(@Cliente,@Fecha)";
                    using (SqlCommand comando = new SqlCommand(consulta, conection, transaccion))
                    {
                        comando.Parameters.AddWithValue("@Cliente", objeto.Cliente);
                        comando.Parameters.AddWithValue("@Fecha", objeto.Fecha);
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


        public List<CFactura> ObtenerFactura()
        {
            string consulta = "select Id,Cliente,Fecha from Facturas";
            List<CFactura> facturas = new List<CFactura>();
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
                                facturas.Add(new CFactura()
                                {
                                    Id = reader.GetInt32(0),
                                    Cliente = reader.GetString(1),
                                    Fecha = reader.GetDateTime(2)
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
            return facturas;
        }
    }
}
