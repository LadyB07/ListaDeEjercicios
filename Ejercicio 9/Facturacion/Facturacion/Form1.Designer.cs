namespace Facturacion
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            facturacionToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            detalleFacturaToolStripMenuItem = new ToolStripMenuItem();
            escritorio = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, facturacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // facturacionToolStripMenuItem
            // 
            facturacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem, detalleFacturaToolStripMenuItem });
            facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            facturacionToolStripMenuItem.Size = new Size(121, 29);
            facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(204, 30);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // detalleFacturaToolStripMenuItem
            // 
            detalleFacturaToolStripMenuItem.Name = "detalleFacturaToolStripMenuItem";
            detalleFacturaToolStripMenuItem.Size = new Size(204, 30);
            detalleFacturaToolStripMenuItem.Text = "DetalleFactura";
            detalleFacturaToolStripMenuItem.Click += detalleFacturaToolStripMenuItem_Click;
            // 
            // escritorio
            // 
            escritorio.BackColor = SystemColors.ActiveCaption;
            escritorio.Dock = DockStyle.Fill;
            escritorio.Location = new Point(0, 33);
            escritorio.Name = "escritorio";
            escritorio.Size = new Size(800, 417);
            escritorio.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(escritorio);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem facturacionToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem detalleFacturaToolStripMenuItem;
        private Panel escritorio;
    }
}
