namespace Ejercicio4_Empleados
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtCargo = new TextBox();
            txtSalario = new TextBox();
            dgvEmpleados = new DataGridView();
            btnAgregar = new Button();
            btnTotal = new Button();
            btnMayor = new Button();
            gbDatos = new GroupBox();
            gbLista = new GroupBox();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            gbDatos.SuspendLayout();
            gbLista.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 18);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 1;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 163);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 2;
            label3.Text = "Cargo :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 220);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 3;
            label4.Text = "Salario :";
            // 
            // txtId
            // 
            txtId.Location = new Point(117, 46);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.Size = new Size(329, 25);
            txtId.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 99);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(329, 25);
            txtNombre.TabIndex = 5;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(117, 159);
            txtCargo.Margin = new Padding(4);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(329, 25);
            txtCargo.TabIndex = 6;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(117, 210);
            txtSalario.Margin = new Padding(4);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(329, 25);
            txtSalario.TabIndex = 7;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = SystemColors.ActiveCaption;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(22, 27);
            dgvEmpleados.Margin = new Padding(4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(459, 315);
            dgvEmpleados.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 311);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 49);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(260, 311);
            btnTotal.Margin = new Padding(4);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(113, 49);
            btnTotal.TabIndex = 10;
            btnTotal.Text = "Total Salarios";
            btnTotal.UseVisualStyleBackColor = true;
            // 
            // btnMayor
            // 
            btnMayor.Location = new Point(138, 311);
            btnMayor.Margin = new Padding(4);
            btnMayor.Name = "btnMayor";
            btnMayor.Size = new Size(114, 49);
            btnMayor.TabIndex = 11;
            btnMayor.Text = "Salario Más Alto";
            btnMayor.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(txtId);
            gbDatos.Controls.Add(label1);
            gbDatos.Controls.Add(label2);
            gbDatos.Controls.Add(label3);
            gbDatos.Controls.Add(label4);
            gbDatos.Controls.Add(txtSalario);
            gbDatos.Controls.Add(txtNombre);
            gbDatos.Controls.Add(txtCargo);
            gbDatos.Location = new Point(15, 14);
            gbDatos.Margin = new Padding(4);
            gbDatos.Name = "gbDatos";
            gbDatos.Padding = new Padding(4);
            gbDatos.Size = new Size(496, 264);
            gbDatos.TabIndex = 12;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos del Empleado";
            // 
            // gbLista
            // 
            gbLista.Controls.Add(dgvEmpleados);
            gbLista.Location = new Point(519, 19);
            gbLista.Margin = new Padding(4);
            gbLista.Name = "gbLista";
            gbLista.Padding = new Padding(4);
            gbLista.Size = new Size(505, 364);
            gbLista.TabIndex = 13;
            gbLista.TabStop = false;
            gbLista.Text = "Lista de Registros";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(381, 311);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 49);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar Seleccionado";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 427);
            Controls.Add(btnEliminar);
            Controls.Add(gbLista);
            Controls.Add(gbDatos);
            Controls.Add(btnMayor);
            Controls.Add(btnTotal);
            Controls.Add(btnAgregar);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sistema De Empleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtCargo;
        private TextBox txtSalario;
        private DataGridView dgvEmpleados;
        private Button btnAgregar;
        private Button btnTotal;
        private Button btnMayor;
        private GroupBox gbDatos;
        private GroupBox gbLista;
        private Button btnEliminar;
    }
}
