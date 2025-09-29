using Capa_LogicaDeNegocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmEmpleados : Form
    {
        // Esta propiedad pública recibe el ID desde el formulario de la lista
        public int IdEmpleado { get; set; }

        // Instancia de la capa de lógica de negocios para empleados
        private Cls_Empleados empleado = new Cls_Empleados();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            // 1. Llenamos el ComboBox con los roles disponibles
            llenar_combo_roles();

            // 2. Verificamos si es un nuevo empleado o una edición
            if (IdEmpleado > 0)
            {
                // Modo Edición: Cargamos los datos del empleado existente
                this.Text = "Editar Empleado";
                cargar_datos_empleado();
            }
            else
            {
                // Modo Nuevo: El formulario está listo para un nuevo ingreso
                this.Text = "Nuevo Empleado";
            }
        }

        private void llenar_combo_roles()
        {
            cboRolEmpleado.DataSource = empleado.ConsultarRol();
            cboRolEmpleado.DisplayMember = "StrDescripcion";
            cboRolEmpleado.ValueMember = "IdRolEmpleado";
        }

        private void cargar_datos_empleado()
        {
            DataTable dt = empleado.Consulta_Empleado_Por_Id(IdEmpleado);

            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                txtNombreEmpleado.Text = fila["strNombre"].ToString();
                txtDocumento.Text = fila["NumDocumento"].ToString();
                txtDireccion.Text = fila["StrDireccion"].ToString();
                txtTelefono.Text = fila["StrTelefono"].ToString();
                txtEmail.Text = fila["StrEmail"].ToString();
                cboRolEmpleado.SelectedValue = Convert.ToInt32(fila["IdRolEmpleado"]);
                dtmIngreso.Value = Convert.ToDateTime(fila["DtmIngreso"]);

                // Maneja el caso de que la fecha de retiro sea nula en la BD
                if (fila["DtmRetiro"] != DBNull.Value)
                {
                    dtmRetiro.Value = Convert.ToDateTime(fila["DtmRetiro"]);
                }

                txtDatosAdicionales.Text = fila["strDatosAdicionales"].ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // 1. Pasamos los datos de los controles a las propiedades del objeto de la capa de lógica
            empleado.C_IdEmpleado = IdEmpleado;
            empleado.C_strNombre = txtNombreEmpleado.Text;
            empleado.C_NumDocumento = double.Parse(txtDocumento.Text);
            empleado.C_StrDireccion = txtDireccion.Text;
            empleado.C_StrTelefono = txtTelefono.Text;
            empleado.C_StrEmail = txtEmail.Text;
            empleado.C_IdRolEmpleado = Convert.ToInt32(cboRolEmpleado.SelectedValue);
            empleado.C_DtmIngreso = dtmIngreso.Value.ToString("yyyy-MM-dd");
            empleado.C_DtmRetiro = dtmRetiro.Value.ToString("yyyy-MM-dd");
            empleado.C_strDatosAdicionales = txtDatosAdicionales.Text;
            empleado.C_StrUsuarioModifico = "jorge"; 

            // 2. Llamamos al método de la capa de lógica para que guarde los cambios
            string mensaje = empleado.ActualizarEmpleado();
            MessageBox.Show(mensaje);

            // 3. Cerramos el formulario
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}