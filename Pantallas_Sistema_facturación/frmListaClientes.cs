using Capa_LogicaDeNegocios;
using Pantallas_Sistema_facturación;
using System;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmListaClientes : Form
    {
        private Cls_Clientes cliente = new Cls_Clientes();

        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void llenar_grid()
        {
            dgvClientes.DataSource = cliente.ConsultarClientes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmClientes formularioEdicion = new frmClientes();
            formularioEdicion.IdCliente = 0; // ID 0 significa que es un registro nuevo
            formularioEdicion.ShowDialog();
            llenar_grid(); // Actualiza la lista al cerrar
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                frmClientes formularioEdicion = new frmClientes();
                // Pasamos el ID del cliente seleccionado
                formularioEdicion.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);
                formularioEdicion.ShowDialog();
                llenar_grid(); // Actualiza la lista al cerrar
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int idParaBorrar = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);
                    string mensaje = cliente.EliminarCliente(idParaBorrar);
                    MessageBox.Show(mensaje);
                    llenar_grid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para borrar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}