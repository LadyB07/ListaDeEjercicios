using SistemaMedico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Repositorio
{
    public interface IPacienteRepositorio
    {
        void Insertar(Paciente paciente);
        void Actualizar(Paciente paciente);
        void Eliminar(int id);
        List<Paciente> ObtenerTodos();
        List<Paciente> BuscarPorNombre(string nombre);
        List<Paciente> ObtenerMayores60();
        void LimpiarDatos();
    }
}
