using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_de_acceso_a_Datos.controles.producto
{
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            Controlador salida = new Controlador();
            SqlDataReader rg = salida.buscar(entrada.Text);
            rg.Read();
            nombre.Text = rg["nombre"].ToString();
            descripcion.Text = rg["descripcion"].ToString();
            cantidad.Text = rg["descripcion"].ToString();
            precio.Text = rg["precio"].ToString();
            cantidad.Text = rg["cantidad"].ToString();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
