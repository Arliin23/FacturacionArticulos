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
    public partial class FrmDataVendedores : Form
    {
        public FrmDataVendedores()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            FrmVendedor frm = new FrmVendedor();
            frm.ShowDialog();
        }

        private void FrmDataVendedores_Load(object sender, EventArgs e)
        {

        }
    }
}
