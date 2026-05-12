using Ejercicio4_Empleados.Datos;
using Ejercicio4_Empleados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Empleados.Repositorios
{
    public class EmpleadoRepositorio
    {
        public void Agregar(Empleado nuevo) => BaseDeDatos.ListaEmpleados.Add(nuevo);

        public void Eliminar(Empleado emp) => BaseDeDatos.ListaEmpleados.Remove(emp);

        public List<Empleado> ObtenerTodos() => BaseDeDatos.ListaEmpleados;

        public double CalcularTotal() => BaseDeDatos.ListaEmpleados.Sum(e => e.Salario);

        public Empleado? ObtenerElMasPagado() => BaseDeDatos.ListaEmpleados.OrderByDescending(e => e.Salario).FirstOrDefault();
    }
}

