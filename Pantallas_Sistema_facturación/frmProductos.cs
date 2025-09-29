using System;
using System.Data;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class frmProductos : Form
    {
        private AccesoDatos miAccesoDatos = new AccesoDatos();
        private int idProductoSeleccionado = 0;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarCategorias();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = miAccesoDatos.ObtenerProductos();
        }

        private void CargarCategorias()
        {
            cmbCategoria.DataSource = miAccesoDatos.ObtenerCategorias();
            cmbCategoria.DisplayMember = "StrDescripcion"; 
            cmbCategoria.ValueMember = "IdCategoria";      
        }

        private void LimpiarCampos()
        {
            
            txtNombreProducto.Clear();
            txtCodigoReferencia.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtCantidadStock.Clear();
            txtDetallesProducto.Clear();
            txtRutaImagen.Clear();
            cmbCategoria.SelectedIndex = -1;
            idProductoSeleccionado = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text;
            string codigo = txtCodigoReferencia.Text;
            double pCompra = Convert.ToDouble(txtPrecioCompra.Text);
            double pVenta = Convert.ToDouble(txtPrecioVenta.Text);
            int stock = Convert.ToInt32(txtCantidadStock.Text);
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            string detalle = txtDetallesProducto.Text;

            miAccesoDatos.GuardarProducto(idProductoSeleccionado, nombre, codigo, pCompra, pVenta, idCategoria, detalle, stock);

            MessageBox.Show("Producto guardado correctamente.");
            CargarProductos();
            LimpiarCampos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvProductos.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                idProductoSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);

                txtNombreProducto.Text = fila.Cells["StrNombre"].Value.ToString();
                txtCodigoReferencia.Text = fila.Cells["StrCodigo"].Value.ToString();
                txtPrecioCompra.Text = fila.Cells["NumPrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = fila.Cells["NumPrecioVenta"].Value.ToString();
                txtCantidadStock.Text = fila.Cells["NumStock"].Value.ToString();
                txtDetallesProducto.Text = fila.Cells["StrDetalle"].Value.ToString();
                txtRutaImagen.Text = fila.Cells["strFoto"].Value.ToString();
                cmbCategoria.SelectedValue = Convert.ToInt32(fila.Cells["IdCategoria"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                miAccesoDatos.EliminarProducto(idProductoSeleccionado);
                MessageBox.Show("Producto eliminado.");
                CargarProductos();
                LimpiarCampos();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}