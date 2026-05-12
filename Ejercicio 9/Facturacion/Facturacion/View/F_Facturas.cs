using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion.Modelo;
using Facturacion.Repositorio;

namespace Facturacion.View
{
    public partial class F_Facturas : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connecion"].ConnectionString;
        public F_Facturas()
        {
            InitializeComponent();
            Cargar();
        }

        public void Cargar()
        {
            try
            {
                CFacturaRepositorio repositorio = new CFacturaRepositorio(connectionString);
                Tabla_Factura.DataSource = repositorio.ObtenerFactura();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("error al cargar los datos " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "Agregar")
                {
                    string Error = "";
                    if (string.IsNullOrEmpty(textCliente.Text)) { Error += "el campo cliente es obligatorio\n"; }
                    if (string.IsNullOrEmpty(Error))
                    {
                        CFactura factura = new CFactura
                        {
                            Cliente = textCliente.Text,
                            Fecha = dptFecha.Value
                        };
                        CFacturaRepositorio repositorio = new CFacturaRepositorio(connectionString);
                        repositorio.insertar(factura);
                        Cargar();
                    }
                    else { MessageBox.Show(Error); }

                }
                else if (button1.Text == "Actualizar")
                {
                    int id = int.Parse(Tabla_Factura.CurrentRow.Cells[0].Value.ToString());

                    CFactura factura = new CFactura
                    {
                        Cliente = textCliente.Text,
                        Fecha = dptFecha.Value
                    };

                    try
                    {
                        CFacturaRepositorio repositorio = new CFacturaRepositorio(connectionString);
                        repositorio.Actualizar(factura, id);
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Tabla_Factura.CurrentRow.Cells[0].Value.ToString());
            DialogResult resultado = MessageBox.Show("estas seguro de eliminar el " + $"paciente {id}", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    CFacturaRepositorio repositorio = new CFacturaRepositorio(connectionString);
                    repositorio.Eliminar(id);
                    Cargar();

                    if (id > 0)
                    {
                        MessageBox.Show("cliente eliminado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("error al eliminar el cliente");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("seleccione un cliente para eliminar");
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textCliente.Text = Tabla_Factura.CurrentRow.Cells[1].Value.ToString();
            button1.Text = "Actualizar";
        }

        private void F_Facturas_Load(object sender, EventArgs e)
        {
            Tabla_Factura.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;

            Tabla_Factura.AllowUserToAddRows = false;

            Tabla_Factura.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            Tabla_Factura.ReadOnly = true;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textCliente.Text = string.Empty;
        }
    }
}
