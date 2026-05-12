using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaDEventa7.sqlConexion
{
    public class Conexion
    {

        private string cadena = "Server=localhost\\SQLEXPRESS01;Database=SistemaVentas;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }


    }
}
