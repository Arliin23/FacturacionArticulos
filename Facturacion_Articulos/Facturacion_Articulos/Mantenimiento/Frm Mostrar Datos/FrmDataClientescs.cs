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
    public partial class FrmDataClientescs : Form
    {
        public Cliente Clientes { get; set; }
        private FacturacionBDEntities2 entities = new FacturacionBDEntities2();

        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }
        DataTable dt = new DataTable();

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
                dt = new DataTable();
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
            try
            {
                DataGridViewRow row = this.dgvCliente.SelectedRows[0];
                FrmClientes frm = new FrmClientes();
                frm.Modo = "U";
                frm.ID = row.Cells[0].Value.ToString();
                frm.Nombre_Comercial = row.Cells[1].Value.ToString();
                frm.Cedula = row.Cells[2].Value.ToString();
                frm.Cuenta_Contable = row.Cells[3].Value.ToString();
                frm.Estado = row.Cells[4].Value.ToString();
                frm.ShowDialog();
            }
            catch (Exception exec)
            {

                MessageBox.Show("Error al editar registro" + exec.Message);
            }

           
        }

        private void FrmDataClientescs_Activated(object sender, EventArgs e)
        {
            ejecutarConsultaCliente();
        }


        //Consultas Flexibles

        private void consultarPorCriterio()
        {
            var articulo = from em in entities.Cliente
                           where (em.ID_Cliente.ToString().StartsWith(textBusqueda.Text) ||
                           em.Nombre_Comercial.StartsWith(textBusqueda.Text) ||
                           em.Cedula.ToString().StartsWith(textBusqueda.Text) ||
                           em.Cuenta_Contable.StartsWith(textBusqueda.Text) ||
                           em.Estado.StartsWith(textBusqueda.Text)
                           )
                           select em;
            dgvCliente.DataSource = articulo.ToList();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        //Exportacion Csv

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            writeFileHeader("ID, Nombre, Cédula, Cuenta, Estado");

            foreach (DataRow row in dt.Rows)
            {
                string linea = "";
                foreach (DataColumn dc in dt.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                writeFileLine(linea);
            }

            Process.Start(@"C:\Users\Arianna Linette Díaz\Desktop\Cliente.csv");
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(@"C:\Users\Arianna Linette Díaz\Desktop\Cliente.csv"))
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
