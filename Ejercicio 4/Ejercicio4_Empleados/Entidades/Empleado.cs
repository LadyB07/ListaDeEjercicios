using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Empleados.Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
        public double Salario { get; set; }
    }
}
