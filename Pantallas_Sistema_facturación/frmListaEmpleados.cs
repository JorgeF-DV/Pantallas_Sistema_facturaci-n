using Capa_LogicaDeNegocios; // <-- Referencia a la capa de lógica
using Pantallas_Sistema_facturación;
using System;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmListaEmpleados : Form
    {
        // Creamos una instancia de la clase de la capa de lógica de negocios
        private Cls_Empleados empleado = new Cls_Empleados();

        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario, llenamos la tabla
            llenar_grid();
        }

        private void llenar_grid()
        {
            // Llenamos el DataGridView llamando al método de la capa de lógica
            dgvEmpleados.DataSource = empleado.Consulta_Empleado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Abrimos el formulario de edición
            frmEmpleados formularioEdicion = new frmEmpleados();
            // Le pasamos un ID de 0 para indicarle que es un registro nuevo
            formularioEdicion.IdEmpleado = 0;
            formularioEdicion.ShowDialog(); // ShowDialog espera a que se cierre para continuar

            // Al cerrar, actualizamos la lista por si se agregó el nuevo empleado
            llenar_grid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una fila seleccionada
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                frmEmpleados formularioEdicion = new frmEmpleados();

                // Le pasamos el ID del empleado seleccionado al otro formulario
                // La celda 0 usualmente contiene el ID
                formularioEdicion.IdEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                formularioEdicion.ShowDialog();

                // Al cerrar, actualizamos la lista por si hubo cambios
                llenar_grid();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que se haya seleccionado una fila en la tabla
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                // 2. Pedimos confirmación al usuario
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // 3. Obtenemos el ID del empleado de la fila seleccionada
                    int idParaBorrar = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["IdEmpleado"].Value);

                    // 4. Pasamos el ID a la capa de lógica para que lo elimine
                    empleado.C_IdEmpleado = idParaBorrar;
                    string mensaje = empleado.EliminaEmpleado();

                    MessageBox.Show(mensaje);

                    // 5. Actualizamos la lista para ver el cambio
                    llenar_grid();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para borrar.");
            }
        }


    }
}


