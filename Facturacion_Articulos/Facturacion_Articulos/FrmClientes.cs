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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Registro eliminado con exito");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar");
                throw;
            }
            
        }
    }
}
