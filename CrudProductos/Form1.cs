using Capa_Negocios;
using Capa_Datos;
using System.Data;
using Google.Protobuf.WellKnownTypes;
namespace CrudProductos

{
    public partial class Form1 : Form
    {
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
            txtId.Text = fila.Cells["id_produ"].Value.ToString();
            txtCodigo.Text = fila.Cells["codigo"].Value.ToString();
            txtNombre.Text = fila.Cells["nombreproducto"].Value.ToString();
            txtNombreCorto.Text = fila.Cells["nombrecorto"].Value.ToString();
            txtPrecio.Text = fila.Cells["preciocosto"].Value.ToString();

            txtStockMinimo.Text = fila.Cells["stockminimo"].Value.ToString();
            txtPorcentaje.Text = fila.Cells["porcentajeganancia"].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable productos = data.ObtenerProductos();
            dataGridView1.DataSource = productos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Negocios neg = new Negocios();
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string nombreCorto = txtNombreCorto.Text;
            string precio = txtPrecio.Text;
            string mensaje;
            string stockMinimo = txtStockMinimo.Text;
            string porcentaje = txtPorcentaje.Text;
            int stockInt = 0;

            string stockStr = stockInt.ToString();

            bool esValido = neg.ValidacionAgregarProducto(codigo, nombre, nombreCorto, precio, stockStr, stockMinimo, porcentaje, out mensaje);
            if (esValido)
            {
                bool ProductoAgregado = neg.AgregarProducto(codigo, nombre, nombreCorto, precio, stockStr, stockMinimo, porcentaje, out mensaje);
                if (ProductoAgregado)
                {
                    MessageBox.Show("Producto Agregado correctamente");
                }
                else
                {
                    MessageBox.Show("Debe llenar los campos correctamente");
                }
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Negocios neg = new Negocios();
            string id = txtId.Text;
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string nombreCorto = txtNombreCorto.Text;
            string precio = txtPrecio.Text;
            string stockMinimo = txtStockMinimo.Text;
            string porcentaje = txtPorcentaje.Text;
            string mensaje;
            bool esValido = neg.ValidarModificacionProducto(id, codigo, nombre, nombreCorto, precio, stockMinimo, porcentaje, out mensaje);
            if (esValido)
            {
                bool ProductoModificar = neg.ActualizarProducto(id, codigo, nombre, nombreCorto, precio, stockMinimo, porcentaje, out mensaje);
                if (ProductoModificar)
                {
                    MessageBox.Show("Producto modificado correctamente");
                }
                else
                {
                    MessageBox.Show("No");
                }
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Negocios neg = new Negocios();
            string id = txtId.Text;
            bool esValido = neg.ValidarBajaProducto(id); 
            if (esValido)
            {
                bool ProductoBaja = neg.BajaProducto(id);
                if (ProductoBaja)
                {
                    MessageBox.Show("Producto eliminado correctamente");

                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }
            }else
            {
                MessageBox.Show("Debe poner un id valido");
            }
        }
    }
}
