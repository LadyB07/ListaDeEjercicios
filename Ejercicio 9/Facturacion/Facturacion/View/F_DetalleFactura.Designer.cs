namespace Facturacion.View
{
    partial class F_DetalleFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            labelCliente = new Label();
            comboCliente = new ComboBox();
            button1 = new Button();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            txtNombreProdcuto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Tabla_Detalle = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla_Detalle).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(labelCliente);
            splitContainer1.Panel1.Controls.Add(comboCliente);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(txtPrecio);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtCantidad);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtNombreProdcuto);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Tabla_Detalle);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 286;
            splitContainer1.TabIndex = 0;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCliente.Location = new Point(12, 314);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(83, 25);
            labelCliente.TabIndex = 9;
            labelCliente.Text = "Clientes:";
            // 
            // comboCliente
            // 
            comboCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(12, 342);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(190, 33);
            comboCliente.TabIndex = 8;
            comboCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 396);
            button1.Name = "button1";
            button1.Size = new Size(105, 42);
            button1.TabIndex = 7;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(12, 271);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(153, 33);
            txtPrecio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 243);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(12, 183);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(123, 33);
            txtCantidad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 3;
            label3.Text = "Cantidad:";
            // 
            // txtNombreProdcuto
            // 
            txtNombreProdcuto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProdcuto.Location = new Point(12, 97);
            txtNombreProdcuto.Name = "txtNombreProdcuto";
            txtNombreProdcuto.Size = new Size(253, 33);
            txtNombreProdcuto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Producto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 30);
            label1.TabIndex = 0;
            label1.Text = "Detalle de la Factura";
            // 
            // Tabla_Detalle
            // 
            Tabla_Detalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla_Detalle.ContextMenuStrip = contextMenuStrip1;
            Tabla_Detalle.Dock = DockStyle.Fill;
            Tabla_Detalle.Location = new Point(0, 0);
            Tabla_Detalle.Name = "Tabla_Detalle";
            Tabla_Detalle.Size = new Size(510, 450);
            Tabla_Detalle.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, modificarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 52);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(142, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(142, 24);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(160, 396);
            button2.Name = "button2";
            button2.Size = new Size(105, 42);
            button2.TabIndex = 10;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // F_DetalleFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "F_DetalleFactura";
            Text = "F_DetalleFactura";
            Load += F_DetalleFactura_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabla_Detalle).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtCantidad;
        private Label label3;
        private TextBox txtNombreProdcuto;
        private Label label2;
        private DataGridView Tabla_Detalle;
        private Button button1;
        private ComboBox comboCliente;
        private Label labelCliente;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private Button button2;
    }
}