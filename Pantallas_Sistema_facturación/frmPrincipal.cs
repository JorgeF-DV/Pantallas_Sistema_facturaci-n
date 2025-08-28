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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private Form formularioActivo = null;

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Llama a la función para abrir el formulario de Clientes
            AbrirFormularioHijo(new frmClientes());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmFacturas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmAdminSeguridad());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmAyuda());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de login.
            frmLogin formularioLogin = new frmLogin();

            // Muestra el nuevo formulario de login.
            formularioLogin.Show();

            // Cierra este formulario principal actual.
            this.Close();
        }
    }
}
