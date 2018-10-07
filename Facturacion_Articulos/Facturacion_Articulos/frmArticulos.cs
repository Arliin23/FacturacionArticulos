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
    public partial class frmArticulos : Form
    {
        public SqlConnection con;
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public int CostoUnitario { get; set; }
        public int PrecioUnitario{ get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }

        public frmArticulos()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-9GEI88L;Initial Catalog=FacturacionBD;Integrated Security=True");
                con.Open();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            try
            {
                TextID.Text = ID;
                rtxtDescripcion.Text = Descripcion;
                nUDCostoUnitario.Value = CostoUnitario;
                nUDPrecioUnitario.Value = PrecioUnitario;
                cbxEstado.Text = Estado;
                TextID.Enabled = Modo.Equals("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        //Boton Guardar
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (Modo.Equals("C"))
                {
                    sql = $"insert into Articulo_Facturable values ('{rtxtDescripcion.Text}', {nUDCostoUnitario.Value}, { nUDPrecioUnitario.Value} ,'{cbxEstado.Text}')";
                }
                else
                {
                    sql = $"update Articulo_Facturable set Descripcion ='{rtxtDescripcion.Text}', " +
                        $"Costo_Unitario = {nUDCostoUnitario.Value}, Precio_Unitario = {nUDPrecioUnitario.Value}, estado = '{cbxEstado.Text}' " +
                        $"where id_articulo = '{TextID.Text}'";
                }

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado con exito");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }

        //Boton Eliminar
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Articulo_Facturable ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro eliminado con exito");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar");
                throw;
            }
        }

        //Boton Cerrar
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            frmArticulos frm = new frmArticulos();
            this.Close();
        }

        private void frmArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
