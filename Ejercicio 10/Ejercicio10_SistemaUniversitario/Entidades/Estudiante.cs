using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_SistemaUniversitario.Entidades
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int CarreraId { get; set; }
        public virtual Carrera Carrera { get; set; }
    }
}