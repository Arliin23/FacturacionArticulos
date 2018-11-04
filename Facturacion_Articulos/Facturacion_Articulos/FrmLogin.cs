using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                string claveEncriptadaMD5 = getMD5Hash(txtClave.Text);
                Usuario usuario = (from u in db.Usuario
                                   where u.Nombre_Usuario.Equals(txtUsuario.Text) &&
         u.Clave.Equals(claveEncriptadaMD5)
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
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {

                        FrmPrincipal frm = new FrmPrincipal();
                        frm.ShowDialog();
                        this.Close();

                    }

                }
            }


            catch (Exception EXE)
            {
                MessageBox.Show("Error:  " + EXE);
                
            }
           

          

            }

        //Metodo para encriptar Clave

        public string getMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }


        //Validaciones

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }

            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsPunctuation(e.KeyChar))
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

