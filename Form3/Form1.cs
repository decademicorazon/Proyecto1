
using Capa_Datos;
using Capa_Negocios;
using System.Data;
using System.Windows.Forms;

namespace Form3
{

    public partial class Form1 : Form
    {
        Negocios neg = new Negocios();


        Datos data = new Datos();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            txtId.Text = fila.Cells["codigo"].Value.ToString();
            txtApellido.Text = fila.Cells["apellido"].Value.ToString();
            txtNombre.Text = fila.Cells["nombre"].Value.ToString();
            txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
            txtFecha.Text = fila.Cells["fecha_nac"].Value.ToString();
            txtDescuento.Text = fila.Cells["descuento"].Value.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable clientes = data.ObtenerClientes();
            dataGridView1.DataSource = clientes;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.apellido = txtApellido.Text;
            cliente.nombre = txtNombre.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.fecha = txtFecha.Text;
            cliente.descuento = txtDescuento.Text;
            string mensaje;
            bool esValido = neg.ValidacionAgregarCliente(cliente, out mensaje);
            if (esValido)
            {
                bool ClienteAgregar = neg.AgregarCliente(cliente, out mensaje);
                if (ClienteAgregar)
                {
                    MessageBox.Show("Cliente agregado correctamente");
                }
                else { MessageBox.Show("Hubo un error al agregar el cliente"); }


            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.id = txtId.Text;
            cliente.apellido = txtApellido.Text;
            cliente.nombre = txtNombre.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.fecha = txtFecha.Text;
            cliente.descuento = txtDescuento.Text;
            string mensaje;
            bool esValido = neg.ValidacionAgregarCliente(cliente, out mensaje);
            if (esValido)
            {
                bool ClienteModificar = neg.ActualizarCliente(cliente, out mensaje);
                if (ClienteModificar)
                {
                    MessageBox.Show("Cliente modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Hubo un eror al modficar el cliente");

                }
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.id = txtId.Text;
           bool ClienteELiminar = neg.BajaCliente(cliente);
            if (ClienteELiminar)
            {
                MessageBox.Show("Cliente eliminado correctamente");

            }
            else
            {
                MessageBox.Show("Hubo un error al eliminar el cliente");
            }
        }
    }
}
