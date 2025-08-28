namespace Pantallas_Sistema_facturación
{
    partial class frmFacturas
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
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 25);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACIÓN FACTURAS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 48);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 1;
            label2.Text = "Nro Factura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 91);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 141);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Empleado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 182);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 4;
            label5.Text = "Descuento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 219);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 5;
            label6.Text = "Total IVA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(493, 48);
            label8.Name = "label8";
            label8.Size = new Size(123, 25);
            label8.TabIndex = 8;
            label8.Text = "Fecha registro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 138);
            label9.Name = "label9";
            label9.Size = new Size(132, 25);
            label9.TabIndex = 9;
            label9.Text = "Estado Factura ";
            // 
            // button1
            // 
            button1.Location = new Point(614, 381);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(662, 129);
            button2.Name = "button2";
            button2.Size = new Size(126, 34);
            button2.TabIndex = 11;
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 31);
            textBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(136, 141);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 259);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 15;
            label10.Text = "Total factura";
            label10.Click += label10_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(499, 172);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(126, 33);
            comboBox3.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(498, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(127, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(27, 321);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 127);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de factura";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 351);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(544, 169);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(label10);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmFacturas";
            Text = "frmFacturas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label10;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}