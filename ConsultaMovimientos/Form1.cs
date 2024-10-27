using Capa_Datos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
namespace ConsultaMovimientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }
        Datos cn = new Datos();

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable facturaprov = cn.ObtenerFacturasProveedores();
            dataGridView1.DataSource = facturaprov;
            DataTable facturaclient = cn.ObtenerFacturaClientes();
            dataGridView2.DataSource = facturaclient;
        }
    }
}
