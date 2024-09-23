using Práctica_de_acceso_a_Datos.controles.producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_de_acceso_a_Datos.controles
{
    public partial class productos : UserControl
    {
        public productos()
        {
            InitializeComponent();
        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agregar_producto_Click(object sender, EventArgs e)
        {
            Agregar_productos entrar = new Agregar_productos();
            entrar.ShowDialog();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter1.FillBy(this.gestion_de_InventarioDataSet1.Productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void productos_Load(object sender, EventArgs e)
        {

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            Modiciar_producto entrar = new Modiciar_producto();
            entrar.ShowDialog();
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter2.FillBy(this.gestion_de_InventarioDataSet4.Productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void actualizarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter2.actualizar(this.gestion_de_InventarioDataSet4.Productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actualizaraToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter2.actualizara(this.gestion_de_InventarioDataSet4.Productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void actualizarToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter3.Actualizar(this.gestion_de_InventarioDataSet6.Productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            buscar entrar = new buscar();
            entrar.ShowDialog();
        }
    }
}
