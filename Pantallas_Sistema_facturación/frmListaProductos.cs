using Capa_LogicaDeNegocios;
using Pantallas_Sistema_facturación;
using System;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmListaProductos : Form
    {
        private Cls_Productos producto = new Cls_Productos();

        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void llenar_grid()
        {
            try
            {
                dgvProductos.DataSource = producto.ConsultarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProductos formularioEdicion = new frmProductos();
            formularioEdicion.IdProducto = 0; // ID 0 significa que es un registro nuevo
            formularioEdicion.ShowDialog();
            llenar_grid(); // Actualiza la lista al cerrar
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                frmProductos formularioEdicion = new frmProductos();
                // Pasamos el ID del producto seleccionado
                formularioEdicion.IdProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);
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
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int idParaBorrar = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);
                    string mensaje = producto.EliminarProducto(idParaBorrar);
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