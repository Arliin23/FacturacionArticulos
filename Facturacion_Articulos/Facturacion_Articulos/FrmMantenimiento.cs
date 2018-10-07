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
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            FrmMantenimiento frm = new FrmMantenimiento();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDataClientescs frm = new FrmDataClientescs();    
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDataCondicionPago frm = new FrmDataCondicionPago();
            
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDataArticulos frm = new FrmDataArticulos();
           
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDataVendedores frm = new FrmDataVendedores();
            frm.ShowDialog();
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
