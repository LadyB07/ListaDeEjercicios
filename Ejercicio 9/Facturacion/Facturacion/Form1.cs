using Facturacion.View;

namespace Facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Facturas abrirFormulario = new F_Facturas();
            abrirFormulario.TopLevel = false;
            escritorio.Controls.Add(abrirFormulario);
            abrirFormulario.Show();

        }

        private void detalleFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DetalleFactura abrirFormulario = new F_DetalleFactura();
            abrirFormulario.TopLevel = false;
            escritorio.Controls.Add(abrirFormulario);
            abrirFormulario.Show();
        }
    }
}
