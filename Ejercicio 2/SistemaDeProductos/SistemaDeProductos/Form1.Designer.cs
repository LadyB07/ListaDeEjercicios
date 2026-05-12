namespace SistemaDeProductos
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
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            txtStock = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            lblId = new Label();
            groupBox2 = new GroupBox();
            dgvProductos = new DataGridView();
            txtBuscar = new TextBox();
            label5 = new Label();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 26);
            label1.TabIndex = 3;
            label1.Text = "Sistemas de productos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnInsertar);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblId);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 230);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevo Producto";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(210, 166);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(83, 195);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(106, 166);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(6, 166);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(72, 124);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 25);
            txtStock.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 124);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 6;
            label4.Text = "Stock:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(72, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 25);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 62);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(72, 93);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 25);
            txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // txtId
            // 
            txtId.Location = new Point(72, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 25);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(6, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 17);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvProductos);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(326, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 320);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de productos";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(21, 24);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(420, 283);
            dgvProductos.TabIndex = 12;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(409, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(282, 25);
            txtBuscar.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(343, 17);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 10;
            label5.Text = "Buscar:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(697, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 370);
            Controls.Add(btnBuscar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtPrecio;
        private Label label2;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtStock;
        private Label label4;
        private Button btnLimpiar;
        private Button btnActualizar;
        private Button btnInsertar;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private DataGridView dgvProductos;
        private TextBox txtBuscar;
        private Label label5;
        private Button btnEliminar;
    }
}
