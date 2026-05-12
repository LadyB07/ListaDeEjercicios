using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeProductos.Datos
{
    public class ConexionDB
    {
        private string cadena = "Data Source = PC208 ; Initial Catalog = SistemaProductos ; Integrated Security = True ; TrustServerCertificate = True";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
