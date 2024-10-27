namespace VentaProducto
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            txtNumfactura = new TextBox();
            txtCodigo = new TextBox();
            txtFecha = new TextBox();
            txtIdCliente = new TextBox();
            txtStock = new TextBox();
            label2 = new Label();
            labstock = new Label();
            labidcli = new Label();
            labf = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(439, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(519, 225);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(225, 427);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Vender";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 2;
            label1.Text = "Numero de factura";
            // 
            // txtNumfactura
            // 
            txtNumfactura.Location = new Point(179, 69);
            txtNumfactura.Name = "txtNumfactura";
            txtNumfactura.Size = new Size(150, 31);
            txtNumfactura.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(197, 128);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 4;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(96, 312);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 31);
            txtFecha.TabIndex = 5;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(173, 250);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(150, 31);
            txtIdCliente.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(187, 179);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 9;
            label2.Text = "Codigo del producto";
            // 
            // labstock
            // 
            labstock.AutoSize = true;
            labstock.Location = new Point(12, 179);
            labstock.Name = "labstock";
            labstock.Size = new Size(169, 25);
            labstock.TabIndex = 10;
            labstock.Text = "Cantidad a comprar";
            // 
            // labidcli
            // 
            labidcli.AutoSize = true;
            labidcli.Location = new Point(12, 256);
            labidcli.Name = "labidcli";
            labidcli.Size = new Size(155, 25);
            labidcli.TabIndex = 12;
            labidcli.Text = "Codigo del cliente";
            // 
            // labf
            // 
            labf.AutoSize = true;
            labf.Location = new Point(12, 312);
            labf.Name = "labf";
            labf.Size = new Size(57, 25);
            labf.TabIndex = 13;
            labf.Text = "Fecha";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(439, 371);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(519, 237);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 41);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 15;
            label3.Text = "Tabla de productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 343);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 16;
            label4.Text = "Tabla de clientes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 629);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(labf);
            Controls.Add(labidcli);
            Controls.Add(labstock);
            Controls.Add(label2);
            Controls.Add(txtStock);
            Controls.Add(txtIdCliente);
            Controls.Add(txtFecha);
            Controls.Add(txtCodigo);
            Controls.Add(txtNumfactura);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox txtNumfactura;
        private TextBox txtCodigo;
        private TextBox txtFecha;
        private TextBox txtIdCliente;
        private TextBox txtStock;
        private Label label2;
        private Label labstock;
        private Label labidcli;
        private Label labf;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label4;
    }
}
