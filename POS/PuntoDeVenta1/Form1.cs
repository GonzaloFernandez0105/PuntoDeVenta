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
            ProductoLista lista = new ProductoLista();
            dataGridView1.DataSource = lista.Listar();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void btnCobrarEfectivo_Click(object sender, EventArgs e)
        {
            int Total, Efectivo, Vuelto;
            if (int.TryParse(txtEfectivo.Text, out Efectivo) && int.TryParse(lblTotal.Text, out Total))
            {
               Vuelto = Total - Efectivo;
                lblVuelto.Text = Vuelto.ToString();
            }

        }

        private void lblVuelto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            int Total, Efectivo, Vuelto;
            if (int.TryParse(txtEfectivo.Text, out Efectivo) && int.TryParse(lblTotal.Text, out Total))
            {
                Vuelto = Total - Efectivo;
                lblVuelto.Text = Vuelto.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
