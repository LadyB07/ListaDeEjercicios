using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Datos
{
    public class ConexionDB
    {
        private string cadena = "Data Source = JOSEPHANDRADEZ\\SQL2022 ; Initial Catalog = SistemaMedico ; Integrated Security = True ; TrustServerCertificate = True";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
