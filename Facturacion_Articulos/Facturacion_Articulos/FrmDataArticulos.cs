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
    public partial class FrmDataArticulos : Form
    {

        public SqlConnection con;
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public int CostoUnitario { get; set; }
        public int PrecioUnitario { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }

        public FrmDataArticulos()
        {
            InitializeComponent();

        }


        private void ejecutarConsultaArticulos()
        {

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-9GEI88L;Initial Catalog=FacturacionBD;Integrated Security=True");
                con.Open();
                string sql = "select * from Articulo_Facturable";
                SqlDataAdapter da = new SqlDataAdapter(sql,con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvArticulos.DataSource = dt;
                dgvArticulos.Refresh();



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
            FrmArticulos frm = new FrmArticulos();
            frm.Modo = "C";
            frm.ShowDialog();
        }

        private void FrmDataArticulos_Load(object sender, EventArgs e)
        {
            ejecutarConsultaArticulos();
        }

        private void FrmDataArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
