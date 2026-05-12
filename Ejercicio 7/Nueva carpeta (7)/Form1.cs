using SistemaDEventa7.Entidades;
using SistemaDEventa7.Repository;

namespace SistemaDEventa7
{
    public partial class Form1 : Form
    {

        VentaRepository repo = new VentaRepository();

        private void CargarDatos()
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = repo.Listar();
        }




        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Venta v = new Venta
            {
                Cliente = txtCliente.Text,
                Producto = txtProducto.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                Precio = decimal.Parse(txtPrecio.Text)
            };

            repo.Guardar(v);
            CargarDatos();





        }

        private void btnTotalVenta_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese cantidad y precio");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Cantidad inválida");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Precio inválido");
                return;
            }

            decimal total = cantidad * precio;

            MessageBox.Show("Total venta: " + total);
        }

        private void btnTotalGeneral_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Total general: " + repo.TotalGeneral());
        }

        private void btnProductoMasVendido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Más vendido: " + repo.ProductoMasVendido());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            repo.Eliminar(id);
            CargarDatos();




        }
    }
}
