namespace CrudProductos
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
            label1 = new Label();
            txtStockMinimo = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labCodigo = new Label();
            txtPorcentaje = new TextBox();
            txtPrecio = new TextBox();
            txtNombreCorto = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            txtId = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(404, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(146, 307);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(150, 31);
            txtStockMinimo.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(416, 331);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-1, 366);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 4;
            label2.Text = "Porcentaje de ganancia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 307);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 5;
            label3.Text = "Stock Minimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 250);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 198);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 8;
            label6.Text = "Nombre Corto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 146);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 9;
            label7.Text = "Nombre";
            // 
            // labCodigo
            // 
            labCodigo.AutoSize = true;
            labCodigo.Location = new Point(12, 91);
            labCodigo.Name = "labCodigo";
            labCodigo.Size = new Size(71, 25);
            labCodigo.TabIndex = 10;
            labCodigo.Text = "Codigo";
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(214, 366);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(150, 31);
            txtPorcentaje.TabIndex = 11;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(78, 250);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 13;
            // 
            // txtNombreCorto
            // 
            txtNombreCorto.Location = new Point(146, 198);
            txtNombreCorto.Name = "txtNombreCorto";
            txtNombreCorto.Size = new Size(150, 31);
            txtNombreCorto.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 15;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(89, 88);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(55, 27);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(676, 331);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 18;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(550, 331);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 19;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtId);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(txtNombreCorto);
            Controls.Add(txtPrecio);
            Controls.Add(txtPorcentaje);
            Controls.Add(labCodigo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtStockMinimo);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtStockMinimo;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labCodigo;
        private TextBox txtPorcentaje;
        private TextBox txtPrecio;
        private TextBox txtNombreCorto;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private TextBox txtId;
        private Button button2;
        private Button button3;
    }
}
