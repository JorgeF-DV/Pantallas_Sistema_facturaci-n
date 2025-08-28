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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Limpiamos cualquier error previo antes de validar de nuevo.
            errorProvider1.Clear();

            // Variable para controlar si hay errores.
            bool hayErrores = false;

            // --- VALIDACIÓN DEL NOMBRE ---
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                // Si el TextBox está vacío o solo tiene espacios...
                hayErrores = true;
                // Asignamos un error al TextBox del nombre.
                errorProvider1.SetError(txtNombreCliente, "El nombre del cliente no puede estar vacío.");
            }

            // --- PUEDES AÑADIR MÁS VALIDACIONES AQUÍ (Documento, Email, etc.) ---
            // if (string.IsNullOrWhiteSpace(txtDocumento.Text)) { ... }


            // --- DECISIÓN FINAL ---
            if (hayErrores)
            {
                // Si se encontró algún error, no hacemos nada más.
                return;
            }

            // Si llegamos aquí, significa que no hubo errores.
            // Aquí iría el código para guardar los datos en la base de datos.
            MessageBox.Show("¡Datos guardados correctamente!");
        }
    }
}
