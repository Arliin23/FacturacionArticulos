using Facturacion_Articulos.Facturacion;
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
using System.Diagnostics;
using System.IO;


namespace Facturacion_Articulos
{
    public partial class FrmFacturacion : Form
    {

 
        public SqlConnection con;
        private int preTotal = 0;
        private int total = 0;

        public FrmFacturacion()
        {
            InitializeComponent();
            this.dgvArticulosFactura.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAgregarArticulo_Click(object sender, EventArgs e)
        {

            //string value = cbxCantidadDisponible.Text.ToString();
            //MessageBox.Show("Valor : " + value);

            if (Int32.Parse(cbxCantidadDisponible.Text.ToString()) < NuDCantidad.Value)
            {

                MessageBox.Show("Cantidad no disponible");

            } else if (NuDCantidad.Value == 0) {

                MessageBox.Show("La cantidad a comprar no puede ser menor o igual a cero");

            } else

                dgvArticulosFactura.Rows.Add(cbxID.Text, cbxArticulo.Text, cbxPrecio.Text, NuDCantidad.Value);

            preTotal = Int32.Parse(cbxPrecio.Text) * Convert.ToInt32(Math.Round(NuDCantidad.Value, 0));
            total = preTotal + total;

            txtTotal.Text = Convert.ToString(total);


        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'facturacionBDDataSet2.Articulo_Facturable' table. You can move, or remove it, as needed.
            this.articulo_FacturableTableAdapter1.Fill(this.facturacionBDDataSet2.Articulo_Facturable);
           
        }

        private void cbxCantidadDisponible_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvArticulosFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            this.dgvArticulosFactura.Rows.Clear();
            txtTotal.Clear();
            total = 0;
        }

        private void cmdFinVenta_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-9GEI88L;Initial Catalog=FacturacionBD;Integrated Security=True");
            con.Open();
            string sql = "select * from Articulo_Facturable";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dataT = new DataTable();
            da.Fill(dataT);

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgvArticulosFactura.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgvArticulosFactura.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }






            foreach (DataGridViewRow row in dgvArticulosFactura.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    try
                    {
                        string idProducto = row.Cells[0].Value.ToString();
                        //Cantidad del DGV
                        string cantidadProducto = row.Cells[3].Value.ToString();
                        //Cantidad atendiendo a el id en la BD
                        String queryCantidad = "SELECT Cantidad from dbo.Articulo_Facturable WHERE ID_Articulo = " + idProducto;
                        SqlCommand command = new SqlCommand(queryCantidad, con);

                        int cantidad = Int32.Parse(command.ExecuteScalar().ToString());

                        //MessageBox.Show("La cantidad es: " + cantidad);

                        int CantidadFinal = cantidad - Int32.Parse(cantidadProducto);

                        //MessageBox.Show("Cantidad Final: " + CantidadFinal);

                        String queryCantidadFinal = "UPDATE Articulo_Facturable set Cantidad = " + CantidadFinal + " WHERE ID_Articulo = " + idProducto;
                        SqlCommand command1 = new SqlCommand(queryCantidadFinal, con);
                        command1.ExecuteNonQuery();



                    }
                    catch (Exception EF)
                    {

                        MessageBox.Show("Error:  " + EF);

                    }

                }

            }

            MessageBox.Show("Facturación realizada con exito");


            writeFileHeader("ID, Articulo, Precio, Cantidad");

            foreach (DataRow row in dt.Rows)
            {
                string linea = "";
                foreach (DataColumn dc in dt.Columns)
                {
                    linea += row[dc].ToString() + ",";
                }
                writeFileLine(linea);
            }
            String totalS = Convert.ToString(total);
            writeFileLine("Total, " + totalS);

            Process.Start(@"C:\Users\Arianna Linette Díaz\Desktop\Factura.csv");


            this.Hide();
            FrmFacturacion frm = new FrmFacturacion();
            frm.ShowDialog();


        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(@"C:\Users\Arianna Linette Díaz\Desktop\Factura.csv"))
            {
                w.WriteLine(pLine);
            }
        }
        private void writeFileHeader(string pLine)
        {
            using (System.IO.StreamWriter w = File.CreateText(@"C:\Users\Arianna Linette Díaz\Desktop\Factura.csv"))
            {
                w.WriteLine(pLine);
            }

        }
    }
    }

