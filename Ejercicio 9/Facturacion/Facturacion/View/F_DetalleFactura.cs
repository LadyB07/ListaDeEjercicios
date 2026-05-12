using System.Configuration;
using Facturacion.Modelo;
using Facturacion.Repositorio;

namespace Facturacion.View
{
    public partial class F_DetalleFactura : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connecion"].ConnectionString;
        public F_DetalleFactura()
        {
            InitializeComponent();
            Cargar();
            cargarClientes();
        }

        public void Cargar()
        {
            try
            {
                CDetalleFacturaRepositorio repositorio = new CDetalleFacturaRepositorio(connectionString);
                Tabla_Detalle.DataSource = repositorio.ObtenerDetalleFactura();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("error al cargar los datos " + ex.Message);
                }
            }
        }

        public void cargarClientes()
        {
            try
            {
                CFacturaRepositorio repositorio =
          new CFacturaRepositorio(
              connectionString);

                List<CFactura> facturas =
                    repositorio.ObtenerFactura();

                foreach (CFactura factura in facturas)
                {
                    comboCliente.Items.Add(
                        factura.Id +
                        " - " +
                        factura.Cliente);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar los clientes " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "Agregar")
                {

                    string Error = "";
                    if (string.IsNullOrEmpty(txtNombreProdcuto.Text)) { Error += "el campo Producto es obligatorio\n"; }
                    if (string.IsNullOrEmpty(txtCantidad.Text)) { Error += "el campo Cantidad es obligatorio\n"; }
                    if (string.IsNullOrEmpty(txtPrecio.Text)) { Error += "el campo Precio es obligatorio\n"; }
                    if (string.IsNullOrEmpty(Error))
                    {
                        string seleccionado = comboCliente.SelectedItem.ToString();
                        int idFactura = int.Parse(seleccionado.Split('-')[0].Trim());
                        CDetalleFactura detalleFactura = new CDetalleFactura
                        {
                            IdFactura = idFactura,
                            Producto = txtNombreProdcuto.Text,
                            Cantidad = int.Parse(txtCantidad.Text),
                            Precio = double.Parse(txtPrecio.Text)
                        };
                        CDetalleFacturaRepositorio repositorio = new CDetalleFacturaRepositorio(connectionString);
                        repositorio.insertar(detalleFactura);
                        Cargar();
                    }
                    else { MessageBox.Show(Error); }

                }
                else if (button1.Text == "Actualizar")
                {
                    int id = int.Parse(Tabla_Detalle.CurrentRow.Cells[0].Value.ToString());

                    CDetalleFactura detalleFactura = new CDetalleFactura
                    {
                        Producto = txtNombreProdcuto.Text,
                        Cantidad = int.Parse(txtCantidad.Text),
                        Precio = double.Parse(txtPrecio.Text)
                    };

                    try
                    {
                        CDetalleFacturaRepositorio repositorio = new CDetalleFacturaRepositorio(connectionString);
                        repositorio.Actualizar(detalleFactura, id);
                        Cargar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error al actualizar los datos" + ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar los datos" + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void F_DetalleFactura_Load(object sender, EventArgs e)
        {
            Tabla_Detalle.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;

            Tabla_Detalle.AllowUserToAddRows = false;

            Tabla_Detalle.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            Tabla_Detalle.ReadOnly = true;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNombreProdcuto.Text = Tabla_Detalle.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = Tabla_Detalle.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = Tabla_Detalle.CurrentRow.Cells[1].Value.ToString();
            button1.Text = "Actualizar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombreProdcuto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            comboCliente.SelectedIndex = -1;
        }
    }
}
