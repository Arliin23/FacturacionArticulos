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
    public partial class FrmDataUsuario : Form
    {

        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre_Usuario{ get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }


        public FrmDataUsuario()
        {
            InitializeComponent();
        }

        private void ejecutarConsultaCliente()
        {

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-9GEI88L;Initial Catalog=FacturacionBD;Integrated Security=True");
                con.Open();
                string sql = "select * from Usuario";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
                dgvUsuarios.Refresh();



            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error al ejecutar consulta: " + Ex.Message);
            }

        }

        private void FrmDataUsuario_Load(object sender, EventArgs e)
        {
            ejecutarConsultaCliente();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.Modo = "C";
            frm.ShowDialog();
        }

        private void FrmDataUsuario_Activated(object sender, EventArgs e)
        {
            ejecutarConsultaCliente();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvUsuarios.SelectedRows[0];
                FrmUsuarios frm = new FrmUsuarios();
                frm.Modo = "U";
                frm.ID = row.Cells[0].Value.ToString();
                frm.Nombre_Usuario = row.Cells[1].Value.ToString();
                frm.Clave = row.Cells[2].Value.ToString();
                frm.Estado = row.Cells[3].Value.ToString();
                frm.ShowDialog();
            }
            catch (Exception exec)
            {

                MessageBox.Show("Error al editar registro" + exec.Message);
            }
        }
    }
}
