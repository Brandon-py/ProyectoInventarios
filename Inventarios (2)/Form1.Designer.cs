namespace Gestion_de_usuarios
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifcarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.registrarToolStripMenuItem,
            this.modifcarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.RegistrarToolStripMenuItem_Click);
            // 
            // modifcarToolStripMenuItem
            // 
            this.modifcarToolStripMenuItem.Name = "modifcarToolStripMenuItem";
            this.modifcarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.modifcarToolStripMenuItem.Text = "Modifcar";
            this.modifcarToolStripMenuItem.Click += new System.EventHandler(this.ModificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(76, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(76, 88);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(115, 20);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(280, 88);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(115, 20);
            this.txtUbicacion.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(280, 21);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(123, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ubicacion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(70, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(115, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codigo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Location = new System.Drawing.Point(12, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 166);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(397, 140);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(101, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(115, 20);
            this.textBox6.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifcarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
    }
}

