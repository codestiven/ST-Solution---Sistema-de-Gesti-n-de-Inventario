using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_de_acceso_a_Datos.controles.producto
{
    public partial class Agregar_productos : Form
    {
        public Agregar_productos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string descripcionn = descripcion.Text;
            string valor = precio.Text;
            string objeto = cantidad.Text;
            string fecha_registro = fecha.Text;

            DateTime subir = DateTime.Parse(fecha_registro);
            Controlador salida = new Controlador();

            salida.agregar_productos(nombre, descripcionn, valor, objeto, subir);


            MessageBox.Show("se agrego los datos de manera exitosa");

            this.Close();
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
