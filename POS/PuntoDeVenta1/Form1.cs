using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PuntoDeVenta1
{
    public partial class Form1 : Form
    {
        

public Form1()
        {
            InitializeComponent();        
        }


        private void Form1_Load(object sender, EventArgs e)
        {    
            
        }

                         
        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            lblTotal.Text = "0,00";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
       
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            lblFecha.Text = fecha.ToString("dd/MM/yy");

            lblHora.Text = fecha.ToString("HH:mm:ss");
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
           
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void btnCobrarEfectivo_Click(object sender, EventArgs e)
        {
            int Total, Efectivo, Vuelto;

            if (int.TryParse(txtEfectivo.Text, out Efectivo) && int.TryParse(lblTotal.Text, out Total))
            {
                Vuelto = Efectivo - Total;


                lblVuelto.Text = Vuelto.ToString();
                dataGridView1.Rows.Clear();
                lblTotal.Text = "0,00";
                txtBuscarCod.Clear();

            }
            string cadenaConexion = "server=GonzaPc\\SQLEXPRESS; DATABASE=PuntoDeVenta; integrated security=true";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand("SELECT * FROM Producto WHERE CodigoSKU = @codigo", conexion))
            {
             
             
             
            }
        }


        private void lblVuelto_Click(object sender, EventArgs e)
        {

        }



        // Boton de Mercado Pago
        private void btnMP_Click(object sender, EventArgs e)
        {
            int Total, Efectivo, Vuelto;

            if (int.TryParse(txtEfectivo.Text, out Efectivo) && int.TryParse(lblTotal.Text, out Total))
            {
                Vuelto = Efectivo - Total;


                lblVuelto.Text = Vuelto.ToString();                                                       
                dataGridView1.Rows.Clear();
                lblTotal.Text = "0,00";
                txtBuscarCod.Clear();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarCod_TextChanged(object sender, EventArgs e)
        {
           

        }

        public void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string codigo = txtBuscarCod.Text.Trim();
            Producto producto = ProductosDB.BuscarPorCodigo(long.Parse(codigo));
                
            if (producto != null)
            {
                bool productoYaExiste = false;

               
                //Este foreach recorre la lista en caso de que se repita en vez de agregar otra fila suma a la  columna cantidad.
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == producto.CodProducto.ToString())
                    {
                        // Ya existe: sumamos 1 a la cantidad
                        int cantidadActual = Convert.ToInt32(fila.Cells[4].Value) + 1 ;
                        fila.Cells[4].Value = cantidadActual;
                        int preciomod = (producto.PrecioUnitario * cantidadActual);
                        fila.Cells[3].Value = preciomod;                      
                        productoYaExiste = true;
                        lblTotal.Text = preciomod.ToString();
                       int nuevoStock = producto.stock - cantidadActual;
                        fila.Cells[5].Value = nuevoStock;
                        break;                   
                    }
                }
                // en caso de que no se repita el producto se agrega como nueva fila normalmente.
                if (!productoYaExiste)
                {
                    // No existe: agregamos nueva fila con cantidad 1
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = producto.Nombre;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = producto.CodProducto;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = producto.PrecioUnitario;
                    dataGridView1.Rows[rowIndex].Cells[3].Value = producto.PrecioUnitario * int.Parse(txtCantidad.Text);
                    dataGridView1.Rows[rowIndex].Cells[4].Value = int.Parse(txtCantidad.Text);
                    dataGridView1.Rows[rowIndex].Cells[5].Value = producto.stock;

                    lblTotal.Text =  producto.PrecioUnitario.ToString();
                   
                }
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
           




        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            BuscadorProducto buscadorProducto = new BuscadorProducto();
            buscadorProducto.Show();
        }
    }
}
