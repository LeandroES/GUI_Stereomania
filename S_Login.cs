using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stereomania_ERP
{
    public partial class S_Login : Form
    {
        public S_Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "COM231" && txtPassword.Text == "admin123")
            {

                GUI_Dashboard_Admin DA = new GUI_Dashboard_Admin();
                S_Login SL = new S_Login();
                DA.Show();
                this.Visible = false;
                //System.Windows.Forms.MessageBox.Show("Usuario, Bienvenido a Balance");

            }
            else if (txtUsuario.Text == "admin" && txtPassword.Text == "admin123")
            {

                GUI_Dashboard_Usuario DU = new GUI_Dashboard_Usuario();
                S_Login SL = new S_Login();
                DU.Show();
                this.Visible = false;
                //System.Windows.Forms.MessageBox.Show("Usuario, Bienvenido a Balance");

            }
            else
            {

                System.Windows.Forms.MessageBox.Show("Usuario y/o contraseña incorrectos, Intente de nuevo e ingrese datos validos ");

            }
        }
    }
}
