using Capa_LogicaDeNegocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmProductos : Form
    {
        public int IdProducto { get; set; }
        private Cls_Productos producto = new Cls_Productos();

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            if (IdProducto > 0)
            {
                this.Text = "Editar Producto";
                cargar_datos_producto();
            }
            else
            {
                this.Text = "Nuevo Producto";
            }
        }

        private void CargarCategorias()
        {
            // Ya no usamos una lógica auxiliar, usamos la instancia correcta de 'producto'
            cmbCategoria.DataSource = producto.ConsultarCategorias();

            // Le decimos qué columna MOSTRAR al usuario (de TBLCATEGORIA_PROD)
            cmbCategoria.DisplayMember = "StrDescripcion";

            // Le decimos qué columna usar como VALOR INTERNO (de TBLCATEGORIA_PROD)
            cmbCategoria.ValueMember = "IdCategoria";
        }

        private void cargar_datos_producto()
        {
            DataTable dt = producto.ConsultarProductoPorId(IdProducto);
            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                txtNombreProducto.Text = fila["StrNombre"].ToString();
                txtCodigoReferencia.Text = fila["StrCodigo"].ToString();
                txtPrecioCompra.Text = fila["NumPrecioCompra"].ToString();
                txtPrecioVenta.Text = fila["NumPrecioVenta"].ToString();
                txtCantidadStock.Text = fila["NumStock"].ToString();
                txtDetallesProducto.Text = fila["StrDetalle"].ToString();
                cmbCategoria.SelectedValue = Convert.ToInt32(fila["IdCategoria"]);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            producto.C_IdProducto = IdProducto;
            producto.C_StrNombre = txtNombreProducto.Text;
            producto.C_StrCodigo = txtCodigoReferencia.Text;
            producto.C_NumPrecioCompra = double.Parse(txtPrecioCompra.Text);
            producto.C_NumPrecioVenta = double.Parse(txtPrecioVenta.Text);
            producto.C_NumStock = int.Parse(txtCantidadStock.Text);
            producto.C_StrDetalle = txtDetallesProducto.Text;
            producto.C_IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);

            string mensaje = producto.GuardarProducto();
            MessageBox.Show(mensaje);

            this.Close();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}