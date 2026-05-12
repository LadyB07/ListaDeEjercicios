using SistemaMedico.Entidades;
using SistemaMedico.Repositorio;

namespace SistemaMedico
{
    public partial class Form1 : Form
    {
        private readonly IPacienteRepositorio _repo = new PacienteRepository();
        public Form1()
        {
            InitializeComponent();
            RefrescarGrid();
        }
        private void RefrescarGrid()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = _repo.ObtenerTodos();
            ActualizarTotalConsultas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                var p = new Paciente
                {
                    Nombre = txtNombre.Text,
                    Edad = int.Parse(txtEdad.Text),
                    Diagnostico = txtDiagnostico.Text
                };
                _repo.Insertar(p);
                RefrescarGrid();
                LimpiarInterfaz();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.CurrentRow == null) return;
                var p = new Paciente
                {
                    Id = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Id"].Value),
                    Nombre = txtNombre.Text,
                    Edad = int.Parse(txtEdad.Text),
                    Diagnostico = txtDiagnostico.Text
                };
                _repo.Actualizar(p);
                RefrescarGrid();
                LimpiarInterfaz();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Id"].Value);
            _repo.Eliminar(id);
            RefrescarGrid();
            LimpiarInterfaz();
        }

        private void ActualizarTotalConsultas()
        {
            txtConsulta.Text = dgvPacientes.Rows.Count.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = _repo.BuscarPorNombre(txtBuscar.Text);
            ActualizarTotalConsultas();
        }

        private void btnMayores60_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = _repo.ObtenerMayores60();
            ActualizarTotalConsultas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _repo.LimpiarDatos();
            LimpiarInterfaz();
        }

        private void LimpiarInterfaz()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtDiagnostico.Clear();
            txtNombre.Focus();
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvPacientes.Rows[e.RowIndex];
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtEdad.Text = fila.Cells["Edad"].Value.ToString();
            txtDiagnostico.Text = fila.Cells["Diagnostico"].Value.ToString();
        }
    }
}
