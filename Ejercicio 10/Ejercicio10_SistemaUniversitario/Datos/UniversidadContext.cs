using System.Data.Entity;
using Ejercicio10_SistemaUniversitario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_SistemaUniversitario.Datos
{
    public class UniversidadContext : DbContext
    {
        public UniversidadContext() : base(@"Data Source=DESKTOP-ECGCOAJ; Initial Catalog=SistemaUniversitario; Integrated Security=True; TrustServerCertificate=True") { }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
