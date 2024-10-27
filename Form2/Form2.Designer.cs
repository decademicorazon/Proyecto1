namespace Form2
{
    partial class Form2
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
            txtDni = new TextBox();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            txtFechaNac = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            butAgregar = new Button();
            butModificar = new Button();
            butEliminar = new Button();
            txtTipo = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(414, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(116, 58);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(150, 31);
            txtDni.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(87, 373);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(150, 31);
            txtClave.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(87, 318);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 3;
            // 
            // txtFechaNac
            // 
            txtFechaNac.Location = new Point(205, 269);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(150, 31);
            txtFechaNac.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(116, 215);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 160);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(116, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 58);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 8;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 379);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 9;
            label2.Text = "Clave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 324);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 10;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 275);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 11;
            label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 12;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 166);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 13;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 117);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 14;
            label7.Text = "Apellido";
            // 
            // butAgregar
            // 
            butAgregar.Location = new Point(428, 345);
            butAgregar.Name = "butAgregar";
            butAgregar.Size = new Size(112, 34);
            butAgregar.TabIndex = 15;
            butAgregar.Text = "Agregar";
            butAgregar.UseVisualStyleBackColor = true;
            butAgregar.Click += butAgregar_Click;
            // 
            // butModificar
            // 
            butModificar.Location = new Point(549, 345);
            butModificar.Name = "butModificar";
            butModificar.Size = new Size(112, 34);
            butModificar.TabIndex = 16;
            butModificar.Text = "Modificar";
            butModificar.UseVisualStyleBackColor = true;
            butModificar.Click += butModificar_Click;
            // 
            // butEliminar
            // 
            butEliminar.Location = new Point(667, 345);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(112, 34);
            butEliminar.TabIndex = 17;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(87, 426);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(150, 31);
            txtTipo.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 432);
            label8.Name = "label8";
            label8.Size = new Size(47, 25);
            label8.TabIndex = 19;
            label8.Text = "Tipo";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(label8);
            Controls.Add(txtTipo);
            Controls.Add(butEliminar);
            Controls.Add(butModificar);
            Controls.Add(butAgregar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtTelefono);
            Controls.Add(txtFechaNac);
            Controls.Add(txtUsuario);
            Controls.Add(txtClave);
            Controls.Add(txtDni);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtDni;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private TextBox txtFechaNac;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button butAgregar;
        private Button butModificar;
        private Button butEliminar;
        private TextBox txtTipo;
        private Label label8;
    }
}
