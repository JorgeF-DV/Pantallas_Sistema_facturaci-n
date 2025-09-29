namespace Pantallas_Sistema_facturación
{
    partial class frmPrincipal
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
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pnlContenedor = new Panel();
            button8 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1340, 103);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(277, 61);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 7;
            button7.Text = "EMPLEADOS";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(153, 60);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 6;
            button6.Text = "PRODUCTOS";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(105, 60);
            label1.TabIndex = 5;
            label1.Text = "SDF";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(624, 12);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 4;
            button5.Text = "AYUDA";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(506, 12);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "SEGURIDAD";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(388, 12);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "FACTURACIÓN";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(270, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "CLIENTES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(152, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "PRINCIPAL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.Location = new Point(12, 121);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1340, 693);
            pnlContenedor.TabIndex = 2;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(403, 63);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 8;
            button8.Text = "ROLES";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 826);
            Controls.Add(pnlContenedor);
            Controls.Add(panel1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlContenedor;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}