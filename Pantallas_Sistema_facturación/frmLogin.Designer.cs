namespace Capa_Presentacion
{
    partial class frmLogin
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
            txtUsuario = new TextBox();
            txtpasword = new TextBox();
            btnvalidar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 91);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 203);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(324, 129);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 2;
            // 
            // txtpasword
            // 
            txtpasword.Location = new Point(324, 240);
            txtpasword.Name = "txtpasword";
            txtpasword.PasswordChar = '*';
            txtpasword.Size = new Size(150, 31);
            txtpasword.TabIndex = 3;
            // 
            // btnvalidar
            // 
            btnvalidar.Location = new Point(240, 293);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(112, 34);
            btnvalidar.TabIndex = 4;
            btnvalidar.Text = "Validar";
            btnvalidar.UseVisualStyleBackColor = true;
            btnvalidar.Click += btnvalidar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(443, 293);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(259, 18);
            label3.Name = "label3";
            label3.Size = new Size(263, 48);
            label3.TabIndex = 6;
            label3.Text = "INICIA SESIÓN";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnvalidar);
            Controls.Add(txtpasword);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtpasword;
        private Button btnvalidar;
        private Button btnCancelar;
        private Label label3;
    }
}