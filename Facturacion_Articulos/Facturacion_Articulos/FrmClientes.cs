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
        public SqlConnection con { get; set; }
        public string ID { get; set; }
        public string Nombre_Comercial { get; set; }
        public string Cedula { get; set; }
        public string Cuenta_Contable { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }


        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                TextID.Text = ID;
                TextNombreComercial.Text = Nombre_Comercial;
                TextCedula.Text = Cedula;
                TextCuenta.Text = Cuenta_Contable;
                TextID.Enabled = Modo.Equals("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }


        //Boton de Eliminar
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Clientes ";
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

        //Recuerda modificar el SQL string
        //Boton de GUardar
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Data Source=(modificar);Integrated Security=True";
                if (Modo.Equals("C"))
                {
                    sql = "insert into Cliente Values ('";
                    sql += TextID.Text + "','" + TextNombreComercial.Text + "','";
                    sql += TextCedula.Text + "','" + TextCuenta.Text + "','" + TextEstado.Text + "')";
                }
                else
                {
                    sql = "update Cliente set ";
                    sql += "Nombre_Comercial = '" + TextNombreComercial.Text + "',";
                    sql += "Cedula = '" + TextCedula.Text + "',";
                    sql += "Cuenta_Contable = '" + TextCuenta.Text + "'";
                    sql += "Estado = '" + TextEstado.Text + "',";
                    sql += " where ID_Cliente = '" + TextID.Text + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado con exito");


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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
