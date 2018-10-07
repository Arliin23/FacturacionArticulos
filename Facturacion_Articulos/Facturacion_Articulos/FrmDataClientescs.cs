using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Articulos
{
    public partial class FrmDataClientescs : Form
    {
        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre_Comercial { get; set; }
        public string Cedula { get; set; }
        public string Cuenta_Contable { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }


        public FrmDataClientescs()
        {
            InitializeComponent();
        }

        private void ejecutarConsultaCliente()
        {

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-9GEI88L;Initial Catalog=FacturacionBD;Integrated Security=True");
                con.Open();
                string sql = "select * from Cliente";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCliente.DataSource = dt;
                dgvCliente.Refresh();



            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + Ex.Message);
            }

        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Modo = "C";
            frm.ShowDialog();
        }

        private void FrmDataClientescs_Load(object sender, EventArgs e)
        {
            ejecutarConsultaCliente();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvCliente.SelectedRows[0];
            FrmClientes frm = new FrmClientes();
            frm.ID = row.Cells[0].Value.ToString();
            frm.Nombre_Comercial = row.Cells[1].Value.ToString();
            frm.Cedula = row.Cells[2].Value.ToString();
            frm.Cuenta_Contable = row.Cells[3].Value.ToString();
            frm.Estado = row.Cells[4].Value.ToString();
            frm.Modo = "U";
            frm.ShowDialog();
        }
    }
}
