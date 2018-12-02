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
    public partial class FrmDataArticulos : Form
    {
        public Articulo_Facturable Articulo { get; set; }
        private FacturacionBDEntities2 entities = new FacturacionBDEntities2();

        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre { get; set; }
        public int CostoUnitario { get; set; }
        public int PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }
        DataTable dt = new DataTable();

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
                dt = new DataTable();
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
        
        //Boton Agregar

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

        //Doble Click en las celdas

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dgvArticulos.SelectedRows[0];
                FrmArticulos frm = new FrmArticulos();
                frm.ID = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.CostoUnitario = row.Cells[2].Value.ToString();
                frm.PrecioUnitario = row.Cells[3].Value.ToString();
                frm.Cantidad = row.Cells[4].Value.ToString();
                frm.Estado = row.Cells[5].Value.ToString();
                frm.Modo = "U";
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar Registro" + ex.Message);
            }
        }

        private void FrmDataArticulos_Activated(object sender, EventArgs e)
        {
            ejecutarConsultaArticulos();
        }

        //Consultas Flexibles

        private void consultarPorCriterio()
        {
            var articulo = from em in entities.Articulo_Facturable
                            where (em.ID_Articulo.ToString().StartsWith(textBusqueda.Text) ||
                            em.Nombre_Articulo.StartsWith(textBusqueda.Text) ||
                            em.Costo_Unitario.ToString().StartsWith(textBusqueda.Text) ||
                            em.Precio_Unitario.ToString().StartsWith(textBusqueda.Text) ||
                            em.Cantidad.ToString().StartsWith(textBusqueda.Text) ||
                            em.Estado.StartsWith(textBusqueda.Text)
                            )
                            select em;
            dgvArticulos.DataSource = articulo.ToList();
        }



        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        //Exportacion csv

        private void cmdExcel_Click(object sender, EventArgs e)
        {
            writeFileHeader("ID, Nombre, Costo, Precio, Cantidad, Estado");

            foreach (DataRow row in dt.Rows)
            {
                string linea = "";
                foreach (DataColumn dc in dt.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                writeFileLine(linea);
            }

            Process.Start(@"C:\Users\Arianna Linette Díaz\Desktop\Articulo.csv");
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(@"C:\Users\Arianna Linette Díaz\Desktop\Articulo.csv"))
            {
                w.WriteLine(pLine);
            }
        }
        private void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText(@"C:\Users\Arianna Linette Díaz\Desktop\Articulo.csv"))
            {
                w.WriteLine(pLine);
            }

        }

    }
}
