namespace SistemaMedico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtDiagnostico = new TextBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            btnMayores60 = new Button();
            label = new Label();
            txtConsulta = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            dgvPacientes = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(393, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro y Consulta de Pacientes";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(txtDiagnostico);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 51);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(496, 367);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Nuevo Paciente";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Font = new Font("Segoe UI", 9.75F);
            txtDiagnostico.Location = new Point(7, 144);
            txtDiagnostico.Margin = new Padding(3, 4, 3, 4);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(469, 116);
            txtDiagnostico.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9.75F);
            btnLimpiar.Location = new Point(372, 269);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 73);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9.75F);
            btnEliminar.Location = new Point(246, 268);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 73);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar Registro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9.75F);
            btnActualizar.Location = new Point(131, 269);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 73);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar Datos";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9.75F);
            btnRegistrar.Location = new Point(17, 269);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 73);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar Paciente";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 9.75F);
            txtEdad.Location = new Point(188, 73);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(275, 29);
            txtEdad.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(188, 31);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 29);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 39);
            label2.Name = "label2";
            label2.Size = new Size(175, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre del paciente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(51, 77);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 3;
            label3.Text = "Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(7, 117);
            label6.Name = "label6";
            label6.Size = new Size(170, 23);
            label6.TabIndex = 5;
            label6.Text = "Diagnóstico Práctico:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMayores60);
            groupBox2.Controls.Add(label);
            groupBox2.Controls.Add(txtConsulta);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(14, 425);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(496, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consultas Rápidas";
            // 
            // btnMayores60
            // 
            btnMayores60.Font = new Font("Segoe UI", 9.75F);
            btnMayores60.Location = new Point(280, 28);
            btnMayores60.Margin = new Padding(3, 4, 3, 4);
            btnMayores60.Name = "btnMayores60";
            btnMayores60.Size = new Size(86, 31);
            btnMayores60.TabIndex = 8;
            btnMayores60.Text = "Consultar";
            btnMayores60.UseVisualStyleBackColor = true;
            btnMayores60.Click += btnMayores60_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9.75F);
            label.Location = new Point(218, 87);
            label.Name = "label";
            label.Size = new Size(148, 23);
            label.TabIndex = 7;
            label.Text = "Total de Registros:";
            // 
            // txtConsulta
            // 
            txtConsulta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsulta.Location = new Point(372, 79);
            txtConsulta.Margin = new Padding(3, 4, 3, 4);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.ReadOnly = true;
            txtConsulta.Size = new Size(84, 30);
            txtConsulta.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(7, 33);
            label5.Name = "label5";
            label5.Size = new Size(240, 23);
            label5.TabIndex = 5;
            label5.Text = "Pacientes Mayores de 60 Años";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtBuscar);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(523, 51);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(667, 69);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F);
            btnBuscar.Location = new Point(575, 23);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F);
            txtBuscar.Location = new Point(70, 23);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(499, 29);
            txtBuscar.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(6, 26);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 4;
            label4.Text = "Buscar:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvPacientes);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(517, 116);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(673, 438);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(7, 22);
            dgvPacientes.Margin = new Padding(3, 4, 3, 4);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(660, 408);
            dgvPacientes.TabIndex = 0;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 567);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label label;
        private TextBox txtConsulta;
        private TextBox txtBuscar;
        private TextBox txtDiagnostico;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private Button btnMayores60;
        private Button btnBuscar;
        private DataGridView dgvPacientes;
    }
}
