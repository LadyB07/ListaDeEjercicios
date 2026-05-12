using Ejercicio10_SistemaUniversitario.Datos;
using Ejercicio10_SistemaUniversitario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_SistemaUniversitario.Repositorios
{
    public class EstudianteRepo
    {
        private UniversidadContext _db = new UniversidadContext();

        public void GuardarEstudiante(Estudiante est)
        {
            _db.Estudiantes.Add(est);
            _db.SaveChanges();
        }

        public void GuardarCarrera(Carrera car)
        {
            _db.Carreras.Add(car);
            _db.SaveChanges();
        }

        public object ObtenerTodo()
        {
            return _db.Estudiantes.Select(e => new {
                e.Id,
                e.Nombre,
                e.Edad,
                Carrera = e.Carrera.NombreCarrera
            }).ToList();
        }

        public List<Carrera> ObtenerCarreras() => _db.Carreras.ToList();
    }
}
