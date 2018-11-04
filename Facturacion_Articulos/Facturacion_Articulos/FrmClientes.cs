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
    public partial class FrmClientes : Form
    {
        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre_Comercial { get; set; }
        public string Cedula { get; set; }
        public string Cuenta_Contable { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }


        public FrmClientes()
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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            
        }


        //Boton de Eliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {


                string sql = $"delete Cliente where id_cliente = '{TextID.Text}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro eliminado con exito");
                this.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Error al eliminar" + exe.Message);
               
            }
            
        }

        //Recuerda modificar el SQL string
        //Boton de GUardar
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TextNombreComercial.Text))
                {
                    MessageBox.Show("Campos Vacios");
                }
                else
                {

                    if (!validarCedula(TextCedula.Text))
                    {
                        MessageBox.Show("Cedula no valida");
                    }
                    else
                    {

                        string sql = "";
                        if (Modo.Equals("C"))
                        {
                            sql = $"insert into Cliente values ('{TextNombreComercial.Text}', '{TextCedula.Text}', '{cbxCuentaContable.Text}', '{Estadocbx.Text}')";
                        }
                        else
                        {
                            sql = $"update Cliente set Nombre_Comercial='{TextNombreComercial.Text}', " +
                                $"Cedula = '{TextCedula.Text}', Cuenta_Contable = '{cbxCuentaContable.Text}', Estado = '{Estadocbx.Text}' " +
                                $"where ID_Cliente = '{TextID.Text}'";

                        }
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado con exito");
                        this.Close();

                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        //Boton de Cerrar
        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            this.Close();
        }

        public static bool validarCedula(String Cedula)
        {
            if (long.Parse(Cedula) <= 0)
                return false;

            int vnTotal = 0;
            string vcCedula = Cedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }
            if (vnTotal % 10 == 0)
                return true;
            else
                return false;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextID_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCLientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void FrmClientes_Load_1(object sender, EventArgs e)
        {
            try
            {
                TextID.Text = ID;
                TextNombreComercial.Text = Nombre_Comercial;
                TextCedula.Text = Cedula;
                
                if (Cuenta_Contable == null)
                {
                    cbxCuentaContable.SelectedIndex = 0;
                }
                else
                {
                    cbxCuentaContable.SelectedItem = Cuenta_Contable;
                }
                if (Estado == null)
                {
                    Estadocbx.SelectedIndex = 0;

                }
                else
                {

                    Estadocbx.SelectedItem = Estado;
                }

                TextID.Enabled = Modo.Equals("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        private void TextCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextNombreComercial_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TextCedula_KeyPress(object sender, KeyPressEventArgs e)
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
