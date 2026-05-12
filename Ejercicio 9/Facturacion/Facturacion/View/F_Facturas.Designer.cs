namespace Facturacion.View
{
    partial class F_Facturas
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
            buttonLimpiar = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            dptFecha = new DateTimePicker();
            textCliente = new TextBox();
            label1 = new Label();
            Tabla_Factura = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla_Factura).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(buttonLimpiar);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(dptFecha);
            splitContainer1.Panel1.Controls.Add(textCliente);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Tabla_Factura);
            splitContainer1.Size = new Size(779, 324);
            splitContainer1.SplitterDistance = 305;
            splitContainer1.TabIndex = 0;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLimpiar.Location = new Point(165, 265);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(125, 47);
            buttonLimpiar.TabIndex = 6;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 265);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 9);
            label3.Name = "label3";
            label3.Size = new Size(97, 32);
            label3.TabIndex = 4;
            label3.Text = "Factura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 159);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 3;
            label2.Text = "Fecha:";
            // 
            // dptFecha
            // 
            dptFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dptFecha.Format = DateTimePickerFormat.Short;
            dptFecha.Location = new Point(12, 187);
            dptFecha.Name = "dptFecha";
            dptFecha.Size = new Size(200, 33);
            dptFecha.TabIndex = 2;
            // 
            // textCliente
            // 
            textCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCliente.Location = new Point(12, 98);
            textCliente.Name = "textCliente";
            textCliente.Size = new Size(278, 33);
            textCliente.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Cliente:";
            // 
            // Tabla_Factura
            // 
            Tabla_Factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabla_Factura.ContextMenuStrip = contextMenuStrip1;
            Tabla_Factura.Dock = DockStyle.Fill;
            Tabla_Factura.Location = new Point(0, 0);
            Tabla_Factura.Name = "Tabla_Factura";
            Tabla_Factura.Size = new Size(470, 324);
            Tabla_Factura.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, editarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(133, 52);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(132, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(132, 24);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // F_Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 324);
            Controls.Add(splitContainer1);
            Name = "F_Facturas";
            Text = "F_Facturas";
            Load += F_Facturas_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabla_Factura).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label3;
        private Label label2;
        private DateTimePicker dptFecha;
        private TextBox textCliente;
        private DataGridView Tabla_Factura;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private Button buttonLimpiar;
    }
}