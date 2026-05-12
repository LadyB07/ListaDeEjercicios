using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio3_SistemaUniversitario
{
    public partial class Form1 : Form

    {
        SistemaUniversitarioEntities db = new SistemaUniversitarioEntities();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCarrera.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }


            Estudiantes nuevo = new Estudiantes();
            nuevo.Nombre = txtNombre.Text;
            nuevo.Carrera = txtCarrera.Text;
            nuevo.Promedio = decimal.Parse(txtPromedio.Text);

            db.Estudiantes.Add(nuevo);
            db.SaveChanges(); 

            MessageBox.Show("¡Estudiante registrado!");

          
            txtNombre.Clear(); txtCarrera.Clear(); txtPromedio.Clear();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
            var lista = db.Estudiantes
                          .OrderByDescending(est => est.Promedio)
                          .ToList();

            dgvEstudiantes.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string carreraABuscar = txtCarrera.Text;

            
            var filtrados = db.Estudiantes
                              .Where(est => est.Carrera.Contains(carreraABuscar))
                              .ToList();

            dgvEstudiantes.DataSource = filtrados;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow != null)
            {
                int idEliminar = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells["Id"].Value);

                var estudianteABorrar = db.Estudiantes.Find(idEliminar);

                if (estudianteABorrar != null)
                {
                    db.Estudiantes.Remove(estudianteABorrar);
                    db.SaveChanges();

                    MessageBox.Show("Estudiante eliminado correctamente");

                    dgvEstudiantes.DataSource = db.Estudiantes.ToList();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila en la tabla primero.");
            }
        }
    }
}
