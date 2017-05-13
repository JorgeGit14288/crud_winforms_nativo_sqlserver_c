using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace Tutorial.Model
{
    class Persona
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string fechaNacimiento { get; set; }
    }
}
