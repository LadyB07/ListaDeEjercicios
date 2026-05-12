using Microsoft.Data.SqlClient;
using SistemaMedico.Datos;
using SistemaMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Repositorio
{
    public class PacienteRepository : IPacienteRepositorio
    {
        private readonly ConexionDB _conexion = new ConexionDB();

        public void Insertar(Paciente paciente)
        {
            using (var conn = _conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Pacientes (Nombre, Edad, Diagnostico) VALUES (@nom, @ed, @diag)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nom", paciente.Nombre);
                cmd.Parameters.AddWithValue("@ed", paciente.Edad);
                cmd.Parameters.AddWithValue("@diag", paciente.Diagnostico);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Paciente paciente)
        {
            using (var conn = _conexion.ObtenerConexion())
            {
                string query = "UPDATE Pacientes SET Nombre=@nom, Edad=@ed, Diagnostico=@diag WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", paciente.Id);
                cmd.Parameters.AddWithValue("@nom", paciente.Nombre);
                cmd.Parameters.AddWithValue("@ed", paciente.Edad);
                cmd.Parameters.AddWithValue("@diag", paciente.Diagnostico);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var conn = _conexion.ObtenerConexion())
            {
                string query = "DELETE FROM Pacientes WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Paciente> ObtenerTodos()
        {
            var lista = new List<Paciente>();
            using (var conn = _conexion.ObtenerConexion())
            {
                string query = "SELECT Id, Nombre, Edad, Diagnostico FROM Pacientes";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Paciente
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["Nombre"].ToString(),
                            Edad = Convert.ToInt32(reader["Edad"]),
                            Diagnostico = reader["Diagnostico"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public List<Paciente> BuscarPorNombre(string nombre)
        {
            return ObtenerTodos()
                .Where(p => p.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public List<Paciente> ObtenerMayores60()
        {
            return ObtenerTodos()
                .Where(p => p.Edad > 60)
                .ToList();
        }

        public void LimpiarDatos() { }
    }
}
