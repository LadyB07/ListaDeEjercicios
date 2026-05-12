using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Biblioteca
{
    public partial class Form1 : Form
        

    {
        SqlConnection con = new SqlConnection(@"Data Source=PC0131; Initial Catalog=BibliotecaDB; Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "UPDATE Libros SET Disponible = @d WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@d", chkDisponible.Checked ? 1 : 0);

                int filas = cmd.ExecuteNonQuery();
                con.Close();

                if (filas > 0)
                    MessageBox.Show("Disponibilidad actualizada");
                else
                    MessageBox.Show("No se encontró el ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
                con.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                
                string query = "INSERT INTO Libros (Titulo, Autor, AñoPublicacion, Disponible) VALUES (@t, @a, @y, @d)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@t", txtTitulo.Text);
                cmd.Parameters.AddWithValue("@a", txtAutor.Text);
                cmd.Parameters.AddWithValue("@y", txtAño.Text);
                cmd.Parameters.AddWithValue("@d", chkDisponible.Checked ? 1 : 0);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("¡Libro guardado con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Libros WHERE Disponible = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLibros.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar: " + ex.Message);
                con.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Libros WHERE Autor LIKE @autor";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@autor", "%" + txtAutor.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLibros.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
                con.Close();
            }
        }
        private void Limpiar()
        {
            txtID.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAño.Clear();
            chkDisponible.Checked = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkDisponible_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
