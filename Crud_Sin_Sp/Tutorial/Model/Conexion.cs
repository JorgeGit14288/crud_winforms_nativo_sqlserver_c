using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // importamos estas tres librerias para poder conectarnos.
using System.Data.Sql;


using System.Windows.Forms;

namespace Tutorial.Model
{
    
    class Conexion
    {
        // creamos nuestras variables de conexion
       public SqlConnection connection;
       public SqlCommand command;
       public  SqlDataReader dataReader;
       public DataTable dataTable;
       public SqlDataAdapter dataAdapter;
        // creamos nuestro constructor
        public Conexion()
        {
            // creamos el try and catch
            
            
                // para saber la cadena de conexin, conectamos en server explorer, y luego en sus 
                // propiedades copiamos lo que dice Connection String donde halla slash le colocamos doble gracias

                // Data Source=DESKTOP-AO0267H\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True


            connection = new SqlConnection("Data Source=ASUSCRACK\\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True");
       

            }
            public void Conectar()
            {
                try
                {
                    connection.Open();
                    //MessageBox.Show("Conectado con la bd");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se conecto a la bd "+ ex.ToString());
                }
            }
        public void Desconectar()
        {
            try
            {
                connection.Close();
            }
            catch(Exception ex)
            {
                 MessageBox.Show("No se conecto a la bd "+ ex.ToString());
            }
        }
          
        
    }
}
