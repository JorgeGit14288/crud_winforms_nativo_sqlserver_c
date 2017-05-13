using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.Model;
using Tutorial.Controller;
using System.Globalization;

namespace Tutorial
{
    public partial class formPersona : Form
    {
        public formPersona()
        {
            InitializeComponent();
        }

        private void formPersona_Load(object sender, EventArgs e)
        {
           // Conexion varConexion = new Conexion();
            PersonaController personaHelper = new PersonaController();
            dgvPersona.DataSource= personaHelper.getAllPersona();
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PersonaController personaHelper = new PersonaController();
            Persona persona = new Persona();
            persona.id = Int32.Parse(txtId.Text);
            persona.Nombre = txtNombre.Text;
            persona.Apellidos = txtApellidos.Text;
            //string date = numYear + "-" + numMes + "=" + numDia;
            persona.fechaNacimiento = dtpFecha.Value.Date.ToString();

            if (personaHelper.personaIngresada(persona.id)==0)
            {
               MessageBox.Show( personaHelper.Insertar(persona));
               dgvPersona.DataSource = personaHelper.getAllPersona();
               txtApellidos.Text = null;
               txtId.Text = null;
               txtNombre.Text = null;

            }
            else
            {
                MessageBox.Show("Imposile Guardar el registro ");
            }


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PersonaController  personaHelper = new PersonaController();
            Persona persona = new Persona();
            if(txtId.Text!=null)
            {
                try
                {
                    if(personaHelper.personaIngresada(Convert.ToInt32(txtId.Text))>0)
                    {
                        persona = personaHelper.getId(Convert.ToInt32(txtId.Text));
                        txtNombre.Text = persona.Nombre;
                        txtApellidos.Text = persona.Apellidos;
                        dtpFecha.Text = persona.fechaNacimiento; 
                    }
                    else
                    {
                        txtApellidos.Text = null;
                        txtId.Text = null;
                        txtNombre.Text = null;
                    }


                }
                catch(Exception ex)
                {

                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PersonaController personaHelper = new PersonaController();
            Persona persona = new Persona();
            persona.id=Convert.ToInt32(txtId.Text);
            persona.Nombre= txtNombre.Text;
            persona.Apellidos=txtApellidos.Text;
            persona.fechaNacimiento=dtpFecha.Text;
            MessageBox.Show(personaHelper.Update(persona));

            dgvPersona.DataSource = personaHelper.getAllPersona();
    
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonaController personaHelper = new PersonaController();
            
            
            MessageBox.Show(personaHelper.Delete(Convert.ToInt32(txtId.Text)));

            dgvPersona.DataSource = personaHelper.getAllPersona();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            visorReporte var = new visorReporte();
            var.Show();
        }
    }
}
