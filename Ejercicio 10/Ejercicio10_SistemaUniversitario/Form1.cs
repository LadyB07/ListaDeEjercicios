using Ejercicio10_SistemaUniversitario.Entidades;
using Ejercicio10_SistemaUniversitario.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10_SistemaUniversitario
{
    public partial class Form1 : Form
    {
        EstudianteRepo repo = new EstudianteRepo();

        public Form1()
        {
            InitializeComponent();
            CargarConfiguracionInicial();
        }

        private void CargarConfiguracionInicial()
        {
            ActualizarCombo();
        }


        private void btnRegCarrera_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCarrera.Text)) return;

            var nuevaCarrera = new Carrera
            {
                NombreCarrera = txtNombreCarrera.Text
            };

            repo.GuardarCarrera(nuevaCarrera);
            MessageBox.Show("Carrera registrada correctamente.");

            txtNombreCarrera.Clear();
            ActualizarCombo(); 
        }


        private void btnRegEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoEstudiante = new Estudiante
                {
                    Nombre = txtNomEst.Text,
                    Edad = int.Parse(txtEdadEst.Text),
                    CarreraId = (int)cmbCarreras.SelectedValue 
                };

                repo.GuardarEstudiante(nuevoEstudiante);
                MessageBox.Show("Estudiante registrado con éxito.");

                LimpiarCamposEstudiante();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = repo.ObtenerTodo();
        }


        private void ActualizarCombo()
        {
            cmbCarreras.DataSource = repo.ObtenerCarreras();
            cmbCarreras.DisplayMember = "NombreCarrera"; 
            cmbCarreras.ValueMember = "Id"; 
        }

        private void LimpiarCamposEstudiante()
        {
            txtNomEst.Clear();
            txtEdadEst.Clear();
        }
    }
}
