using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data; // importamos estas tres librerias para poder conectarnos.
using System.Data.Sql;
using System.Data.SqlClient;

namespace Tutorial
{
    public partial class visorReporte : Form
    {
        public visorReporte()
        {
            InitializeComponent();
        }
        
        private void visorReporte_Load(object sender, EventArgs e)
        {
            Reportar();
        }

        private void Reportar()
        {
            string sqlConsulta = "select * from Persona";

            dsPersona varDsPersona = new dsPersona();

            try
            {
                // creamos los data adapters
                SqlConnection conn = new SqlConnection("Data Source=ASUSCRACK\\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True");
                SqlDataAdapter sqlDaPersona = new SqlDataAdapter(sqlConsulta, conn);
                // empezamos a llenar las tablas
                sqlDaPersona.Fill(varDsPersona, "Persona");

                // ahora poblamos el informe y lo mostramos
                crReporte informe = new crReporte();
                informe.SetDataSource(varDsPersona);
                crvPersona.ReportSource = informe;



            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo completar el reporte " + ex.ToString());
            }
        }
    }
}
