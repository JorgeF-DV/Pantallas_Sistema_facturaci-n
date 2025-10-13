namespace Capa_Presentacion
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreProducto = new TextBox();
            txtPrecioCompra = new TextBox();
            txtCodigoReferencia = new TextBox();
            txtCantidadStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtDetallesProducto = new TextBox();
            txtRutaImagen = new TextBox();
            dgvProductos = new DataGridView();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnSalir = new Button();
            cmbCategoria = new ComboBox();
            Nombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(45, 34);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(150, 31);
            txtNombreProducto.TabIndex = 0;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(45, 194);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(150, 31);
            txtPrecioCompra.TabIndex = 1;
            // 
            // txtCodigoReferencia
            // 
            txtCodigoReferencia.Location = new Point(45, 115);
            txtCodigoReferencia.Name = "txtCodigoReferencia";
            txtCodigoReferencia.Size = new Size(150, 31);
            txtCodigoReferencia.TabIndex = 2;
            // 
            // txtCantidadStock
            // 
            txtCantidadStock.Location = new Point(45, 343);
            txtCantidadStock.Name = "txtCantidadStock";
            txtCantidadStock.Size = new Size(150, 31);
            txtCantidadStock.TabIndex = 4;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(45, 267);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(150, 31);
            txtPrecioVenta.TabIndex = 3;
            // 
            // txtDetallesProducto
            // 
            txtDetallesProducto.Location = new Point(269, 115);
            txtDetallesProducto.Name = "txtDetallesProducto";
            txtDetallesProducto.Size = new Size(150, 31);
            txtDetallesProducto.TabIndex = 6;
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Location = new Point(269, 194);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.Size = new Size(150, 31);
            txtRutaImagen.TabIndex = 5;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(486, 212);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(360, 225);
            dgvProductos.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(530, 33);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(530, 112);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(676, 31);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(676, 112);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(269, 35);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(182, 33);
            cmbCategoria.TabIndex = 12;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(45, 2);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(78, 25);
            Nombre.TabIndex = 13;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 87);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 14;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 166);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 15;
            label3.Text = "Precio Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 239);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 16;
            label4.Text = "Precio Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 315);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 17;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 9);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 18;
            label6.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 87);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 19;
            label7.Text = "Detalles:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(269, 176);
            label8.Name = "label8";
            label8.Size = new Size(72, 25);
            label8.TabIndex = 20;
            label8.Text = "Imagen";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 600);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(cmbCategoria);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProductos);
            Controls.Add(txtDetallesProducto);
            Controls.Add(txtRutaImagen);
            Controls.Add(txtCantidadStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCodigoReferencia);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtNombreProducto);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtPrecioCompra;
        private TextBox txtCodigoReferencia;
        private TextBox txtCantidadStock;
        private TextBox txtPrecioVenta;
        private TextBox txtDetallesProducto;
        private TextBox txtRutaImagen;
        private DataGridView dgvProductos;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnSalir;
        private ComboBox cmbCategoria;
        private Label Nombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}