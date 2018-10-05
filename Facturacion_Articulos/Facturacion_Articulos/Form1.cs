using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Facturacion_Articulos
{
    public partial class frmMenuPrincipal : Form
    {
        SqlConnection con = null;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        //Recuerda modificar el SQL string
        private void ejecutarConsulta()
        {
            try
            {
                con = new SqlConnection("Data Source=(modificar);Integrated Security=True");
                con.Open();
                string sql = "select * from Cliente";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultados.DataSource = dt;
                dgvResultados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvResultados.SelectedRows[0];
                FrmClientes frm = new FrmClientes();
                frm.ID = row.Cells[0].Value.ToString();
                frm.Nombre_Comercial = row.Cells[1].Value.ToString();
                frm.Cedula = row.Cells[2].Value.ToString();
                frm.Cuenta_Contable = row.Cells[3].Value.ToString();
                frm.Estado = row.Cells[4].Value.ToString();
                frm.con = con;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar registro: " + ex.Message);
            }
        }



        private void cmdEditar_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            this.Close();
        }

        private void alToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ejecutarConsulta();
        }
    }
}
