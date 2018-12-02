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
    public partial class FrmDataVendedores : Form
    {
        public Vendedor Vendedor { get; set; }
        private FacturacionBDEntities2 entities = new FacturacionBDEntities2();

        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Porciento { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }
        DataTable dt = new DataTable();

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
                dt = new DataTable();
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

        private void dgvVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvVendedores.SelectedRows[0];
                FrmVendedor frm = new FrmVendedor();
                frm.ID = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.Porciento = row.Cells[2].Value.ToString();
                frm.Estado = row.Cells[3].Value.ToString();
                frm.Modo = "U";
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar registro" + ex.Message);
            }
        }

        private void FrmDataVendedores_Activated(object sender, EventArgs e)
        {
            ejecutarConsultaVendedores();
        }

        //Busqueda Flexible

        private void consultarPorCriterio()
        {
            var Vendedor = from em in entities.Vendedor
                          where (em.ID_Vendedor.ToString().StartsWith(textBusqueda.Text) ||
                          em.Nombre.StartsWith(textBusqueda.Text) ||
                          em.Porciento_Comision.ToString().StartsWith(textBusqueda.Text) ||
                          em.Estado.StartsWith(textBusqueda.Text)
                          )
                          select em;
            dgvVendedores.DataSource = Vendedor.ToList();
        }


        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        //Exportación Csv

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            writeFileHeader("ID, Nombre, Porciento Comisión, Estado");

            foreach (DataRow row in dt.Rows)
            {
                string linea = "";
                foreach (DataColumn dc in dt.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                writeFileLine(linea);
            }

            Process.Start(@"C:\Users\Arianna Linette Díaz\Desktop\Vendedor.csv");
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(@"C:\Users\Arianna Linette Díaz\Desktop\Vendedor.csv"))
            {
                w.WriteLine(pLine);
            }
        }
        private void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText(@"C:\Users\Arianna Linette Díaz\Desktop\Cliente.csv"))
            {
                w.WriteLine(pLine);
            }

        }

    }
}
