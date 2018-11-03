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
    public partial class FrmUsuarios : Form
    {
        public SqlConnection con;
        public string ID { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        public string Modo { get; set; }

        public FrmUsuarios()
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

        //Boton Eliminar

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"delete Usuario where Id_usuario = '{TextID.Text}'";
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

        //Boton Guardar

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "";
                if (Modo.Equals("C"))
                {
                    sql = $"insert into Usuario values ('{TextNombreUsuario.Text}', '{TextClave.Text}', '{Estadocbx.Text}')";
                }
                else
                {
                    sql = $"update Usuario set Nombre_Usuario='{TextNombreUsuario.Text}', " +
                        $"Clave = '{TextClave.Text}', Estado = '{Estadocbx.Text}' " +
                        $"where Id_Usuario = '{TextID.Text}'";

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

        private void cmdClose_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            this.Close();
        }

        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                TextID.Text = ID;
                TextNombreUsuario.Text = Nombre_Usuario;
                TextClave.Text = Clave;
                Estadocbx.Text = Estado;
                TextID.Enabled = Modo.Equals("C");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }
    }
    }

