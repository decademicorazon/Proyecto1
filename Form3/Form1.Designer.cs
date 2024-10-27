namespace Form3
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
            btnEliminar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtDescuento = new TextBox();
            txtFecha = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            txtId = new TextBox();
            labId = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(419, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(676, 332);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 86);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(160, 351);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(150, 31);
            txtDescuento.TabIndex = 4;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(192, 272);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(150, 31);
            txtFecha.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(160, 210);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(160, 151);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 351);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 8;
            label2.Text = "Descuento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 272);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 9;
            label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 213);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 10;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 151);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 11;
            label5.Text = "Apellido";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(419, 332);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(547, 332);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(160, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 14;
            // 
            // labId
            // 
            labId.AutoSize = true;
            labId.Location = new Point(70, 36);
            labId.Name = "labId";
            labId.Size = new Size(28, 25);
            labId.TabIndex = 15;
            labId.Text = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labId);
            Controls.Add(txtId);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(txtFecha);
            Controls.Add(txtDescuento);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
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
        private Button btnEliminar;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtDescuento;
        private TextBox txtFecha;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox txtId;
        private Label labId;
    }
}
