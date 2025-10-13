using Capa_LogicaDeNegocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmClientes : Form
    {
        // Esta propiedad pública recibe el ID desde frmListaClientes
        public int IdCliente { get; set; }
        private Cls_Clientes cliente = new Cls_Clientes();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            if (IdCliente > 0)
            {
                // Modo Edición: Cargamos los datos del cliente existente
                this.Text = "Editar Cliente";
                cargar_datos_cliente();
            }
            else
            {
                // Modo Nuevo: El formulario está listo para un nuevo ingreso
                this.Text = "Nuevo Cliente";
            }
        }

        private void cargar_datos_cliente()
        {
            DataTable dt = cliente.ConsultarClientePorId(IdCliente);

            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                txtNombre.Text = fila["StrNombre"].ToString();
                txtDocumento.Text = fila["NumDocumento"].ToString();
                txtDireccion.Text = fila["StrDireccion"].ToString();
                txtTelefono.Text = fila["StrTelefono"].ToString();
                txtEmail.Text = fila["StrEmail"].ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Pasamos los datos de los controles a la capa de lógica
            cliente.C_IdCliente = IdCliente;
            cliente.C_StrNombre = txtNombre.Text;
            cliente.C_NumDocumento = long.Parse(txtDocumento.Text);
            cliente.C_StrDireccion = txtDireccion.Text;
            cliente.C_StrTelefono = txtTelefono.Text;
            cliente.C_StrEmail = txtEmail.Text;

            // Llamamos al método para guardar y mostramos el resultado
            string mensaje = cliente.GuardarCliente();
            MessageBox.Show(mensaje);

            this.Close(); // Cerramos el formulario de edición
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}