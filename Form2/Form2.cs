using Capa_Datos;
using Capa_Negocios;

using System.Data;
using System.Security.Cryptography.X509Certificates;


namespace Form2
{
    public partial class Form2 : Form
    {
        Negocios neg = new Negocios();
        Datos datos = new Datos();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            txtDni.Text = fila.Cells["dni"].Value.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
            txtFechaNac.Text = fila.Cells["fecha_nac"].Value.ToString();
            txtUsuario.Text = fila.Cells["usuario"].Value.ToString();
            txtClave.Text = fila.Cells["clave"].Value.ToString();
            txtTipo.Text= fila.Cells["tipo"].Value.ToString() ;
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable empleados = datos.ObtenerEmpleados();
            dataGridView1.DataSource = empleados;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string fecha = txtFechaNac.Text;
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            string tipo = txtTipo.Text;
            string mensaje;
            bool esValido = neg.ValidacionAgregarEmpleado(dni, nombre, apellido, telefono, fecha, usuario, clave, tipo, out mensaje);

            if (esValido)
            {

                bool empleadoAgregado = neg.AgregarEmpleado(dni, nombre, apellido, telefono, fecha, usuario, clave, tipo, out mensaje);

                if (empleadoAgregado)
                {
                    MessageBox.Show("Empleado agregado correctamente");
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el empleado");
                }
            }
            else
            {
                MessageBox.Show(mensaje);
                    }
        }

        private void butModificar_Click(object sender, EventArgs e)
        {

            string dni = txtDni.Text;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string fecha = txtFechaNac.Text;
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            string tipo = txtTipo.Text;
            string mensaje;

            bool esValido = neg.ValidacionAgregarEmpleado(dni, apellido, nombre, telefono, fecha, usuario, clave, tipo, out mensaje); 
            if (esValido)
            {
                bool EmpleadoAmodificar = neg.ActualizarEmpleado(dni, apellido, nombre, telefono, fecha, usuario, clave, tipo, out mensaje);
                if (EmpleadoAmodificar) { MessageBox.Show("Empleado modificado correctamente"); }
                else
                {
                    MessageBox.Show("Hubo un error al modificar empleado");
                }

            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;

            bool esValido = neg.ValidarBajaEmpleado(dni);
            if (esValido)
            {
                bool EmpleadoEliminar = neg.BajaEmpleado(dni);
                if (EmpleadoEliminar)
                {
                    MessageBox.Show("Empleado eliminado correctamente");

                }
                else { MessageBox.Show("Hubo un error al eliminar el empleado"); }
            }
            else { MessageBox.Show("No puede dejar campos vacios y debe poner un dni valido"); }
        }
    }
}
