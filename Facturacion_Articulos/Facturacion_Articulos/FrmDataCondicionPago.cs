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
    public partial class FrmDataCondicionPago : Form
    {
        private SqlConnection con;
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public int CantidadDias { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }


        public FrmDataCondicionPago()
        {
            InitializeComponent();
        }

        private void ejecutarConsultaCondicionPago()
        {

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-9GEI88L;Initial Catalog=FacturacionBD;Integrated Security=True");
                con.Open();
                string sql = "select * from Condicion_Pago";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCondicionP.DataSource = dt;
                dgvCondicionP.Refresh();



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
            FrmCondicionPago frm = new FrmCondicionPago();
            frm.Modo = "C";
            frm.ShowDialog();
        }

        private void FrmDataCondicionPago_Load(object sender, EventArgs e)
        {
            ejecutarConsultaCondicionPago();
        }
    }
}
