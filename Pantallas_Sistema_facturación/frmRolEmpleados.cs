using Capa_LogicaDeNegocios;
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
    public partial class frmRolEmpleados : Form
    {

        private Cls_Empleados logicaEmpleados = new Cls_Empleados();
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        private void frmRolEmpleados_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void CargarRoles()
        {
            // Llama al método de la capa de lógica para obtener los datos
            cmbRoles.DataSource = logicaEmpleados.ConsultarRoles();

            // Le decimos qué columna mostrar al usuario
            cmbRoles.DisplayMember = "IdRolEmpleado";

            // Le decimos qué columna usar como valor interno (el ID)
            cmbRoles.ValueMember = "IdRolEmpleado";
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que haya un item seleccionado para evitar errores
            if (cmbRoles.SelectedItem != null)
            {
                // Obtenemos la fila de datos completa del item seleccionado
                DataRowView drv = cmbRoles.SelectedItem as DataRowView;

                // Extraemos únicamente la descripción de esa fila
                string descripcion = drv["StrDescripcion"].ToString();

               
                txtDescripcion.Text = descripcion;

                
            }
        }
}
}
