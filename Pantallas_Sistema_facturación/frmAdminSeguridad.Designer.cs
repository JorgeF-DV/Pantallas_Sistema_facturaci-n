namespace Capa_Presentacion
{
    partial class frmAdminSeguridad
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
            cboEmpleado = new ComboBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnConsultar = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // cboEmpleado
            // 
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(290, 99);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(182, 33);
            cboEmpleado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 58);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "Empleado";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(291, 207);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(290, 320);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(150, 31);
            txtClave.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 169);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 282);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(262, 408);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 34);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(450, 410);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmAdminSeguridad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 610);
            Controls.Add(btnActualizar);
            Controls.Add(btnConsultar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(cboEmpleado);
            Name = "frmAdminSeguridad";
            Text = "frmAdminSeguridad";
            Load += frmAdminSeguridad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEmpleado;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label label2;
        private Label label3;
        private Button btnConsultar;
        private Button btnActualizar;
    }
}