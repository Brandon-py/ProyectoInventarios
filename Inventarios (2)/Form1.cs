using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace Gestion_de_usuarios
{
    public partial class Form1 : Form
    {

        ClaseModelo objent = new ClaseModelo();
        ClaseLogica objneg = new ClaseLogica();

        public Form1()
        {
            InitializeComponent();
        }


        void mantenimiento(String Accion)
        {
            objent.Codigo = txtCodigo.Text;
            objent.Descripcion = txtDescripcion.Text;
            objent.Cantidad = Convert.ToInt32(txtCantidad.Text);
            objent.Ubicacion = txtUbicacion.Text;
            objent.Accion = Accion;
            String men = objneg.N_mantenimiento_inventario(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        void limpiar ()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtUbicacion.Text = "";
            dataGridView1.DataSource = objneg.N_listar_productos();


        }

        private void Form1_load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_productos();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void RegistrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas Registrar a " + txtCodigo.Text + "?", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();


                }


            }
        }



        private void ModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas modifiacar a " + txtCodigo.Text + "?", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();


                }


            }



        }


        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas Eliminar a " + txtCodigo.Text + "?", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();


                }


            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                objent.Codigo = txtBuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_productos(objent);
                dataGridView1.DataSource = dt;


            }
            else 
            {
                dataGridView1.DataSource = objneg.N_listar_productos();

            }
        }
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            txtCodigo.Text = dataGridView1[0,fila].Value.ToString();
            txtDescripcion.Text = dataGridView1[1, fila].Value.ToString();
            txtCantidad.Text = dataGridView1[2, fila].Value.ToString();
            txtUbicacion.Text = dataGridView1[3, fila].Value.ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
