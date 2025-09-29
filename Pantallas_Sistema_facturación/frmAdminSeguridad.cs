using Capa_LogicaDeNegocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmAdminSeguridad : Form
    {
        private Cls_Seguridad SeguridadEmpleado = new Cls_Seguridad();

        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }

        private void llenar_combo_Empleados()
        {
            cboEmpleado.DataSource = SeguridadEmpleado.ConsultarEmpleados();
            cboEmpleado.DisplayMember = "strNombre";
            cboEmpleado.ValueMember = "IdEmpleado";
            cboEmpleado.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.");
                return;
            }
            int idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
            DataTable dt = SeguridadEmpleado.Consulta_SeguridadEmpleado(idEmpleado);
            if (dt.Rows.Count > 0)
            {
                txtUsuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                txtClave.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("No se le ha asignado usuario y clave a este Empleado");
                txtUsuario.Clear();
                txtClave.Clear();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado.");
                return;
            }
            SeguridadEmpleado.C_IdEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
            SeguridadEmpleado.C_StrUsuario = txtUsuario.Text;
            SeguridadEmpleado.C_StrClave = txtClave.Text;
            SeguridadEmpleado.C_StrUsuarioModifico = "jorge";
            string mensaje = SeguridadEmpleado.ActualizarSeguridadEmpleado();
            MessageBox.Show(mensaje);
        }
    }
}
