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
            this.Close();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FrmDataClientescs frm = new FrmDataClientescs();    
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            FrmDataCondicionPago frm = new FrmDataCondicionPago();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            FrmDataArticulos frm = new FrmDataArticulos();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            FrmDataVendedores frm = new FrmDataVendedores();
            frm.Show();
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {    
            FrmDataUsuario frm = new FrmDataUsuario();
            frm.Show();
        }
    }
}
