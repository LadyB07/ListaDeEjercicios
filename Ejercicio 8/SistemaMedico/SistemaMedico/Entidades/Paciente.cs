using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Diagnostico { get; set; }
    }
}
