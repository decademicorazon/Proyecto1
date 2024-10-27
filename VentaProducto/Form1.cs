
using Capa_Datos;
using Capa_Negocios;
using System.Data;
using System.Windows.Forms;
namespace VentaProducto
{
    public partial class Form1 : Form
    {
        Datos dt = new Datos();
        Negocios neg = new Negocios();
        private string dniString;
        public Form1(string dni)
        {
            InitializeComponent();
            this.dniString = dni;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable productos = neg.cargarProducts();
            dataGridView1.DataSource = productos;
            DataTable clientes = dt.ObtenerClientes();
            dataGridView2.DataSource = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos product = new Productos();
            ComprobantesClientes comp = new ComprobantesClientes();
            product.stock = txtStock.Text;
            comp.numeroFactura = txtNumfactura.Text;
          //  comp.total = txtPrecio.Text;
            comp.idProduct = txtCodigo.Text;
            comp.fecha = txtFecha.Text;
            comp.idCliente = txtIdCliente.Text;
            comp.idEmpleado = dniString;
            bool requiereMensaje;
            string mensaje;
            bool esValido = neg.RealizarVenta(comp, product, out requiereMensaje, out mensaje);
            if (requiereMensaje)
            {
                DialogResult resultado = MessageBox.Show(mensaje,
                                                 "Confirmación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);




                if (resultado == DialogResult.Yes)
                {
                    bool eSvalido = neg.RealizarVentaSinValidar(comp, product, true, out mensaje);
                    if (eSvalido)
                    {
                        MessageBox.Show("Venta exitosa");
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    MessageBox.Show("La venta ha sido cancelada");
                }
            }
            else if (!esValido)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Venta realizada con éxito.");
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
