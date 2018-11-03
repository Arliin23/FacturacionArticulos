using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Articulos
{
    public partial class FrmLogin : Form
    {

        EntitiesFacturacionBD db = new EntitiesFacturacionBD();


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario usuario = (from u in db.Usuario
                                   where u.Nombre_Usuario.Equals(txtUsuario.Text) &&
         u.Clave.Equals(txtClave.Text)
                                   select u).FirstOrDefault();

                if (usuario == null)
                {

                    MessageBox.Show("Datos Incorrectos");

                }
                else if (!usuario.Estado.Equals("Activo"))
                {

                    MessageBox.Show("Datos Incorrectos");

                }
                else
                {

                    MessageBox.Show("Bienvenido " + txtUsuario.Text);
                    this.Hide();
                    if (txtUsuario.Text == "Admin")
                    {
                        frmMenuPrincipal frm = new frmMenuPrincipal();
                        frm.Show();

                    }
                    else
                    {

                        FrmPrincipal frm = new FrmPrincipal();
                        frm.Show();

                    }
                }
            }


            catch (Exception EXE)
            {
                MessageBox.Show("Error:  " + EXE);
                
            }
           

          

            }

        }
    }

