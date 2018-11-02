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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdFactura_Click(object sender, EventArgs e)
        {
            FrmFacturacion frm = new FrmFacturacion();
            frm.ShowDialog();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
