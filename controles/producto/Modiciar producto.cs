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
    public partial class Modiciar_producto : Form
    {
        public Modiciar_producto()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string descripcionn = descripcion.Text;
            string valor = precio.Text;
            string objeto = cantidad.Text;
            string fecha_registro = fecha.Text;
            string idd = id.Text;

            Controlador salida = new Controlador();
            salida.modificar_producto(nombre, descripcionn, valor, objeto, idd);

            MessageBox.Show("se modifico los datos de manera esitosa");
        }
    }
}
