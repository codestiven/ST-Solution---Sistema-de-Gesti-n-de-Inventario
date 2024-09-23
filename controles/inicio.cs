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
using System.Windows.Forms.DataVisualization.Charting;

namespace Práctica_de_acceso_a_Datos.controles
{
    public partial class inicio : UserControl
    {
        public inicio()
        {
            InitializeComponent();

            // Crear datos de ejemplo
            int[] valores = { 10, 20, 30, 40, 500 };
            string[] etiquetas = { "A", "B", "C", "D", "E" };

            // Asignar datos al chart
            chart1.Series[0].Points.DataBindXY(etiquetas, valores);

            // Establecer tipo de gráfico
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }

        private void gunaChart1_Load(object sender, EventArgs e)
        {
     
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void gunaChart1_Load_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

            string nombre_dispositivo = "DESKTOP-OBF3EB5\\SQLEXPRESS";
            string base_de_datos = "Gestion_de_Inventario";

            // Conexión a la base de datos
            string connectionString =$"Data Source={nombre_dispositivo}; Initial Catalog={base_de_datos}; Integrated Security = true ";
            string consulta = "SELECT nombre, COUNT(*) AS Total FROM Productos GROUP BY nombre;";

            // Crear conexión a la base de datos y ejecutar consulta
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();

            // Crear lista para almacenar los datos
            List<string> categorias = new List<string>();
            List<int> totales = new List<int>();

            // Leer los datos de la base de datos y agregarlos a la lista
            while (lector.Read())
            {
                categorias.Add(lector["nombre"].ToString());
                totales.Add(Convert.ToInt32(lector["Total"]));
            }

            // Asignar los datos al Chart
            chart1.Series[0].Points.DataBindXY(categorias, totales);

            // Establecer tipo de gráfico
            chart1.Series[0].ChartType = SeriesChartType.Pie;

            // Cerrar la conexión a la base de datos
            lector.Close();
            conexion.Close();

        }
    }
}
