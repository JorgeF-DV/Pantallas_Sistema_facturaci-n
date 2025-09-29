using System;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class frmClientes : Form
    {
        private AccesoDatos miAccesoDatos = new AccesoDatos();
        private int idClienteSeleccionado = 0;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = miAccesoDatos.ObtenerClientes();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDocumento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            idClienteSeleccionado = 0;
        }

 

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            string nombre = txtNombre.Text;
            string documento = txtDocumento.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;

            miAccesoDatos.GuardarCliente(idClienteSeleccionado, nombre, documento, direccion, telefono, email);

            MessageBox.Show("Cliente guardado correctamente.");
            CargarClientes();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                miAccesoDatos.EliminarCliente(idClienteSeleccionado);
                MessageBox.Show("Cliente eliminado.");
                CargarClientes();
                LimpiarCampos();
            }
        }

        // --- EVENTO DE LA TABLA ---

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                // --- ESTA ES LA NUEVA VERIFICACIÓN ---
                // Si la fila en la que se hizo clic es la fila especial para "nuevos registros",
                // entonces limpiamos los campos y salimos del método para evitar el error.
                if (fila.IsNewRow)
                {
                    LimpiarCampos();
                    return;
                }

                // Si no es la fila nueva, el código continúa como antes
                idClienteSeleccionado = Convert.ToInt32(fila.Cells["IdCliente"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDocumento.Text = fila.Cells["Documento"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
            }
        }
    }
}
