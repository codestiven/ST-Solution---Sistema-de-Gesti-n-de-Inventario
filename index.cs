using Guna.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using Negocio;

namespace Práctica_de_acceso_a_Datos
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }
        private void iniciar_Click(object sender, EventArgs e)
        {
            Negocio.Controlador salida = new Controlador();
            string corr = correo.Text;
            string contra = contrasena.Text;
            int rg = salida.buscar_correo(corr, contra);


            if (rg == 0)
            {

                MessageBox.Show("el correo electronico esta incorrecto");
            }


            if (rg == 1)
            {

                MessageBox.Show("la contraseña esta incorrecta");
            }


            if (rg == 2)
            {

                Principal abrir = new Principal();
                this.Hide();
                abrir.administrador = false;
                abrir.Show();


            }
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
               registro abrir = new registro();
                this.Hide();

                abrir.Show();

        }

        private void index_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestion_de_InventarioDataSet3.Productos' Puede moverla o quitarla según sea necesario.
  

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            administrador abrir = new administrador();
            this.Hide();

            abrir.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
