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
    public partial class frmVendedor : Form
    {
        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre { get; set; }
        public int Porciento { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }


        public frmVendedor()
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
            try
            {
                TextID.Text = ID;
                TextNombre.Text = Nombre;
                nUDPorciento.Value =Porciento;
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
                    sql = $"insert into vendedor values ('{TextNombre.Text}', { nUDPorciento.Value}, '{cbxEstado.Text}')";
                }
                else
                {
                    sql = $"update vendedor set Nombre ='{TextNombre.Text}', " +
                        $"Porciento_Comision = {nUDPorciento.Value}, estado = '{cbxEstado.Text}' " +
                        $"where id_vendedor = '{TextID.Text}'";
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

        //Boton Eliminar
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete vendedor ";
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
            frmVendedor frm = new frmVendedor();
            this.Close();
        }

        private void frmVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
    }
