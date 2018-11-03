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
    //20170122 Arianna Linette Diaz
    //20170173 Estefania Peralta
    //20170370 Erick Pimentel

    public partial class frmMenuPrincipal : Form
    {

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }


        private void cmdEditar_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            this.Close();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMantenimiento frm = new FrmMantenimiento();
            frm.Show();
        }
    }
}
