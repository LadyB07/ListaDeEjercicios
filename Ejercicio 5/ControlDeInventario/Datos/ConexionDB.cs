using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeInventario.Datos
{
    public class ConexionDB
    {
        private string cadena = "Data Source = PC164\\SQLEXPRESS ; Initial Catalog = ControlDeInventario ; Integrated Security = True ; TrustServerCertificate = True";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
