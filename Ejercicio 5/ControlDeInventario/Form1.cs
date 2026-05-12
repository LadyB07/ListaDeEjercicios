using ControlDeInventario.Entidades;
using ControlDeInventario.Repositorio;

namespace ControlDeInventario
{
    public partial class Form1 : Form
    {
        private readonly IInventarioRepositorio _repo = new InventarioRepository();
        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = _repo.ObtenerTodos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var prod = new Producto
                {
                    Nombre = txtProducto.Text,
                    Categoria = txtCategoria.Text,
                    Cantidad = int.Parse(txtCantidad.Text),
                    PrecioCompra = decimal.Parse(txtPrecioCompra.Text)
                };

                _repo.Insertar(prod);
                MessageBox.Show("¡Producto registrado con éxito! ✨");
                LimpiarCampos();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.CurrentRow != null)
                {
                    var prod = new Producto
                    {
                        Id = int.Parse(dgvInventario.CurrentRow.Cells["Id"].Value.ToString()),
                        Nombre = txtProducto.Text,
                        Categoria = txtCategoria.Text,
                        Cantidad = int.Parse(txtCantidad.Text),
                        PrecioCompra = decimal.Parse(txtPrecioCompra.Text)
                    };

                    _repo.Actualizar(prod);
                    MessageBox.Show("Registro actualizado correctamente.");
                    CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventario.CurrentRow != null)
                {
                    int id = int.Parse(dgvInventario.CurrentRow.Cells["Id"].Value.ToString());
                    _repo.Eliminar(id);
                    CargarDatos();
                    MessageBox.Show("Producto eliminado.");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text;
            dgvInventario.DataSource = _repo.BuscarPorNombre(filtro);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var stockBajo = _repo.ObtenerStockBajo(5);
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = stockBajo;
            MessageBox.Show($"Se encontraron {stockBajo.Count} productos con stock crítico.");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal total = _repo.CalcularValorTotal();
            MessageBox.Show($"El valor total de toda la mercadería es: {total:C2}", "Métrica de Inventario");
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtProducto.Clear();
            txtCategoria.Clear();
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            txtProducto.Focus();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];
                txtProducto.Text = fila.Cells["Nombre"].Value.ToString();
                txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
                txtCantidad.Text = fila.Cells["Cantidad"].Value.ToString();
                txtPrecioCompra.Text = fila.Cells["PrecioCompra"].Value.ToString();
            }
        }
    }
}
