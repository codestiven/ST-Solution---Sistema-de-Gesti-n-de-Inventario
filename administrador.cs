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

namespace Práctica_de_acceso_a_Datos
{
    public partial class administrador : Form
    {
        public administrador()
        {
            InitializeComponent();
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            registro abrir = new registro();
            this.Hide();

            abrir.Show();
        }



        private void iniciar_Click_1(object sender, EventArgs e)
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
                abrir.administrador = true;
                abrir.Show();



            }
        }
    }
}
