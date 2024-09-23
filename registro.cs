using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Acceso_a_datos;
using System.Drawing.Imaging;

namespace Práctica_de_acceso_a_Datos
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     




        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void contrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
            DialogResult result = dialogo.ShowDialog();

            if (result == DialogResult.OK)
            {
                img.Image = Image.FromFile(dialogo.FileName);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (Correo.Text != "")
            {



            string nombre_dispositivo = "DESKTOP-OBF3EB5\\SQLEXPRESS";
            string base_de_datos = "Gestion_de_Inventario";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = $"Data Source={nombre_dispositivo}; Initial Catalog={base_de_datos}; Integrated Security = true ";
            if (cn.State == ConnectionState.Closed) cn.Open();

            string respuesta;

            SqlCommand cmd = new SqlCommand();
            MemoryStream archivo = new MemoryStream();

            Acceso_a_datos.datos entrada = new datos();
        
            cmd.Connection = cn; 
            img.Image.Save(archivo,ImageFormat.Bmp);

            cmd.CommandText = "spUsuario";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", nombre.Text);
            cmd.Parameters.AddWithValue("@Apellido", apellido.Text);
            cmd.Parameters.AddWithValue("@Correo", Correo.Text);
            cmd.Parameters.AddWithValue("@Contraseña", contraseña.Text);
            cmd.Parameters.AddWithValue("@Fecha", DateTime.Parse(fecha.Text));
            cmd.Parameters.AddWithValue("@Genero", genero.Text);
            cmd.Parameters.AddWithValue("@Imagen", archivo.GetBuffer());



            respuesta = cmd.ExecuteNonQuery() > 0 ? "sii" : "noooo";

            MessageBox.Show("datos guardados");


            index abrir = new index();
            this.Hide();

            abrir.Show();

            }
            else
            {
                MessageBox.Show("introduce un dato");
            }

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
