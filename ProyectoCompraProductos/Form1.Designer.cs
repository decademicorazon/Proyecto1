namespace ProyectoCompraProductos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnComprar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtCodigoProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNumFactura = new TextBox();
            txtFechaCompra = new TextBox();
            txtProveedor = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(226, 443);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(112, 34);
            btnComprar.TabIndex = 0;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(544, 225);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 58);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(124, 58);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(150, 31);
            txtCodigoProducto.TabIndex = 3;
            txtCodigoProducto.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 174);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(169, 25);
            label3.TabIndex = 5;
            label3.Text = "Cantidad a comprar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 349);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 6;
            label4.Text = "Numero de factura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 287);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 7;
            label5.Text = "Fecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 227);
            label6.Name = "label6";
            label6.Size = new Size(188, 25);
            label6.TabIndex = 8;
            label6.Text = "Codigo del proveedor";
            label6.Click += label6_Click;
            // 
            // txtNumFactura
            // 
            txtNumFactura.Location = new Point(188, 349);
            txtNumFactura.Name = "txtNumFactura";
            txtNumFactura.Size = new Size(150, 31);
            txtNumFactura.TabIndex = 10;
            // 
            // txtFechaCompra
            // 
            txtFechaCompra.Location = new Point(124, 287);
            txtFechaCompra.Name = "txtFechaCompra";
            txtFechaCompra.Size = new Size(150, 31);
            txtFechaCompra.TabIndex = 11;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(197, 227);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(150, 31);
            txtProveedor.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(124, 174);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 13;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(187, 112);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 31);
            txtCantidad.TabIndex = 14;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(424, 360);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(544, 225);
            dataGridView2.TabIndex = 15;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(462, 16);
            label7.Name = "label7";
            label7.Size = new Size(164, 25);
            label7.TabIndex = 16;
            label7.Text = "Tabla de productos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(462, 321);
            label8.Name = "label8";
            label8.Size = new Size(182, 25);
            label8.TabIndex = 17;
            label8.Text = "Tabla de provedorees";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 650);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dataGridView2);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtProveedor);
            Controls.Add(txtFechaCompra);
            Controls.Add(txtNumFactura);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCodigoProducto);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnComprar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComprar;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtCodigoProducto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNumFactura;
        private TextBox txtFechaCompra;
        private TextBox txtProveedor;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private DataGridView dataGridView2;
        private Label label7;
        private Label label8;
    }
}
