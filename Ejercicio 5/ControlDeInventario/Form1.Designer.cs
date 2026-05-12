namespace ControlDeInventario
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
            txtId = new TextBox();
            label9 = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            txtPrecioCompra = new TextBox();
            txtCantidad = new TextBox();
            txtCategoria = new TextBox();
            txtProducto = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            dgvInventario = new DataGridView();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            btnFiltrar = new Button();
            btnCalcular = new Button();
            btnBuscar = new Button();
            label8 = new Label();
            txtBuscar = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 0;
            label1.Text = "Control De Inventario";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnInsertar);
            groupBox1.Controls.Add(txtPrecioCompra);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(txtProducto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 300);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Nuevo Producto";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 25);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 15;
            label9.Text = "Id:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(147, 261);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(113, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(24, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(147, 219);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(113, 23);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(24, 219);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(113, 23);
            btnInsertar.TabIndex = 11;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(107, 176);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(100, 23);
            txtPrecioCompra.TabIndex = 10;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(107, 136);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 9;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(107, 97);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 8;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(107, 59);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio Compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 100);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 5;
            label3.Text = "Categoría:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 139);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Cantidad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvInventario);
            groupBox2.Location = new Point(324, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(581, 360);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado General de Inventario";
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(6, 22);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(566, 332);
            dgvInventario.TabIndex = 17;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnFiltrar);
            groupBox3.Controls.Add(btnCalcular);
            groupBox3.Location = new Point(12, 339);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(294, 91);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Consultas y Métricas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(155, 15);
            label6.TabIndex = 15;
            label6.Text = "Consultar el stock más bajo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 63);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 16;
            label7.Text = "Calcular el valor total:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(177, 19);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(99, 23);
            btnFiltrar.TabIndex = 15;
            btnFiltrar.Text = "Filtrar Stock";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(177, 63);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 23);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(821, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(330, 45);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 5;
            label8.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(390, 41);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(415, 23);
            txtBuscar.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 437);
            Controls.Add(txtBuscar);
            Controls.Add(label8);
            Controls.Add(btnBuscar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnInsertar;
        private TextBox txtPrecioCompra;
        private TextBox txtCantidad;
        private TextBox txtCategoria;
        private TextBox txtProducto;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox3;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvInventario;
        private Label label6;
        private Label label7;
        private Button btnFiltrar;
        private Button btnCalcular;
        private Button btnBuscar;
        private Label label8;
        private TextBox txtBuscar;
        private TextBox txtId;
        private Label label9;
    }
}
