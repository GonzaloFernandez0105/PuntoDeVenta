namespace PuntoDeVenta1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMP = new System.Windows.Forms.Button();
            this.btnCobrarEfectivo = new System.Windows.Forms.Button();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesPorcentaje = new System.Windows.Forms.Button();
            this.btnAdPorcentaje = new System.Windows.Forms.Button();
            this.btnCalcelarVenta = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.analizarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            resources.ApplyResources(this.calculadoraToolStripMenuItem, "calculadoraToolStripMenuItem");
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            resources.ApplyResources(this.notasToolStripMenuItem, "notasToolStripMenuItem");
            // 
            // analizarToolStripMenuItem
            // 
            this.analizarToolStripMenuItem.Name = "analizarToolStripMenuItem";
            resources.ApplyResources(this.analizarToolStripMenuItem, "analizarToolStripMenuItem");
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.proToolStripMenuItem,
            this.toolStripMenuItem2});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            resources.ApplyResources(this.buscarToolStripMenuItem, "buscarToolStripMenuItem");
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            resources.ApplyResources(this.ventaToolStripMenuItem, "ventaToolStripMenuItem");
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // proToolStripMenuItem
            // 
            this.proToolStripMenuItem.Name = "proToolStripMenuItem";
            resources.ApplyResources(this.proToolStripMenuItem, "proToolStripMenuItem");
            this.proToolStripMenuItem.Click += new System.EventHandler(this.proToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruccionesToolStripMenuItem,
            this.comandosToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            // 
            // instruccionesToolStripMenuItem
            // 
            this.instruccionesToolStripMenuItem.Name = "instruccionesToolStripMenuItem";
            resources.ApplyResources(this.instruccionesToolStripMenuItem, "instruccionesToolStripMenuItem");
            // 
            // comandosToolStripMenuItem
            // 
            this.comandosToolStripMenuItem.Name = "comandosToolStripMenuItem";
            resources.ApplyResources(this.comandosToolStripMenuItem, "comandosToolStripMenuItem");
            // 
            // btnMP
            // 
            this.btnMP.BackColor = System.Drawing.Color.Orange;
            this.btnMP.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMP, "btnMP");
            this.btnMP.Name = "btnMP";
            this.btnMP.UseVisualStyleBackColor = false;
            // 
            // btnCobrarEfectivo
            // 
            this.btnCobrarEfectivo.BackColor = System.Drawing.Color.Orange;
            this.btnCobrarEfectivo.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCobrarEfectivo, "btnCobrarEfectivo");
            this.btnCobrarEfectivo.Name = "btnCobrarEfectivo";
            this.btnCobrarEfectivo.UseVisualStyleBackColor = false;
            this.btnCobrarEfectivo.Click += new System.EventHandler(this.btnCobrarEfectivo_Click);
            // 
            // txtEfectivo
            // 
            resources.ApplyResources(this.txtEfectivo, "txtEfectivo");
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblVuelto
            // 
            resources.ApplyResources(this.lblVuelto, "lblVuelto");
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Click += new System.EventHandler(this.lblVuelto_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnDesPorcentaje
            // 
            this.btnDesPorcentaje.BackColor = System.Drawing.Color.Orange;
            this.btnDesPorcentaje.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDesPorcentaje, "btnDesPorcentaje");
            this.btnDesPorcentaje.Name = "btnDesPorcentaje";
            this.btnDesPorcentaje.UseVisualStyleBackColor = false;
            // 
            // btnAdPorcentaje
            // 
            this.btnAdPorcentaje.BackColor = System.Drawing.Color.Orange;
            this.btnAdPorcentaje.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAdPorcentaje, "btnAdPorcentaje");
            this.btnAdPorcentaje.Name = "btnAdPorcentaje";
            this.btnAdPorcentaje.UseVisualStyleBackColor = false;
            // 
            // btnCalcelarVenta
            // 
            this.btnCalcelarVenta.BackColor = System.Drawing.Color.Orange;
            this.btnCalcelarVenta.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCalcelarVenta, "btnCalcelarVenta");
            this.btnCalcelarVenta.Name = "btnCalcelarVenta";
            this.btnCalcelarVenta.UseVisualStyleBackColor = false;
            this.btnCalcelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.Color.Orange;
            this.btnRestar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnRestar, "btnRestar");
            this.btnRestar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.UseVisualStyleBackColor = false;
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.Color.Orange;
            this.btnSumar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSumar, "btnSumar");
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Name = "panel3";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProducto,
            this.Precio,
            this.Nombre,
            this.Cantidad,
            this.Stock});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblBuscar
            // 
            resources.ApplyResources(this.lblBuscar, "lblBuscar");
            this.lblBuscar.Name = "lblBuscar";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // btnBuscar
            // 
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblFecha
            // 
            resources.ApplyResources(this.lblFecha, "lblFecha");
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblHora
            // 
            resources.ApplyResources(this.lblHora, "lblHora");
            this.lblHora.Name = "lblHora";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.Moccasin;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Name = "panel4";
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Tag = "";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.lblHora);
            this.panel6.Controls.Add(this.lblFecha);
            this.panel6.Name = "panel6";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.UseWaitCursor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnDesPorcentaje);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnCalcelarVenta);
            this.panel1.Controls.Add(this.btnSumar);
            this.panel1.Controls.Add(this.btnRestar);
            this.panel1.Controls.Add(this.btnAdPorcentaje);
            this.panel1.Name = "panel1";
            // 
            // CodProducto
            // 
            resources.ApplyResources(this.CodProducto, "CodProducto");
            this.CodProducto.Name = "CodProducto";
            // 
            // Precio
            // 
            resources.ApplyResources(this.Precio, "Precio");
            this.Precio.Name = "Precio";
            // 
            // Nombre
            // 
            resources.ApplyResources(this.Nombre, "Nombre");
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            resources.ApplyResources(this.Cantidad, "Cantidad");
            this.Cantidad.Name = "Cantidad";
            // 
            // Stock
            // 
            resources.ApplyResources(this.Stock, "Stock");
            this.Stock.Name = "Stock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtEfectivo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnMP);
            this.panel2.Controls.Add(this.lblVuelto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCobrarEfectivo);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.Button btnMP;
        private System.Windows.Forms.Button btnDesPorcentaje;
        private System.Windows.Forms.Button btnAdPorcentaje;
        private System.Windows.Forms.Button btnCalcelarVenta;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnCobrarEfectivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Panel panel2;
    }
}

