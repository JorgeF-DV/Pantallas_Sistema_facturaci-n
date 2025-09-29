namespace Capa_Presentacion
{
    partial class frmEmpleados
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
            txtNombreEmpleado = new TextBox();
            txtDocumento = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboRolEmpleado = new ComboBox();
            dtmIngreso = new DateTimePicker();
            dtmRetiro = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            txtDatosAdicionales = new TextBox();
            label9 = new Label();
            btnActualizar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(28, 49);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(150, 31);
            txtNombreEmpleado.TabIndex = 0;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(28, 134);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(150, 31);
            txtDocumento.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(28, 220);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(28, 301);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(28, 396);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 5;
            label1.Text = "Nombre Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 103);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 6;
            label2.Text = "Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 182);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 7;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 273);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 8;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 363);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 15);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 10;
            label6.Text = "Rol Empleado";
            // 
            // cboRolEmpleado
            // 
            cboRolEmpleado.FormattingEnabled = true;
            cboRolEmpleado.Location = new Point(276, 49);
            cboRolEmpleado.Name = "cboRolEmpleado";
            cboRolEmpleado.Size = new Size(182, 33);
            cboRolEmpleado.TabIndex = 11;
            // 
            // dtmIngreso
            // 
            dtmIngreso.Location = new Point(276, 134);
            dtmIngreso.Name = "dtmIngreso";
            dtmIngreso.Size = new Size(300, 31);
            dtmIngreso.TabIndex = 12;
            // 
            // dtmRetiro
            // 
            dtmRetiro.Location = new Point(276, 232);
            dtmRetiro.Name = "dtmRetiro";
            dtmRetiro.Size = new Size(300, 31);
            dtmRetiro.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 106);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 14;
            label7.Text = "F. Ingreso";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(278, 204);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 15;
            label8.Text = "F. Salida";
            // 
            // txtDatosAdicionales
            // 
            txtDatosAdicionales.Location = new Point(276, 326);
            txtDatosAdicionales.Name = "txtDatosAdicionales";
            txtDatosAdicionales.Size = new Size(231, 31);
            txtDatosAdicionales.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(278, 295);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 17;
            label9.Text = "Datos adicionales";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(276, 408);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(122, 34);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(464, 408);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 553);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(label9);
            Controls.Add(txtDatosAdicionales);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtmRetiro);
            Controls.Add(dtmIngreso);
            Controls.Add(cboRolEmpleado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombreEmpleado);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreEmpleado;
        private TextBox txtDocumento;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboRolEmpleado;
        private DateTimePicker dtmIngreso;
        private DateTimePicker dtmRetiro;
        private Label label7;
        private Label label8;
        private TextBox txtDatosAdicionales;
        private Label label9;
        private Button btnActualizar;
        private Button btnSalir;
    }
}