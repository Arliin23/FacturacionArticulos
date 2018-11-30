using Facturacion_Articulos.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Articulos
{
    public partial class FrmFacturacion : Form
    {
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmFacturacion frm = new FrmFacturacion();
            this.Close();
        }

        private void cmdAgregarArticulo_Click(object sender, EventArgs e)
        {

           FrmArticuloFactura frm = new FrmArticuloFactura();
            frm.Show();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'facturacionBDDataSet1.Articulo_Facturable' table. You can move, or remove it, as needed.
            this.articulo_FacturableTableAdapter.Fill(this.facturacionBDDataSet1.Articulo_Facturable);

        }

        private void cbxCantidadDisponible_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
        }
    }
}
