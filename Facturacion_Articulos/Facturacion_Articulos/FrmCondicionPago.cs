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
    public partial class FrmCondicionPago : Form
    {

        private SqlConnection con;
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public int CantidadDias { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }

        public FrmCondicionPago()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-9GEI88L;Initial Catalog=FacturacionBD;Integrated Security=True");
                con.Open();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCondicionPago_Load(object sender, EventArgs e)
        {
            try
            {
                TextID.Text = ID;
                rtxtDescripcion.Text = Descripcion;
                nUDCantidadDias.Value = CantidadDias;
                cbxEstado.Text = Estado;
                TextID.Enabled = Modo.Equals("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar valores" + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextID_TextChanged(object sender, EventArgs e)
        {

        }
        //Boton de Guardar
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                string sql = "";
                if (Modo.Equals("C"))
                {
                    sql = $"insert into condicion_pago values ('{rtxtDescripcion.Text}', { nUDCantidadDias.Value}, '{cbxEstado.Text}')";
                }
                else
                {
                    sql = $"update Condicion_Pago set Descripcion='{rtxtDescripcion.Text}', " +
                        $"Cantidad_dias = '{nUDCantidadDias.Value}', estado = '{cbxEstado.Text}' " +
                        $"where id_condicion = {TextID.Text}";
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
        //Boton de Eliminar
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Condicion_Pago ";
                sql += " where ID_Condicion = '" + TextID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro eliminado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                throw;
            }
        }
        //Boton de Cerrar
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            FrmCondicionPago frm = new FrmCondicionPago();
            this.Close();
        }

        private void FrmCondicionPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void FrmCondicionPago_Load_1(object sender, EventArgs e)
        {

        }
    }
}
