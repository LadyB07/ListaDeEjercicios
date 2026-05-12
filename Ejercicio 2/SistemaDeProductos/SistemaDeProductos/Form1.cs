using SistemaDeProductos.Entidades;
using Microsoft.Data.SqlClient;
using SistemaDeProductos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SistemaDeProductos.Repositorios;

namespace SistemaDeProductos
{
    public partial class Form1 : Form
    {
        private readonly IProductoRepositorio _repo = new ProductoRepository();

        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvProductos.DataSource = _repo.ObtenerTodos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                var prod = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                _repo.Insertar(prod);
                MessageBox.Show("¡Producto guardado!");
                LimpiarCampos();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan datos o son incorrectos: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var prod = new Producto
                {
                    Id = int.Parse(txtId.Text),
                    Nombre = txtNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                _repo.Actualizar(prod);
                MessageBox.Show("¡Producto actualizado!");
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }

            CargarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text;

            // Llamamos al repo y el resultado lo mandamos al DataSource
            var resultado = _repo.BuscarPorNombre(filtro);

            dgvProductos.DataSource = null; // Limpiamos primero
            dgvProductos.DataSource = resultado;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                txtId.Text = fila.Cells["Id"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.CurrentRow != null)
                {
                    int id = int.Parse(dgvProductos.CurrentRow.Cells[0].Value.ToString());

                    _repo.Eliminar(id);

                    CargarDatos();
                    MessageBox.Show("Eliminado de la base de datos.");
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila en la tabla primero.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error técnico: " + ex.Message);
            }
        }
    }
}