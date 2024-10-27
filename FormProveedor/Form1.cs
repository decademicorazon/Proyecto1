
using Capa_Datos;
using Capa_Negocios;
using System.Data;
namespace FormProveedor;


public partial class Form1 : Form
{
    Datos data = new Datos();
    Negocios negocios = new Negocios();
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
        txtId.Text = fila.Cells["idproveedor"].Value.ToString();
        txtApellido.Text = fila.Cells["apellidoproveedor"].Value.ToString();
        txtNombre.Text = fila.Cells["nombreproveedor"].Value.ToString();
        txtTelefono.Text = fila.Cells["telefonoproveedor"].Value.ToString();
        txtDireccion.Text = fila.Cells["direccionproveedor"].Value.ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        DataTable proveedores = data.ObtenerProveedores();
        dataGridView1.DataSource = proveedores;
    }

    private void btnAgregarProveedor_Click(object sender, EventArgs e)
    {
        Proveedores proveedor = new Proveedores();
        proveedor.apellido = txtApellido.Text;
        proveedor.nombre = txtNombre.Text;
        proveedor.telefono = txtTelefono.Text;
        proveedor.direccion = txtDireccion.Text;
        string mensaje;

        bool esValido = negocios.ValidacionAgregarProveedor(proveedor, out mensaje);
        if (esValido)
        {
            bool proveedorAgregar = negocios.AgregarProveedor(proveedor, out mensaje);
            if (proveedorAgregar) { MessageBox.Show("Proveedor agregado correctamente"); }
            else
            {
                MessageBox.Show("Hubo un error al agregar el proveedor");
            }
        }
        else
        {
            MessageBox.Show("No debe dejar campos vacios");
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        Proveedores proveedor = new Proveedores();
        proveedor.id = txtId.Text;
        bool proveedorEliminar = negocios.BajaProveedor(proveedor);
        if (proveedorEliminar)
        {
            MessageBox.Show("Proveedor eliminado correctamente");

        }
        else
        {
            MessageBox.Show("Hubo un error al eliminar el cliente");
        }
    }



    private void btnModificar_Click(object sender, EventArgs e)
    {
        Proveedores proveedor = new Proveedores();
        proveedor.id = txtId.Text;
        proveedor.apellido = txtApellido.Text;
        proveedor.nombre = txtNombre.Text;
        proveedor.telefono = txtTelefono.Text;
        proveedor.direccion = txtDireccion.Text;
        string mensaje;

        bool esValido = negocios.ValidacionAgregarProveedor(proveedor, out mensaje);
        if (esValido)
        {
            bool proveedorModificar = negocios.ActualizarProveedor(proveedor, out mensaje);
            if (proveedorModificar)
            {
                MessageBox.Show("Proveedor modificado correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un eror al modficar el proveedor");

            }
        }
        else
        {
            MessageBox.Show("No debe dejar campos vacios");
        }
    }

    private void FormularioProveedor_Load(object sender, EventArgs e)
    {

    }
}

