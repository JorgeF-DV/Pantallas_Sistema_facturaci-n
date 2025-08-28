using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // Evento para el botón VALIDAR (asumiendo que se llama button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // Datos de prueba
            string usuarioCorrecto = "admin";
            string passwordCorrecto = "1234";

            // Verificamos si el texto de los TextBox coincide
            if (txtUsuario.Text == usuarioCorrecto && txtPassword.Text == passwordCorrecto)
            {
                // Si son correctos, abrimos el formulario principal
                frmPrincipal formularioPrincipal = new frmPrincipal();
                formularioPrincipal.Show();

                // Y ocultamos el formulario de login actual
                this.Hide();
            }
            else
            {
                // Si son incorrectos, mostramos un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpiamos la contraseña y ponemos el cursor en el usuario
                txtPassword.Clear();
                txtUsuario.Focus();
            }
        }

        // Evento para el botón CANCELAR (asumiendo que se llama button2)
        private void button2_Click(object sender, EventArgs e)
        {
            // Cierra toda la aplicación
            Application.Exit();
        }
    }
}