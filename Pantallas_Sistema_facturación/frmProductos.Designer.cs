namespace Pantallas_Sistema_facturación
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreProducto = new TextBox();
            txtCodigoReferencia = new TextBox();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCantidadStock = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cmbCategoria = new ComboBox();
            label9 = new Label();
            txtDetallesProducto = new TextBox();
            btnSalir = new Button();
            btnNuevo = new Button();
            dgvProductos = new DataGridView();
            txtRutaImagen = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 25);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 56);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 144);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 2;
            label3.Text = "Código Referencia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 227);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 3;
            label4.Text = "Precio Compra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 56);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 4;
            label5.Text = "Precio Venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 144);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 5;
            label6.Text = "Cantidad stock";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(34, 96);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(150, 31);
            txtNombreProducto.TabIndex = 6;
            // 
            // txtCodigoReferencia
            // 
            txtCodigoReferencia.Location = new Point(34, 180);
            txtCodigoReferencia.Name = "txtCodigoReferencia";
            txtCodigoReferencia.Size = new Size(150, 31);
            txtCodigoReferencia.TabIndex = 7;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(40, 255);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(150, 31);
            txtPrecioCompra.TabIndex = 8;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(243, 96);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(150, 31);
            txtPrecioVenta.TabIndex = 9;
            // 
            // txtCantidadStock
            // 
            txtCantidadStock.Location = new Point(243, 180);
            txtCantidadStock.Name = "txtCantidadStock";
            txtCantidadStock.Size = new Size(150, 31);
            txtCantidadStock.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 239);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 11;
            label7.Text = "Ruta imagen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(507, 56);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 12;
            label8.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(470, 94);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(182, 33);
            cmbCategoria.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(482, 144);
            label9.Name = "label9";
            label9.Size = new Size(153, 25);
            label9.TabIndex = 14;
            label9.Text = "Detalles producto";
            // 
            // txtDetallesProducto
            // 
            txtDetallesProducto.Location = new Point(470, 180);
            txtDetallesProducto.Multiline = true;
            txtDetallesProducto.Name = "txtDetallesProducto";
            txtDetallesProducto.Size = new Size(182, 106);
            txtDetallesProducto.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Lime;
            btnSalir.Location = new Point(50, 322);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 34);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ActiveCaption;
            btnNuevo.Location = new Point(417, 322);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "CREAR";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(13, 378);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(673, 225);
            dgvProductos.TabIndex = 18;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // txtRutaImagen
            // 
            txtRutaImagen.Location = new Point(243, 281);
            txtRutaImagen.Name = "txtRutaImagen";
            txtRutaImagen.Size = new Size(150, 31);
            txtRutaImagen.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(535, 322);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(653, 322);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 769);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtRutaImagen);
            Controls.Add(dgvProductos);
            Controls.Add(btnNuevo);
            Controls.Add(btnSalir);
            Controls.Add(txtDetallesProducto);
            Controls.Add(label9);
            Controls.Add(cmbCategoria);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCantidadStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCodigoReferencia);
            Controls.Add(txtNombreProducto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreProducto;
        private TextBox txtCodigoReferencia;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private TextBox txtCantidadStock;
        private Label label7;
        private Label label8;
        private ComboBox cmbCategoria;
        private Label label9;
        private TextBox txtDetallesProducto;
        private Button btnSalir;
        private Button btnNuevo;
        private DataGridView dgvProductos;
        private TextBox txtRutaImagen;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}