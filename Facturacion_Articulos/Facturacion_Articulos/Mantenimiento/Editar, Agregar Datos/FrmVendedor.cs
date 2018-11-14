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
    public partial class FrmVendedor : Form
    {
        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Porciento { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }

        public FrmVendedor()
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

        private void frmVendedor_Load(object sender, EventArgs e)
        {
            
        }


        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            FrmVendedor frm = new FrmVendedor();
            this.Close();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"delete vendedor where id_vendedor = '{TextID.Text}'";
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(TextNombre.Text) || string.IsNullOrEmpty(nUDPorciento.Text))
                {
                    MessageBox.Show("Campos Vacios");
                }
                else
                {

                    string sql = "";
                    if (Modo.Equals("C"))
                    {
                        sql = $"insert into vendedor values ('{TextNombre.Text}', '{ nUDPorciento.Text}', '{cbxEstado.Text}')";
                    }
                    else
                    {
                        sql = $"update vendedor set Nombre ='{TextNombre.Text}', " +
                            $"Porciento_Comision = '{nUDPorciento.Text}', estado = '{cbxEstado.Text}' " +
                            $"where id_vendedor = '{TextID.Text}'";
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

        private void FrmVendedor_Load_1(object sender, EventArgs e)
        {
            try
            {
                TextID.Text = ID;
                TextNombre.Text = Nombre;
                nUDPorciento.Text = Porciento;
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
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        private void FrmVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        //Validaciones

        private void TextNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void nUDPorciento_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
