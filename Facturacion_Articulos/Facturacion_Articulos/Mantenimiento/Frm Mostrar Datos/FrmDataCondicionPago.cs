using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Articulos
{
    public partial class FrmDataCondicionPago : Form
    {
        public Condicion_Pago  Condicion { get; set; }
        private FacturacionBDEntities2 entities = new FacturacionBDEntities2();

        private SqlConnection con;
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public string CantidadDias { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }
        DataTable dt = new DataTable();


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
                dt = new DataTable();
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

        private void dgvCondicionP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvCondicionP.SelectedRows[0];
                FrmCondicionPago frm = new FrmCondicionPago();
                frm.ID = row.Cells[0].Value.ToString();
                frm.Descripcion = row.Cells[1].Value.ToString();
                frm.CantidadDias = row.Cells[2].Value.ToString();
                frm.Estado = row.Cells[3].Value.ToString();
                frm.Modo = "U";
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar registro" + ex.Message);
            }
        }

        private void FrmDataCondicionPago_Activated(object sender, EventArgs e)
        {
            ejecutarConsultaCondicionPago();
        }

        //Consultas Flexibles

        private void consultarPorCriterio()
        {
            var articulo = from em in entities.Condicion_Pago
                           where (em.ID_Condicion.ToString().StartsWith(textBusqueda.Text) ||
                           em.Descripcion.StartsWith(textBusqueda.Text) ||
                           em.Cantidad_dias.ToString().StartsWith(textBusqueda.Text) ||
                           em.Estado.StartsWith(textBusqueda.Text)
                           )
                           select em;
            dgvCondicionP.DataSource = articulo.ToList();
        }



        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            writeFileHeader("ID, Descripción, Cédula, Cantidad días, Estado");

            foreach (DataRow row in dt.Rows)
            {
                string linea = "";
                foreach (DataColumn dc in dt.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                writeFileLine(linea);
            }

            Process.Start(@"C:\Users\Arianna Linette Díaz\Desktop\CondicionPago.csv");
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(@"C:\Users\Arianna Linette Díaz\Desktop\CondicionPago.csv"))
            {
                w.WriteLine(pLine);
            }
        }
        private void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText(@"C:\Users\Arianna Linette Díaz\Desktop\CondicionPago.csv"))
            {
                w.WriteLine(pLine);
            }

        }

    }
}
