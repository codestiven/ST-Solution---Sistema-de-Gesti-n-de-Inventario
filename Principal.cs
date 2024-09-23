using Guna.UI2.WinForms;
using Práctica_de_acceso_a_Datos.controles;
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

    public partial class Principal : Form
    {
        public bool administrador = false;

        public Principal()
        {
            InitializeComponent();

            inicio ca = new inicio();
            agregar_nuevo(ca);

            if (administrador == true)
            {
                tipo.Text = "administrador";
            }
            else
            {
                tipo.Text = "usuario";
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 24, b.Location.Y - 25);
            imgSlide.SendToBack();

            panelContenedor.Controls.Clear();


        }

        private void agregar_nuevo(UserControl uc)
        {


            panelContenedor.Controls.Clear();

            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            panelContenedor.Controls.Add(uc);


        }


        private void guna2Button2_CheckedChanged(object sender, EventArgs e)
        {

            moveImageBox(sender);
     
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            inicio ca = new inicio();
            agregar_nuevo(ca);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {
      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            fecha.Text = DateTime.Now.ToString();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            productos ca = new productos();
            agregar_nuevo(ca);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestion_de_InventarioDataSet2.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.gestion_de_InventarioDataSet2.Productos);

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
