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
    public partial class FrmDataVendedores : Form
    {
        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre { get; set; }
        public int Porciento { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }

        public FrmDataVendedores()
        {
            InitializeComponent();
        }

        private void ejecutarConsultaVendedores()
        {

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-9GEI88L;Initial Catalog=FacturacionBD;Integrated Security=True");
                con.Open();
                string sql = "select * from Vendedor";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVendedores.DataSource = dt;
                dgvVendedores.Refresh();



            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + Ex.Message);
            }

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            FrmVendedor frm = new FrmVendedor();
            frm.Modo = "C";
            frm.ShowDialog();
        }

        private void FrmDataVendedores_Load(object sender, EventArgs e)
        {
            ejecutarConsultaVendedores();
        }
    }
}
