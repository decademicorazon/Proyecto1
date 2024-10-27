
using Capa_Negocios;
using System.Data;
using Capa_Datos;
using System.Diagnostics.CodeAnalysis;
namespace ProyectoCompraProductos
   
{
    public partial class Form1 : Form
    {

        Negocios neg = new Negocios();
        Datos cn = new Datos();
        private string dniString;
        public Form1(string dni)
        {
            InitializeComponent();

            this.dniString = dni;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable productos = neg.cargarProducts();
            dataGridView1.DataSource = productos;
            DataTable proveedores = cn.ObtenerProveedores();
            dataGridView2.DataSource = proveedores;
        }

        

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Productos product = new Productos();


            ComprobanteProveedor comp = new ComprobanteProveedor();
            product.Id = txtCodigoProducto.Text;
            product.stock = txtCantidad.Text;
            comp.total = txtPrecio.Text;
            comp.idProveedor = txtProveedor.Text;
            comp.fecha = txtFechaCompra.Text;
            comp.numeroProveedor = txtNumFactura.Text;
            comp.idEmpleado = dniString;
            string mensaje;

            bool Esvalido = neg.RealizarCompra(comp, product, out mensaje);
            if (Esvalido)
            {
                MessageBox.Show("Compra exitosa");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
