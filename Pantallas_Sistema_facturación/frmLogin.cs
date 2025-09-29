using Capa_LogicaDeNegocios; // <-- Referencia a la capa de lógica
using Pantallas_Sistema_facturación;
using System;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtpasword.Text))
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
                return;
            }

            // 1. Crea un objeto de la clase de la capa de lógica
            Validar_usuario obj_validar = new Validar_usuario();

            // 2. Le pasa los datos de los TextBox
            obj_validar.StrUsuario = txtUsuario.Text;
            obj_validar.StrClave = txtpasword.Text;

            // 3. Llama al método que devuelve true o false
            if (obj_validar.ValidarUsuario())
            {
                MessageBox.Show("Datos de verificación Válidos");
                frmPrincipal principal = new frmPrincipal();
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("USUARIO Y CLAVE NO ENCONTRADOS");
                txtUsuario.Clear();
                txtpasword.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}