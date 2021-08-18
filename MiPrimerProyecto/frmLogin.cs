using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    public partial class frmLogin : Form
    {
        string user = "admin";
        string pass = "1234";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Logeo de usuario!!!";
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                this.txtUsuario.Focus();
                return;
               
            }
            if (this.txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña");
                this.txtContraseña.Focus();
                return;
            }
       
            if (this.txtUsuario.Text == this.user && this.txtContraseña.Text == this.pass)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Error al Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtContraseña.Text = "";
                this.txtUsuario.Focus();
            }
            if (this.txtUsuario.Text != this.user)
            {
                MessageBox.Show("Usuario no existente", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtContraseña.Text = "";
                this.txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
