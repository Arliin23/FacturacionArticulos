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
        public string CantidadDias { get; set; }
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
                if (string.IsNullOrEmpty(rtxtDescripcion.Text) || string.IsNullOrEmpty(nUDCantidadDias.Text))
                {
                    MessageBox.Show("Campos Vacios");
                }
                else
                {

                    string sql = "";
                    if (Modo.Equals("C"))
                    {
                        sql = $"insert into condicion_pago values ('{rtxtDescripcion.Text}', '{nUDCantidadDias.Text}', '{cbxEstado.Text}')";
                    }
                    else
                    {
                        sql = $"update Condicion_Pago set Descripcion='{rtxtDescripcion.Text}', " +
                            $"Cantidad_dias = '{nUDCantidadDias.Text}', estado = '{cbxEstado.Text}' " +
                            $"where id_condicion = '{TextID.Text}'";
                    }

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado con exito");
                    this.Close();


                }
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
                string sql = $"delete Condicion_Pago where id_condicion = '{TextID.Text}'";
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
            try
            {
                TextID.Text = ID;
                rtxtDescripcion.Text = Descripcion;
                nUDCantidadDias.Text = CantidadDias;

                if (Estado == null)
                {
                    cbxEstado.SelectedIndex = 0;

                }
                else
                {

                    cbxEstado.SelectedItem = Estado;
                }
                TextID.Enabled = Modo.Equals("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar valores" + ex.Message);
            }
        }

        //Validaciones

        private void nUDCantidadDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void rtxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
