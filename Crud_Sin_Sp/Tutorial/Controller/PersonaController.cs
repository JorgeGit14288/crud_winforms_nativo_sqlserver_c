using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.Model;



namespace Tutorial.Controller 
{
    class PersonaController : Conexion
    {

        public PersonaController()
        {

        }
        public String Insertar(Persona persona)
        {
            string salida = "se ha insertado";

            try
            {
                Conectar();
             //   connection.Open();
                command = new SqlCommand("INSERT INTO Persona(id, Nombre, Apellidos, FechaNacimiento) VALUES ( "+persona.id+",'"+persona.Nombre+"','"+persona.Apellidos+"','"+persona.fechaNacimiento+"')",connection);
                command.ExecuteNonQuery();
             //   connection.Close();
                Desconectar();
            }
            catch(Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public int personaIngresada(int id)
        {
            int contador = 0;

            try
            {
                Conectar();
                command = new SqlCommand("SELECT* FROM Persona where id="+id+"", this.connection);
                dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    contador++;
                }
                dataReader.Close();
                Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto: " + ex.ToString());
            }
            return contador;
        }
        public DataTable getAllPersona()
        {
            dataTable = new DataTable();
            try
            {
                Conectar();
                dataAdapter = new SqlDataAdapter("Select * From Persona", connection);
//                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                //dgv.DataSource = dataTable;
                Desconectar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo realizar la consulta " + ex.ToString());
            }
            return dataTable;
        }
        public Persona getId(int id)
        {
            Persona persona = new Persona();
            try
            {
                Conectar();
                command = new SqlCommand("Select * from Persona where Id =" + id + "", connection);
                dataReader = command.ExecuteReader();
                if(dataReader.Read())
                {
                    persona.id = id;
                    persona.Nombre = dataReader["Nombre"].ToString();
                    persona.Apellidos = dataReader["Apellidos"].ToString();
                    persona.fechaNacimiento = dataReader["FechaNacimiento"].ToString();
                    

                }
                dataReader.Close();
                Desconectar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
            }
            return persona;
        }

        public string Update(Persona persona)
        {
            string salida = "Se han actualizado los datos";
            try
            {
                Conectar();
                command = new SqlCommand("Update Persona Set Nombre='"+persona.Nombre+"',Apellidos='"+persona.Apellidos+"', FechaNacimiento='"+persona.fechaNacimiento+"' where Id="+persona.id+"", connection);
                command.ExecuteNonQuery();
                Desconectar();

            }
            catch(Exception ex)
            {
                salida = "No se actualizo "+ex.ToString();
            }
            return salida;
        }
        public string Delete(int id)
        {
            string salida = "Se han Eliminado los datos";
            try
            {
                Conectar();
                command = new SqlCommand("Delete from Persona  where Id=" +id + "", connection);
                command.ExecuteNonQuery();
                Desconectar();

            }
            catch (Exception ex)
            {
                salida = "No se Elimino" + ex.ToString();
            }
            return salida;
        }

    }
}
