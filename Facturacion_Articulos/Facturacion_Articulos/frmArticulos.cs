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
    public partial class FrmArticulos : Form
    {
        public SqlConnection con;
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public string CostoUnitario { get; set; }
        public string PrecioUnitario { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }


        public FrmArticulos()
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
            
        }


        //Boton Guardar
        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            try
            { 
                string sql = "";
                if (Modo.Equals("C"))
                {
                    sql = $"insert into Articulo_Facturable values ('{rtxtDescripcion.Text}', '{nUDCostoUnitario.Text}', '{nUDPrecioUnitario.Text}' ,'{cbxEstado.Text}')";
                }
                else
                {
                    sql = $"update Articulo_Facturable set Descripcion ='{rtxtDescripcion.Text}', " +
                        $"Costo_Unitario = '{nUDCostoUnitario.Text}', Precio_Unitario = '{nUDPrecioUnitario.Text}', estado = '{cbxEstado.Text}' " +
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

        //Boton Cerrar
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            FrmArticulos frm = new FrmArticulos();
            this.Close();
        }

        //Boton Eliminar
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"delete Articulo_Facturable where id_articulo = '{TextID.Text}'";
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
        //Este es el form load
        private void FrmArticulos_Load_1(object sender, EventArgs e)
        {
            llenarListaEstados();

            try
            {
                TextID.Text = ID;
                rtxtDescripcion.Text = Descripcion;
                nUDCostoUnitario.Text = CostoUnitario;
                nUDPrecioUnitario.Text = PrecioUnitario;
                cbxEstado.Text = Estado;
                TextID.Enabled = Modo.Equals("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        //Llenar Lista Estados

        private void llenarListaEstados()
        {
            cbxEstado.Items.Add("Disponible");
            cbxEstado.Items.Add("No Disponible");
            cbxEstado.SelectedIndex = 0;
        }

        private void FrmArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
