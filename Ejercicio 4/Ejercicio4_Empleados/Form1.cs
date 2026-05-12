using Ejercicio4_Empleados.Entidades;
using Ejercicio4_Empleados.Repositorios;

namespace Ejercicio4_Empleados
{
    public partial class Form1 : Form
    {
        EmpleadoRepositorio repo = new EmpleadoRepositorio();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Cargo = txtCargo.Text,
                Salario = double.Parse(txtSalario.Text)
            };
            repo.Agregar(emp);
            ActualizarTabla();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total: C$ " + repo.CalcularTotal());
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            var mayor = repo.ObtenerElMasPagado();
            if (mayor != null) MessageBox.Show("El mejor pagado es: " + mayor.Nombre);
        }

        void ActualizarTabla()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = repo.ObtenerTodos();
        }

       
    }
}
