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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
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
            label1.Click += label1_Click;
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
            label5.Location = new Point(243, 56);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 4;
            label5.Text = "Precio Venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 144);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 5;
            label6.Text = "Cantidad stock";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(243, 96);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(243, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(243, 245);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 11;
            label7.Text = "Ruta imagen";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(470, 56);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 12;
            label8.Text = "Categoría";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(470, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(470, 144);
            label9.Name = "label9";
            label9.Size = new Size(153, 25);
            label9.TabIndex = 14;
            label9.Text = "Detalles producto";
            label9.Click += label9_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(470, 180);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(182, 106);
            textBox6.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(446, 305);
            button1.Name = "button1";
            button1.Size = new Size(122, 34);
            button1.TabIndex = 16;
            button1.Text = "ACTUALIZAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(574, 305);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 17;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = false;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductos";
            Text = "frmProductos";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
    }
}