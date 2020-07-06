using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_net_2.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingreso();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void Ingreso()
        {
            string user = "CajeroAdm";
            string pass = "HnmX2020!";
            
            
            if (txtUsuario.Text == user && txtContrasena.Text == pass)
            {
                MessageBox.Show("Bienvenido");
                Vista.Menu mainMenu = new Vista.Menu();
                mainMenu.Show();
                this.Hide();
            }
            else if (txtUsuario.Text != user || txtContrasena.Text != pass)
            { 
                MessageBox.Show("Error ingrese sus datos nuevamente");             
            }
            
        }
            private void Limpiar()
            {
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
            }
        }
    } 
