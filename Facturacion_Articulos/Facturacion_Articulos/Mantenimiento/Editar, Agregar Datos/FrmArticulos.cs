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
        public string Nombre { get; set; }
        public string CostoUnitario { get; set; }
        public string PrecioUnitario { get; set; }
        public string Cantidad { get; set; }
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
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(nUDCostoUnitario.Text) || string.IsNullOrEmpty(nUDPrecioUnitario.Text))
                {
                    MessageBox.Show("Campos Vacios");
                }
                else
                {

                    string sql = "";
                    if (Modo.Equals("C"))
                    {
                        sql = $"insert into Articulo_Facturable values ('{txtNombre.Text}', '{nUDCostoUnitario.Text}', '{nUDPrecioUnitario.Text}', '{nUDCantidad.Text}' ,'{cbxEstado.Text}')";
                    }
                    else
                    {
                        sql = $"update Articulo_Facturable set Nombre_Articulo ='{txtNombre.Text}', " +
                            $"Costo_Unitario = '{nUDCostoUnitario.Text}', Precio_Unitario = '{nUDPrecioUnitario.Text}', Cantidad = '{nUDCantidad.Text}', estado = '{cbxEstado.Text}' " +
                            $"where id_articulo = '{TextID.Text}'";
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
            
            
            try
            {
                TextID.Text = ID;
                txtNombre.Text = Nombre;
                nUDCostoUnitario.Text = CostoUnitario;
                nUDPrecioUnitario.Text = PrecioUnitario;
                nUDCantidad.Text = Cantidad;
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


        private void FrmArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        //Validaciones

        private void nUDCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nUDPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nUDPrecioUnitario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
